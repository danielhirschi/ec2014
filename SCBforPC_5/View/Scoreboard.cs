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
        private List<TextBox> txtTime;
        private List<TextBox> txtRang;
        private List<TextBox> txtBahn;
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
            txtTime = new List<TextBox>();
            txtTime.Add(txtTime1);
            txtTime.Add(txtTime2);
            txtTime.Add(txtTime3);
            txtTime.Add(txtTime4);
            txtTime.Add(txtTime5);
            txtTime.Add(txtTime6);
            txtTime.Add(txtTime7);
            txtTime.Add(txtTime8);

            txtRang = new List<TextBox>();
            txtRang.Add(txtRang1);
            txtRang.Add(txtRang2);
            txtRang.Add(txtRang3);
            txtRang.Add(txtRang4);
            txtRang.Add(txtRang5);
            txtRang.Add(txtRang6);
            txtRang.Add(txtRang7);
            txtRang.Add(txtRang8);

            txtBahn = new List<TextBox>();
            txtBahn.Add(txtBahn1);
            txtBahn.Add(txtBahn2);
            txtBahn.Add(txtBahn3);
            txtBahn.Add(txtBahn4);
            txtBahn.Add(txtBahn5);
            txtBahn.Add(txtBahn6);
            txtBahn.Add(txtBahn7);
            txtBahn.Add(txtBahn8);



            // Button freigeben/sperren
            butFTPAutoStop.Enabled = false;
            butFTPAutoStart.Enabled = true;
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
                        //if (spec.Rang > 0 && spec.BahnNr == 0 && spec.Loeschen)
                        //{
                        //    txtAktuelleZeit.Text = String.Format("{0:hh\\:mm\\:ss\\:f}", new TimeSpan());
                        //    ClearScoreboard();
                        //}
                        //else if (spec.Rang > 0)
                        //{
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
                        //}
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






        #region FTP

        private void butFTPAutoStart_Click(object sender, EventArgs e)
        {
            ctrl.FtpAutoUpload = true;
            butFTPAutoStop.Enabled = true;
            butFTPAutoStart.Enabled = false;
        }

        private void butFTPAutoStop_Click(object sender, EventArgs e)
        {
            ctrl.FtpAutoUpload = false;
            butFTPAutoStop.Enabled = false;
            butFTPAutoStart.Enabled = true;
        }

        private void butManUpload_Click(object sender, EventArgs e)
        {
            ctrl.FtpUpload();
        }


        /// <summary>
        /// Konfigurationsdaten laden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butFtpConfigLoad_Click(object sender, EventArgs e)
        {
            ctrl.LoadFtpConfig();
            if (ctrl.CurrentFtpConfig != null)
            {
                txtFtpServer.Text = ctrl.CurrentFtpConfig.FTPServer;
                txtFtpPath.Text = ctrl.CurrentFtpConfig.FTPPath;
                txtFtpFile.Text = ctrl.CurrentFtpConfig.FTPFile;
                txtFtpUser.Text = ctrl.CurrentFtpConfig.FTPUser;
                txtFtpPassword.Text = ctrl.CurrentFtpConfig.FTPPassword;
                txtFtpConfigStatus.Text = "Config load successfully";
            }
            else
            {
                txtFtpConfigStatus.Text = "Config does not exists";
            }
        }

        /// <summary>
        /// Konfigurationsdaten abspeichern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butFTPConfigSave_Click(object sender, EventArgs e)
        {
            ctrl.CurrentFtpConfig.FTPServer = txtFtpServer.Text;
            ctrl.CurrentFtpConfig.FTPPath = txtFtpPath.Text;
            ctrl.CurrentFtpConfig.FTPFile = txtFtpFile.Text;
            ctrl.CurrentFtpConfig.FTPUser = txtFtpUser.Text;
            ctrl.CurrentFtpConfig.FTPPassword = txtFtpPassword.Text;
            ctrl.SaveFtpConfig();
            txtFtpConfigStatus.Text = "Config save successfully";
        }

        #endregion


    }
}
