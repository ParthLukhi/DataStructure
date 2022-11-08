using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_HT_DT
{
    internal class course
    {
        public course(string courseName, string score)
        {
            CourseName = courseName;
            Score = Int32.Parse(score);
        }
         
        public string CourseName { get; set; }

        public int Score { get; set; }
    }
}
