using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testnaAplikacija
{
    public class TIm
    {
        public string OznakaTima { get; set; }
        public string NazivProjekta { get; set; }
        public int IdTima { get; set; }

        public override string ToString()
        {
            return OznakaTima + " " + NazivProjekta;
        }

    }
}
