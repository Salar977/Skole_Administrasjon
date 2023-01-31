using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_Administrasjon
{
    internal class Skole
    {
        private string skoleNavn;
        private string city;
        private string country;
        private int byggeÅr;

        private string navn;
        private string alder;
        private int startÅr;

        public Skole(string skoleNavn, string city, string country, int byggeår)
        {
            this.skoleNavn = skoleNavn;
            this.city = city;
            this.country = country;
            this.byggeÅr = byggeår;
        }
    }
}
