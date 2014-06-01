using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCEG.ScoreboardPc.Data
{
    public class RennenUndLauf : AresCommand
    {
        private const byte RennenUndLaufErkennungsByte = 0x06;

        public int RennenNr { get; set; }
        public int LaufNr { get; set; }


        public RennenUndLauf()
            : base(new List<byte>())
        {
            
        }

        public RennenUndLauf(List<byte> command)
            : base(command)
        {
            RennenNr = (((command[21] & 0x0F) * 10) + (command[22] & 0x0F)); // Rennen Nr
            LaufNr = (((command[24] & 0x0F) * 10) + (command[25] & 0x0F)); // Lauf Nr
        }

        public override string ToString()
        {
            return String.Format("ARES RennenUndLauf, RennenNr:{0} LaufNr:{1}", RennenNr, LaufNr);
        }

        public static bool IsValid(List<byte> command)
        {
            return command.Count > 25 &&
                   command[1] == RennenUndLaufErkennungsByte;
        }
    }
}
