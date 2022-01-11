using System;

namespace eläimet
{
    class Program
    {
        static void Main(string[] args)
        {
            dogi dogi1 = new dogi("mopsi", 4);

            eläin.kuinkamonta();
            dogi.kuinkamonta();
            Kissa.kuinkamonta();
            Kissa kissa1 = new Kissa("hens", 2);
            

            dogi1.ääntele();
            kissa1.ääntele();

            
        }
    }
}
