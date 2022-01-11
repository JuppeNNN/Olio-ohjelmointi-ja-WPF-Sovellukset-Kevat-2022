using System;

namespace abstarct
{
    class Program
    {
        static void Main(string[] args)

        {
            henkilö henkilö = new opiskelia();
            opiskelia opiskelia = new opiskelia();
            opiskelia.Nimi = "GUSNEE";
            opiskelia.puhu();
            henkilö.kuinkamonta();
        }
    }
}
