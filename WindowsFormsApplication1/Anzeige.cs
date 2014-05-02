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
        #region Properties
       
        public bool ShowLogo
        {
            get { return pictureBox1.Visible; }
            set { pictureBox1.Visible = value; }
        }
        public bool ShowUhr
        {
            get { return panel_uhr.Visible; }
            set { panel_uhr.Visible = value; }
        }
        public bool ShowZeit 
        { 
            get { return panelzeit.Visible; } 
            set { panelzeit.Visible = value; } 
        }

        public bool IsShowSponsoren()
        {
            return timersponsoren.Enabled;
        }

        public bool ShowStatus
        {
            get { return panel_status.Visible; }
            set { panel_status.Visible = value; }
        }

        public bool ShowDisziplin
        {
            get { return panel_disziplin.Visible; }
            set { panel_disziplin.Visible = value; }
        }

        public bool ShowRemark
        {
            get { return lblRemark.Visible; }
            set { lblRemark.Visible = value; }
        }

        public TimeSpan ZwischenZeitAnzeigedauer { get; set; }
        public DateTime LetzteZwischenzeitGezeigt { get; private set; }
        public int AnzahlBahnen { get; set; }

        #endregion

        public Anzeige()
        {
            InitializeComponent();
            AnzahlBahnen = 8;
            ZwischenZeitAnzeigedauer = new TimeSpan(0,0,0,10); 
            timerzwischenzeit.Start();
        }





        //Sponsoren
        string[] images;
        int imagesn;
        int imagesmax;
        public void ShowSponsoren(bool show, int interval)
        {
            if (show)
            {
                imagesn = 0;
                images = Directory.GetFiles(@".\Sponsoren", "*.png");
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

        //Uhr
        public void SetUhr(string zeit)
        {
            lbl_uhr.Text = zeit;
        }

        //zeit
        public void SetZeit(string zeit)
        {
            lbl_Zeit.Text = zeit;
        }

        //Status

        public void SetRennen(string rennen)
        {
            lbl_rennen.Text = rennen;
        }
        public void SetLauf(string lauf)
        {
            lbl_lauf.Text = lauf;
        }
        public void SetDisziplin(string disziplin)
        {
            label_disziplin.Text = disziplin;
        }
        public void SetRemark(string remark)
        {
            lblRemark.Text = remark;
        }

        //Zwischenzeit
        
        public void SetZwischenzeitsetzen(string zwischenzeit,int rang)
        {
            if (rang > AnzahlBahnen || rang < 0) return;

            LetzteZwischenzeitGezeigt = DateTime.Now;
            Label lbl = (Label)Controls["panel_rang" + rang].Controls["lbl_rang" + rang];
            lbl.Text = zwischenzeit;
            Panel pan = (Panel)Controls["panel_rang" + rang];
            pan.Visible = true;
        }

        public void DeleteZwischenzeit(int rang)
        {
            if (rang > AnzahlBahnen || rang < 0) return;

            Panel pan = (Panel)Controls["panel_rang" + rang];
            pan.Visible = false;
        }

        private void timerzwischenzeit_Tick(object sender, EventArgs e)
        {
            if (LetzteZwischenzeitGezeigt + ZwischenZeitAnzeigedauer < DateTime.Now)
            {
                for (int i = 1; i <= AnzahlBahnen; i++)
                {
                    DeleteZwischenzeit(i);
                }
            }
        }
    }
}
