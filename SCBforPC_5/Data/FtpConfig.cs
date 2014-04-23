using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SCEG.ScoreboardPc.Data
{
    public class FtpConfig
    {
        public const string FileName = "Config.txt";

        public string FTPServer { get; set; }
        public string FTPPath { get; set; }
        public string FTPFile { get; set; }
        public string FTPUser { get; set; }
        public string FTPPassword { get; set; }

    }
}
