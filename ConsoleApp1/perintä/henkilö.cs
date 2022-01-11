using System;
using System.Collections.Generic;
using System.Text;

namespace perintä
{
    class henkilö
    {
        public string nimi;
        public int ikä;
        public int henkilötunnus;

        public henkilö(string nimi, int ikä, int henkilötunnus)
        {
            this.nimi = nimi;
            this.ikä = ikä;
            this.henkilötunnus = henkilötunnus;
        }

        public virtual void tulostatiedot()
        {
            Console.WriteLine("Henkilö: " + nimi + ", ikä: " + ikä + ".henkilötunnus: " + henkilötunnus);

        }
    }
}
