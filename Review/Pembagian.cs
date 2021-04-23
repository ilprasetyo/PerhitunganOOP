﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class Pembagian: Abstract
    {
        public Pembagian(int a, int b)
        {
            A = a;
            B = b;
        }

        public int A { get; private set; }
        public int B { get; private set; }

        public override int Proccess()
        {
            return A / B;
        }
    }
}
