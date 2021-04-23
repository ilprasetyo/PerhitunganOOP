using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pertambahan
            Pertambahan tambah = new Pertambahan(8, 2);
            Console.WriteLine("Ini Pertambahan " + tambah.A+" + "+tambah.B+ ": ");
            Console.WriteLine(tambah.Proccess());
            tambah.Display();
            //Perkurangan
            Console.WriteLine("");
            Perkurangan kurang = new Perkurangan(8, 2);
            Console.WriteLine("Ini Perkurangan " + kurang.A + " - " + kurang.B + ": ");
            Console.WriteLine(kurang.Proccess());
            kurang.Display();
            //Perkalian
            Console.WriteLine("");
            Perkalian kali = new Perkalian(8, 2);
            Console.WriteLine("Ini Perkalian " + kali.A + " x " + kali.B + ": ");
            Console.WriteLine(kali.Proccess());
            kali.Display();
            //Pembagian
            Console.WriteLine("");
            Pembagian bagi = new Pembagian(8, 2);
            Console.WriteLine("Ini Pembagian " + bagi.A + " / " + bagi.B + ": ");
            Console.WriteLine(bagi.Proccess());
            bagi.Display();
            Console.Read();
        }
    }
}
