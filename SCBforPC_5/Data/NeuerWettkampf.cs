using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCEG.ScoreboardPc.Data
{
    public class NeuerWettkampf : AresCommand
    {
        private const byte NeuerWettkampferkkenungsByte = 0x53;

        public NeuerWettkampf(List<byte> command)
            : base(command)
        {
            
        }

        public override string ToString()
        {
            return "ARES NeuerWettkampf";
        }

        public static bool IsValid(List<byte> command)
        {
            return command.Count > 16 &&
                   command[2] == NeuerWettkampferkkenungsByte &&
                   command[10] == 0xA0 && 
                   command[11] == 0xA0 && 
                   command[12] == 0xA0 && 
                   command[13] == 0xA0 && 
                   command[14] == 0xA0 && 
                   command[15] == 0xA0 && 
                   command[16] == 0xA0;

        }

    }
}
