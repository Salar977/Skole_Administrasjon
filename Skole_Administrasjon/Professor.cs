using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_Administrasjon
{
    internal class Professor
    {
        
        public int Alder { get; set; }
        public string Navn { get; set; }
        public string UndervisningsFag { get; set; }

        public Professor(int alder, string navn, string undervisningsFag )
        {
            this.Alder = alder;
            this.Navn = navn;
            this.UndervisningsFag = undervisningsFag;
        }
    }
}
