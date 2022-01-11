using System;

namespace perintä
{
    class Program
    {
        static void Main(string[] args)
        {
            henkilö henkilö = new henkilö("Matti", 20, 699999);
            opiskelia opiskelia = new opiskelia("Peksi",18,696969, 12345, "careeria");

            henkilö.tulostatiedot();
            opiskelia.tulostatiedot();

            


        }
    }
}
