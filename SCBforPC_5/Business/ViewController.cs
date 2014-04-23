using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using SCEG.ScoreboardPc.Data;

namespace SCEG.ScoreboardPc.Business
{
    class ViewController
    {
        public FtpConfig CurrentFtpConfig { get; private set; }
        public SerialPort CurrentSerialPort { get; private set; }
        public bool FtpAutoUpload { get; set; }

        public ConcurrentQueue<byte> SerialPortInput { get; private set; }
        public ConcurrentQueue<AresCommand> CommandsWorkload { get; private set; }
        public AresCommandFactory AresFactory { get; private set; }

        public ViewController()
        {
            FtpAutoUpload = false;
            SerialPortInput = new ConcurrentQueue<byte>();
            CommandsWorkload = new ConcurrentQueue<AresCommand>();
            AresFactory = new AresCommandFactory(this);
            LoadFtpConfig();
            InitSerialPort();
        }


        #region SerialPort
        private void InitSerialPort()
        {
            //Werte für Seriell Port
            CurrentSerialPort = new SerialPort
                                    {
                                        Encoding = Encoding.Unicode,
                                        ReadTimeout = 500,
                                        Parity = Parity.None,
                                        DataBits = 8,
                                        Handshake = Handshake.None,
                                        StopBits = StopBits.One,
                                        DtrEnable = true
                                    };
            CurrentSerialPort.DataReceived += CurrentSerialPortOnDataReceived;

        }

        private void CurrentSerialPortOnDataReceived(object sender, SerialDataReceivedEventArgs serialDataReceivedEventArgs)
        {
            SerialPort sp = CurrentSerialPort;
            try
            {
                while (sp.IsOpen && sp.BytesToRead != 0)
                {
                    SerialPortInput.Enqueue(Convert.ToByte(sp.ReadByte()));
                }
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Fehler");
            }
        }

        public void StartReadFromSerialPort()
        {
            //Öffnen der seriellen Schnittstelle
            CurrentSerialPort.Open();
            CurrentSerialPort.DiscardInBuffer();      // Serialport Buffer löschen
        }

        public void StopReadFromSerialPort()
        {
            if (CurrentSerialPort.IsOpen)
            {
                CurrentSerialPort.Close();
            }
        }
        #endregion


        #region FTP
        public void FtpUpload()
        {
            //string Message;
            //ClassFTP FTP = new ClassFTP();  // Create an object
            //Message = FTP.FTPUpload(txtFtpServer.Text, txtFtpPath.Text, txtFtpFile.Text, txtFtpUser.Text, txtFtpPassword.Text, (((DatenarrayTemp[21] & 0x0F) * 10) + (DatenarrayTemp[22] & 0x0F)).ToString(), (((DatenarrayTemp[24] & 0x0F) * 10) + (DatenarrayTemp[25] & 0x0F)).ToString());
            //if (Message == "")
            //{
            //    DateTime d = DateTime.Now;
            //    txtFtpLastUpload.Text = Convert.ToString(d);
            //}
            //else
            //{
            //    txtFtpLastUpload.Text = Message;
            //}

        }


        public void LoadFtpConfig()
        {
            if (!File.Exists(FtpConfig.FileName))
            {
                CurrentFtpConfig = null;
            }
            else
            {
                string[] lines = File.ReadAllLines(FtpConfig.FileName);
                CurrentFtpConfig = new FtpConfig()
                {
                    FTPServer = lines[1],
                    FTPPath = lines[2],
                    FTPFile = lines[3],
                    FTPUser = lines[4],
                    FTPPassword = lines[5]
                };
            }           
        }

        public void SaveFtpConfig()
        {
            List<string> lines = new List<string>
                                     {
                                         "FTP config:",
                                         CurrentFtpConfig.FTPServer,
                                         CurrentFtpConfig.FTPPath, 
                                         CurrentFtpConfig.FTPFile, 
                                         CurrentFtpConfig.FTPUser, 
                                         CurrentFtpConfig.FTPPassword
                                     };
            File.WriteAllLines(FtpConfig.FileName, lines.ToArray());
        }

        #endregion

    }
}
