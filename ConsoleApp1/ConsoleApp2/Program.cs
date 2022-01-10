using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            kiuas harvia = new kiuas("Harvia", 90, 50);

            harvia.näytätiedot();
            harvia.tila = true;
            harvia.näytätiedot();
            harvia.Säädälämpötila(100);
            harvia.näytätiedot();
        }
    }
}
