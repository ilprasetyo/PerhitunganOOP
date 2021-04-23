using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class Perkalian: Abstract
    {
        public Perkalian(int a, int b)
        {
            A = a;
            B = b;
        }

        public int A { get; private set; }
        public int B { get; private set; }

        public override int Proccess()
        {
            return A * B;
        }
    }
}
