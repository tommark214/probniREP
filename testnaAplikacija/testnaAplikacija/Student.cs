using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testnaAplikacija
{
    public class Student
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string pripadajuciTim { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime + " " + pripadajuciTim;
        }
    }
}
