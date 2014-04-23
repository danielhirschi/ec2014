using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SCEG.ScoreboardPc.Business;

namespace SCEG.ScoreboardPc.Data
{
    abstract class AresCommand
    {
        private readonly List<byte> fullAresCommand;

        protected AresCommand(List<byte> fullAresCommand)
        {
            this.fullAresCommand = fullAresCommand;
        }

        public string FullResCommandInHex
        {
            get
            {
                return HelperMethods.ByteArrayToFormatedString(fullAresCommand);
            }
        }

    }
}
