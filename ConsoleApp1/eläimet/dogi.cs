﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eläimet
{
    class dogi : eläin

    {
        public string rotu;
        public int ikä;

        public static int instanssit = 0;
        public dogi (string _rotu, int _ikä)
        {
            rotu = _rotu;
            ikä = _ikä;
            instanssit++;
        }
        public static new void kuinkamonta()
        {
            Console.WriteLine("koiria on elossa:" + instanssit);
        }
            

             

        public override void ääntele()
        {
            Console.WriteLine("woof woof");
        }
    }
}
