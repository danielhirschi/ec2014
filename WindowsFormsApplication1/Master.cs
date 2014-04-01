using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Master : Form
    {
        //Original Logo Grösse = 1181;1207
        //Farbe Logo 0;94;157
        Anzeige FormAnzeige = new Anzeige();
        TimeSpan zeit = new TimeSpan(0);
        int rang = 1;

        public Master()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormAnzeige.isshowlogo)
            {
                FormAnzeige.ShowLogo(false);
                bu_Logo.Text = "Logo einblenden";
            }
            else
            {
                FormAnzeige.ShowLogo(true);
                bu_Logo.Text = "Logo ausblenden";
            }

        }

        private void Master_Load(object sender, EventArgs e)
        {
            FormAnzeige.Show(this);
            timeruhr.Start();
            this.lbl_zeit.Text = zeit.ToString(@"mm\:ss\.f");
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
            FormAnzeige.uhraktualisieren(this.lbl_uhr.Text);
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
            FormAnzeige.rennen(this.txt_rennen.Text);
        }

        private void txt_lauf_TextChanged(object sender, EventArgs e)
        {
            FormAnzeige.lauf(this.txt_lauf.Text);
        }

        private void but_zeit_Click(object sender, EventArgs e)
        {
            timerzeit.Start();
            if (int.Parse(textBox_statusdauer.Text) > 0)
            {
                timerstatus.Interval = int.Parse(textBox_statusdauer.Text);
                timerstatus.Start();

            }
        }

        private void timerzeit_Tick(object sender, EventArgs e)
        {
            zeit = zeit + new TimeSpan(0,0,0,0,100);
            this.lbl_zeit.Text = zeit.ToString(@"mm\:ss\.f");
        }



        // Sponsoren
        private void but_sponsoren_Click(object sender, EventArgs e)
        {
            if (FormAnzeige.IsShowsponsoren())
            {
                FormAnzeige.showsponsoren(false, int.Parse(textBox_sponor_interval.Text));
                but_sponsoren.Text = "Sponsoren Anzeigen";
            }
            else
            {
                FormAnzeige.showsponsoren(true, int.Parse(textBox_sponor_interval.Text));
                but_sponsoren.Text = "Sponsoren Stoppen";
            }
        }
        private void sponsorenbeendet()
        {
            but_sponsoren.Text = "Sponsoren Anzeigen";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TimeSpan aktuellezeit = new TimeSpan();
            aktuellezeit = zeit;
            zwischenzeit(zeit, 1);
        }

        private void zwischenzeit(TimeSpan zwischenzeit, int bahn)
        {

            Label lbl = (Label)this.groupBox1.Controls["label_r" + rang];
            lbl.Text = bahn.ToString() + "   " + zwischenzeit.ToString(@"mm\:ss\.f");
            FormAnzeige.zwischenzeitsetzen(lbl.Text, rang);
            rang = rang + 1;
            if (rang == 9)
            {
                FormAnzeige.zwischenzeitsetzen(" ", rang);
                rang = 1;
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeSpan aktuellezeit = new TimeSpan();
            aktuellezeit = zeit;
            zwischenzeit(zeit, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeSpan aktuellezeit = new TimeSpan();
            aktuellezeit = zeit;
            zwischenzeit(zeit, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimeSpan aktuellezeit = new TimeSpan();
            aktuellezeit = zeit;
            zwischenzeit(zeit, 4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TimeSpan aktuellezeit = new TimeSpan();
            aktuellezeit = zeit;
            zwischenzeit(zeit, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TimeSpan aktuellezeit = new TimeSpan();
            aktuellezeit = zeit;
            zwischenzeit(zeit, 6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TimeSpan aktuellezeit = new TimeSpan();
            aktuellezeit = zeit;
            zwischenzeit(zeit, 7);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TimeSpan aktuellezeit = new TimeSpan();
            aktuellezeit = zeit;
            zwischenzeit(zeit, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            timerzeit.Stop();
            zeit = new TimeSpan(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (FormAnzeige.isshowuhr)
            {
                FormAnzeige.Showuhr(false);
                button11.Text = "Uhr einblenden";
            }
            else
            {
                FormAnzeige.Showuhr(true);
                button11.Text = "Uhr ausblenden";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (FormAnzeige.isshowstatus)
            {
                FormAnzeige.showstatus(false);
                button12.Text = "Status einblenden";

            }
            else
            {
                FormAnzeige.showstatus(true);
                button12.Text = "Status ausblenden";
            }
            

        }

        private void lbl_zeit_TextChanged(object sender, EventArgs e)
        {
            FormAnzeige.zeitübergeben(lbl_zeit.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FormAnzeige.disziplin(textBox2.Text);
        }

        private void timerstatus_Tick(object sender, EventArgs e)
        {
            FormAnzeige.showstatus(false);
            timerstatus.Stop();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormAnzeige.showstatus(true);
            zeit = new TimeSpan(0);
            this.lbl_zeit.Text = zeit.ToString(@"mm\:ss\.f");
        }


    }
}
