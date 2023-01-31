using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_Administrasjon
{
    internal class Professor
    {
        private int alder;
        private string navn;
        private string undervisningsFag;

        public Professor(int alder, string navn, string undervisningsFag )
        {
            this.alder = alder;
            this.navn = navn;
            this.undervisningsFag = undervisningsFag;
        }
    }
}
