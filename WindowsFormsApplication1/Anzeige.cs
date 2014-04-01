using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



namespace WindowsFormsApplication1
{
    
    public partial class Anzeige : Form
    {
        public Anzeige()
        {
            InitializeComponent();
        }





        //Logo
        public bool isshowlogo = true;
        public void ShowLogo(bool show)
        {
            this.pictureBox1.Visible = show;
            isshowlogo = show;

        }

        //Uhr
        public bool isshowuhr = true;
        public void Showuhr(bool show)
        {
            this.panel_uhr.Visible = show;
            isshowuhr = show;
        }

        public void uhraktualisieren(String zeit)
        {
            this.lbl_uhr.Text = zeit;
        }


        //Sponsoren
        string[] images;
        int imagesn;
        int imagesmax;
        public void showsponsoren(bool show, int interval)
        {
            if (show)
            {
                imagesn = 0;
                images = Directory.GetFiles(@"C:\Users\Daniel Hirschi\Documents\Visual Studio 2010\Projects\EC14Titel\Sponsoren", "*.png");
                imagesmax = images.Count();
                pictureBox_Sponsoren.Image = Image.FromFile(images[imagesn]);
                panel_sponsoren.Visible = true;
                timersponsoren.Interval = interval;
                timersponsoren.Start();
            }
            else
            {
                timersponsoren.Stop();
                panel_sponsoren.Visible = false;
            }
        }

        private void timersponsoren_Tick(object sender, EventArgs e)
        {
            
            imagesn = imagesn + 1;
            if (imagesn >= imagesmax)
            {
                panel_sponsoren.Visible = false;
                timersponsoren.Stop();
            }
            else
            {
                pictureBox_Sponsoren.Image = Image.FromFile(images[imagesn]);
            }
        }

        public bool IsShowsponsoren()
        {
            return timersponsoren.Enabled;
        }

        //zeit
        public bool isshowzeit = true;
        public void Showzeit(bool show)
        {
            panelzeit.Visible = true;
        }
        public void zeitübergeben(string zeit)
        {
            lbl_Zeit.Text = zeit;
        }

        //Status
        public bool isshowstatus = true;
        public void showstatus(bool show)
        {
            panel_status.Visible = show;
            panel_disziplin.Visible = show;
            isshowstatus = show;
        }
        public void rennen(string rennen)
        {
            lbl_rennen.Text = rennen.ToString();
        }
        public void lauf(string lauf)
        {
            lbl_lauf.Text = lauf.ToString();
        }
        public void disziplin(string disziplin)
        {
            label_disziplin.Text = disziplin.ToString();
        }

        //Zwischenzeit
        public void zwischenzeitsetzen(string zwischenzeit,int rang)
        {
            if (rang < 9)
            {
                Label lbl = (Label)this.Controls["panel_rang" + rang].Controls["lbl_rang" + rang];
                lbl.Text = zwischenzeit;
                Panel pan = (Panel)this.Controls["panel_rang" + rang];
                pan.Visible = true;
            }
            else
            {
                timerzwischenzeit.Start();
            }
            

        }

        private void timerzwischenzeit_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= 8; i++)
            {
                Panel pan = (Panel)this.Controls["panel_rang" + i];
                pan.Visible = false;
            }
            timerzwischenzeit.Stop();


        }
    }
}
