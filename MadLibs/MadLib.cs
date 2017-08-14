using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class MadLib
    {
        public string[][] madLib { get; set; }
        public string title { get; set; }

        public MadLib(string[][] mL, string t)
        {
            mL = madLib;
            t = title;
        }
    }
}
