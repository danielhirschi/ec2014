using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCEG.ScoreboardPc.Business;
using SCEG.ScoreboardPc.Data;

namespace SCEG.ScoreboardPc.View
{
    

    public partial class Scoreboard : Form
    {
        private readonly ViewController ctrl;
        private readonly Timer commandTimer;
        private readonly List<TextBox> txtTime;
        private readonly List<TextBox> txtRang;
        private readonly List<TextBox> txtBahn;
        private const int AnzahlBahnen = 8;

        public Scoreboard()
        {
            InitializeComponent();
            ctrl = new ViewController();

            //view initialisieren
            lsbComPort.Items.AddRange(new object[]
                                          {
                                              "COM1",
                                              "COM2",
                                              "COM3",
                                              "COM4"
                                          });
            lsbComPort.SelectedIndex = 3;
            lsbComPort_SelectedIndexChanged(null,null);
            lsbBaudRate.Items.AddRange(new object[]
                                           {
                                               9600,
                                               19200
                                           });
            lsbBaudRate.SelectedIndex = 0;
            lsbBaudRate_SelectedIndexChanged(null, null);

            //Kommando interpreter
            commandTimer = new Timer();
            commandTimer.Interval = 10;
            commandTimer.Tick += CommandTimerOnTick;
            commandTimer.Start();

            //als Array abfüllen
            txtTime = new List<TextBox> {txtTime1, txtTime2, txtTime3, txtTime4, txtTime5, txtTime6, txtTime7, txtTime8};

            txtRang = new List<TextBox> {txtRang1, txtRang2, txtRang3, txtRang4, txtRang5, txtRang6, txtRang7, txtRang8};

            txtBahn = new List<TextBox> {txtBahn1, txtBahn2, txtBahn3, txtBahn4, txtBahn5, txtBahn6, txtBahn7, txtBahn8};


            // Button freigeben/sperren
            butOpenPort.Enabled = true;
            butClosePort.Enabled = false;
        }

        private void CommandTimerOnTick(object sender, EventArgs eventArgs)
        {
            if (ctrl == null) return;
            if (ctrl.CommandsWorkload == null) return;

            commandTimer.Stop();
            while (!ctrl.CommandsWorkload.IsEmpty)
            {
                AresCommand command = null;
                if (ctrl.CommandsWorkload.TryDequeue(out command))
                {
                    InterPretCommand(command);
                    OnAresCommandIcoming(command);
                }
            }
            commandTimer.Start();
        }

        private void InterPretCommand(AresCommand command)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<AresCommand>(InterPretCommand), new object[] {command});
            }
            else
            {
                txtCommandsSucces.Text = ctrl.AresFactory.SuccssCommandCount.ToString();
                txtCommandsIgnored.Text = ctrl.AresFactory.IgnoredCommandsCount.ToString();

                if (command is AktuelleZeit)
                {
                    txtAktuelleZeit.Text = String.Format("{0:hh\\:mm\\:ss\\:f}", (command as AktuelleZeit).Time);
                }
                else if (command is NeuerWettkampf)
                {
                    txtAktuelleZeit.Text = String.Format("{0:hh\\:mm\\:ss\\:f}", new TimeSpan());
                    ClearScoreboard();
                }
                else if (command is RennenUndLauf)
                {
                    var spec = (RennenUndLauf) command;
                    txtRennenNr.Text = spec.RennenNr.ToString(CultureInfo.CurrentUICulture);
                    txtLaufNr.Text = spec.LaufNr.ToString(CultureInfo.CurrentUICulture);
                }
                else if (command is BahnInfo)
                {
                    var spec = (BahnInfo)command;
                    if (spec.Rang <= AnzahlBahnen)
                    {
                        if (spec.Loeschen)
                        {
                            txtTime[spec.Rang - 1].Text = String.Empty;
                            txtRang[spec.Rang - 1].Text = String.Empty;
                            txtBahn[spec.Rang - 1].Text = String.Empty;
                        }
                        else
                        {
                            txtTime[spec.Rang - 1].Text = String.Format("{0:hh\\:mm\\:ss\\:ff}", spec.Time);
                            txtRang[spec.Rang - 1].Text = spec.Rang.ToString();
                            txtBahn[spec.Rang - 1].Text = spec.BahnNr.ToString();
                        }
                    }
                }
            }

            
        }


        // SCB löschen
        private void ClearScoreboard()
        {
            for (int i = 0; i < AnzahlBahnen; i++)
            {
                txtTime[i].Text = String.Empty;
                txtRang[i].Text = String.Empty;
                txtBahn[i].Text = String.Empty;
            }
        }

        #region Serial Port

        private void butOpenPort_Click(object sender, EventArgs e)
        {
            ctrl.StartReadFromSerialPort();
            butOpenPort.Enabled = false;
            butClosePort.Enabled = true;
        }

        /// <summary>
        /// Schließen der seriellen Schnittstelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ClosePort_Click(object sender, EventArgs e)
        {
            ctrl.StopReadFromSerialPort();
            butOpenPort.Enabled = true;
            butClosePort.Enabled = false;
        }

        private void lsbComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrl.CurrentSerialPort.PortName = lsbComPort.Text;
        }

        private void lsbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrl.CurrentSerialPort.BaudRate = Convert.ToInt32(lsbBaudRate.Text);
        }
        #endregion



        public delegate void AresCommandEventHandler(object sender, AresCommand aresCommand);
        public event AresCommandEventHandler AresCommandIcoming;

        public virtual void OnAresCommandIcoming(AresCommand aresCommand)
        {
            if (AresCommandIcoming != null)
                AresCommandIcoming(this, aresCommand);
        }
    }
}
