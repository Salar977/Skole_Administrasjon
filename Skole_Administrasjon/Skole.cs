using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_Administrasjon
{
    internal class Skole
    {
        public string SkoleNavn { get; set; }
        public int SkoleOppstart { get; set; }

        public Skole(String SkoleNavn, int skoleOppstart)
        {
            this.SkoleNavn  = SkoleNavn;
            this.SkoleOppstart = skoleOppstart;
        }

        public void Info()
        {
            Console.WriteLine($"Skole: {SkoleNavn}\nSkole grunnlagt: {SkoleOppstart}");
        }
    }
}
