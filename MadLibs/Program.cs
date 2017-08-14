using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] mLContainer = new string[3][];
            mLContainer[0][0] = "Everyone was lined up at the ";
            mLContainer[1][0] = "VERB ENDING IN 'ING'";
            mLContainer[0][1] = " line. The faces of the ";
            mLContainer[1][1] = "PLURAL NOUN";
            mLContainer[0][2] = " were tense and expectant. Suddenly, the ";
            MadLib mL = new MadLib(mLContainer, "The Race");
        }
    }
}
