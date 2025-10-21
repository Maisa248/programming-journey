using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka = 1;

            Console.WriteLine("Menampilkan angka 1 sampai 20:");

            do
            {
                Console.WriteLine(angka);

                angka++;
            } while (angka <= 20);

            Console.WriteLine("Selesai.");
        }
    }
}
