using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCEG.ScoreboardPc.Data;

namespace SCEG.ScoreboardPc.Business
{
    class AresCommandFactory
    {
        private readonly ViewController ctrl;
        private readonly Timer timer;

        private const byte aresStartByte = 0x81;
        private const byte aresEndByte = 0x84;

        private readonly List<byte> command;

        public long SuccssCommandCount { get; private set; }
        public long IgnoredCommandsCount { get; private set; }
        private DateTime lastReset;

        private readonly TimeSpan oneMinute = new TimeSpan(0,0,1,0);

        public AresCommandFactory(ViewController ctrl)
        {
            this.ctrl = ctrl;
            command = new List<byte>();
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += TimerOnTick;
            timer.Start();
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            if (ctrl == null) return;
            if (ctrl.SerialPortInput == null) return;
            if (!ctrl.SerialPortInput.Any()) return;

            timer.Stop();
            while (!ctrl.SerialPortInput.IsEmpty)
            {
                byte currentByte;
                if (ctrl.SerialPortInput.TryDequeue(out currentByte))
                {
                    switch (currentByte)
                    {
                        case aresStartByte:
                            command.Clear();
                            command.Add(currentByte);
                            break;
                        case aresEndByte:
                            command.Add(currentByte);
                            GenerateCommand(command);
                            command.Clear();
                            break;
                        default:
                            command.Add(currentByte);
                            break;
                    } 
                }
              
            }
            timer.Start();
        }

        private void GenerateCommand(List<byte> commandToGenerate)
        {
            AresCommand commandToAdd = null;

            if (AktuelleZeit.IsValid(commandToGenerate)) commandToAdd = new AktuelleZeit(commandToGenerate);
            //if (NeuerWettkampf.IsValid(commandToGenerate)) commandToAdd = new NeuerWettkampf(commandToGenerate);
            if (RennenUndLauf.IsValid(commandToGenerate)) commandToAdd = new RennenUndLauf(commandToGenerate);
            if (BahnInfo.IsValid(commandToGenerate)) commandToAdd = new BahnInfo(commandToGenerate);

            var now = DateTime.Now;
            if (now - lastReset > oneMinute)
            {
                SuccssCommandCount = 0;
                IgnoredCommandsCount = 0;
                lastReset = now;
            }
            
            if (commandToAdd != null)
            {
                ctrl.CommandsWorkload.Enqueue(commandToAdd);
                SuccssCommandCount++;
            }
            else
            {
                IgnoredCommandsCount++;
                Console.WriteLine("Nicht interpretierter command: " + HelperMethods.ByteArrayToString(commandToGenerate.ToArray()));
            }

        }
    }
}
