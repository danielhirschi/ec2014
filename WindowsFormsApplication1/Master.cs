using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCEG.ScoreboardPc.Data;
using SCEG.ScoreboardPc.View;

namespace WindowsFormsApplication1
{
    public partial class Master : Form
    {
        //Original Logo Grösse = 1181;1207
        //Farbe Logo 0;94;157
        private readonly Anzeige FormAnzeige = new Anzeige();
        private readonly Scoreboard FormScoreboard = new Scoreboard();

        protected DateTime? StartZeit { get; set; }
        protected int Rang { get; set; }
        protected bool IsBindWithScoreboard { get; set; }

        public Master()
        {
            InitializeComponent();
            StartZeit = null;
            Rang = 1;
            IsBindWithScoreboard = false;
            
        }

        private void timerzeit_Tick(object sender, EventArgs e)
        {
            if (IsBindWithScoreboard) return;
            lbl_zeit.Text = StartZeit == null ? (new TimeSpan()).ToString(@"mm\:ss\.f") : (DateTime.Now - StartZeit.Value).ToString(@"mm\:ss\.f");
            FormAnzeige.SetZeit(lbl_zeit.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormAnzeige.ShowLogo)
            {
                FormAnzeige.ShowLogo = false; 
                bu_Logo.Text = "Logo einblenden";
            }
            else
            {
                FormAnzeige.ShowLogo = true;
                bu_Logo.Text = "Logo ausblenden";
            }

        }

        private void Master_Load(object sender, EventArgs e)
        {
            FormAnzeige.Show(this);
            FormScoreboard.Show();
            timerzeit.Start();
            timeruhr.Start();
            txt_lauf_TextChanged(sender, e);
            txt_rennen_TextChanged(sender, e);
            textBox2_TextChanged(sender, e);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_uhr.Text = DateTime.Now.ToString("HH:mm");

        }

        private void lbl_uhr_TextChanged(object sender, EventArgs e)
        {
            FormAnzeige.SetUhr(lbl_uhr.Text);
        }

        private void but_Rennen_p_Click(object sender, EventArgs e)
        {
            txt_rennen.Text = (int.Parse(txt_rennen.Text) + 1).ToString();
        }

        private void but_Rennen_m_Click(object sender, EventArgs e)
        {
            txt_rennen.Text = (int.Parse(txt_rennen.Text) - 1).ToString();
        }

        private void but_Lauf_p_Click(object sender, EventArgs e)
        {
            txt_lauf.Text = (int.Parse(txt_lauf.Text) + 1).ToString();
        }

        private void but_Lauf_m_Click(object sender, EventArgs e)
        {
            txt_lauf.Text = (int.Parse(txt_lauf.Text) - 1).ToString();
        }

        private void txt_rennen_TextChanged(object sender, EventArgs e)
        {
            FormAnzeige.SetRennen(txt_rennen.Text);
        }

        private void txt_lauf_TextChanged(object sender, EventArgs e)
        {
            FormAnzeige.SetLauf(txt_lauf.Text);
        }

        private void but_zeit_Click(object sender, EventArgs e)
        {
            StartZeit = DateTime.Now;
        }





        // Sponsoren
        private void but_sponsoren_Click(object sender, EventArgs e)
        {
            if (FormAnzeige.IsShowSponsoren())
            {
                FormAnzeige.ShowSponsoren(false, int.Parse(textBox_sponor_interval.Text));
                but_sponsoren.Text = "Sponsoren Anzeigen";
            }
            else
            {
                FormAnzeige.ShowSponsoren(true, int.Parse(textBox_sponor_interval.Text));
                but_sponsoren.Text = "Sponsoren Stoppen";
            }
        }



        private void AktualisiereZwischenzeit(TimeSpan zwischenzeit, int bahn)
        {
            Label lbl = (Label)groupBox1.Controls["label_r" + Rang];
            lbl.Text = bahn.ToString() + "   " + zwischenzeit.ToString(@"mm\:ss\.f");
            FormAnzeige.SetZwischenzeitsetzen(lbl.Text, Rang);
            Rang = Rang + 1;
            if (Rang == 9)
            {
                FormAnzeige.SetZwischenzeitsetzen(" ", Rang);
                Rang = 1;
                
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AktualisiereZwischenzeit(DateTime.Now - StartZeit.Value, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AktualisiereZwischenzeit(DateTime.Now - StartZeit.Value, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AktualisiereZwischenzeit(DateTime.Now - StartZeit.Value, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AktualisiereZwischenzeit(DateTime.Now - StartZeit.Value, 4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AktualisiereZwischenzeit(DateTime.Now - StartZeit.Value, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AktualisiereZwischenzeit(DateTime.Now - StartZeit.Value, 6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AktualisiereZwischenzeit(DateTime.Now - StartZeit.Value, 7);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AktualisiereZwischenzeit(DateTime.Now - StartZeit.Value, 8);
        }



        private void button10_Click(object sender, EventArgs e)
        {
            StartZeit = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (FormAnzeige.ShowUhr)
            {
                FormAnzeige.ShowUhr = false;
                button11.Text = "Uhr einblenden";
            }
            else
            {
                FormAnzeige.ShowUhr = true;
                button11.Text = "Uhr ausblenden";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (FormAnzeige.ShowStatus)
            {
                FormAnzeige.ShowStatus = false;
                button12.Text = "Status einblenden";
            }
            else
            {
                FormAnzeige.ShowStatus = true;
                button12.Text = "Status ausblenden";
            }
            

        }

        private void lbl_zeit_TextChanged(object sender, EventArgs e)
        {
            FormAnzeige.SetZeit(lbl_zeit.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FormAnzeige.SetDisziplin(textBox2.Text);
        }

        private void timerstatus_Tick(object sender, EventArgs e)
        {
            FormAnzeige.ShowStatus = false;
            timerstatus.Stop();
        }

        private void butBindWithScoreboard_Click(object sender, EventArgs e)
        {
            if (FormScoreboard == null || FormScoreboard.IsDisposed) return;
            if (IsBindWithScoreboard)
            {
                FormScoreboard.AresCommandIcoming -= FormScoreboardOnAresCommandIcoming;
                IsBindWithScoreboard = false;
                butBindWithScoreboard.Text = "Mit scoreboard binden";
            }
            else
            {
                FormScoreboard.AresCommandIcoming += FormScoreboardOnAresCommandIcoming;
                IsBindWithScoreboard = true;
                butBindWithScoreboard.Text = "Mit scoreboard trennen";
                
            }
        }

        private void FormScoreboardOnAresCommandIcoming(object sender, AresCommand aresCommand)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (FormAnzeige.ShowDisziplin)
            {
                FormAnzeige.ShowDisziplin = false;
                button14.Text = "Disziplin einblenden";
            }
            else
            {
                FormAnzeige.ShowDisziplin = true;
                button14.Text = "Disziplin ausblenden";
            }
        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {
            FormAnzeige.SetRemark(txtRemark.Text);
        }

        private void butRemark_Click(object sender, EventArgs e)
        {
            if (FormAnzeige.ShowRemark)
            {
                FormAnzeige.ShowRemark = false;
                butRemark.Text = "Remark einblenden";
            }
            else
            {
                txtRemark_TextChanged(sender, e);
                FormAnzeige.ShowRemark = true;
                butRemark.Text = "Remark ausblenden";
            }
        }

 
    }
}
