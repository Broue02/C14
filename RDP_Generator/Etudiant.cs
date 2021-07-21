using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_Generator
{
    class Etudiant
    {
        public string etuDa;
        public string etuCourriel;
        public string etuOrdi;

        public Etudiant(string da, string courriel, string ordi)
        {
            etuDa = da;
            etuCourriel = courriel;
            etuOrdi = ordi;
        }
    }
}
