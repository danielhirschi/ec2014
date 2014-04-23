using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCEG.ScoreboardPc.Data
{
    class AktuelleZeit : AresCommand
    {
        private const byte ZeitErkennungsByte = 0xD2;

        public TimeSpan Time { get; set; }

        public AktuelleZeit(List<byte> command) : base(command)
        {
            int hh = ((command[10] & 0x0F) * 10) + (command[11] & 0x0F);         // hh
            int mm = ((command[13] & 0x0F) * 10) + (command[14] & 0x0F);         // mm
            int ss = ((command[16] & 0x0F) * 10) + (command[17] & 0x0F);         // ss
            int d = (command[19] & 0x0F) * 100;
            Time = new TimeSpan(0, hh, mm, ss, d);
        }

        public override string ToString()
        {
            return "ARES Aktuelle Zeit: " + Time.ToString();
        }

        public static bool IsValid(List<byte> command)
        {
            return command.Count > 17 && 
                command[2] == ZeitErkennungsByte;
        }
    }
}
