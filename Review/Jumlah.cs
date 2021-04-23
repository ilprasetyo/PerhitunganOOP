using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class Jumlah
    {
        int angka1, angka2;
        double angka3,angka4;
        public Jumlah (int a, int b)
        {
            this.angka1 = a;
            this.angka2 = b;
        }

        public Jumlah(double c, double d)
        {
            this.angka3 = c;
            this.angka4 = d;
        }

        public int Tambah()
        {
            return angka1 + angka2;
        }
        public double Tambah2()
        {
            return angka3 + angka4;
        }

    }
}
