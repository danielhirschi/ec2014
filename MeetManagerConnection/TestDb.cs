using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeetManagerConnection
{
    public partial class TestDb : Form
    {
        private static readonly DatabaseController db = new DatabaseController();

        public TestDb()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    DatabaseController db = new DatabaseController();
        //    db.AccessFilePath = @"C:\@Server2011\SCEG\EC2014.mdb";
        //    db.GetAthleteFrom(1,1);
        //}

        private void butSetMdb_Click(object sender, EventArgs e)
        {
            db.AccessFilePath = txtMdbPath.Text;

        }

        public List<AthleteFromData> GetAthleteFrom(int wettkampfNr, int laufNr)
        {
            return db.GetAthleteFrom(wettkampfNr, laufNr);
        }




    }
}
