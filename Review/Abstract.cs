﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    abstract class Abstract
    {
        public void Display()
        {
            Console.WriteLine("Perhitungan Selesai");
        }

        public abstract int Proccess();
    }
}
