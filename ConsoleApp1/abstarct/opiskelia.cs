using System;
using System.Collections.Generic;
using System.Text;

namespace abstarct
{
    class opiskelia : henkilö
    {
        public override string Nimi { get; set; } 

        public override void puhu()
        {
            Console.WriteLine(Nimi + "puhuu opiskelija ");
        }
    }
}
