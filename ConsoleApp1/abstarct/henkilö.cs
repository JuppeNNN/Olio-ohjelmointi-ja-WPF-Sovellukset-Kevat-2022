using System;
using System.Collections.Generic;
using System.Text;

namespace abstarct
{
    abstract class henkilö
    {
        public abstract string Nimi { get; set;}
        public abstract void puhu();

        public static int instanssit = 0;

        public henkilö()
        {
            instanssit++;
        }
        public static void kuinkamonta()
        {
            Console.WriteLine("henkilöitä elossa: " + instanssit);
        }
    }
}
