using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_StackQueue
{
    internal class course
    {
        public course(string couseName, string score)
        {
            CouseName = couseName;
            Score = Int32.Parse(score);
        }

        public string CouseName { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return (CouseName + "-" + Score);
        }
    }
}
