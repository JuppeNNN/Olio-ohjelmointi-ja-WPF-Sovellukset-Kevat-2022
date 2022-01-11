using System;
using System.Collections.Generic;
using System.Text;

namespace perintä
{
    class opiskelia : henkilö
    {
        public int opiskeliaID;
        public string koulu;
        public opiskelia(string nimi, int ikä, int henkilötunnus,int  _opiskeliaID, string _koulu) : base(nimi, ikä, henkilötunnus)
        {
            opiskeliaID = _opiskeliaID;
            koulu = _koulu;
        }
        public override void tulostatiedot()
        {
            Console.WriteLine("opiskelija: " + nimi + ". ikä:" + ikä + "koulu:" + koulu + " . opiskeliaID: " + opiskeliaID);



        }
        
    }
}
