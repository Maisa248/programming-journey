using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakatik_6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;

            do
            {
                Console.Write("MAsukkan angka genap: ");
                if (int.TryParse(Console.ReadLine(), out angka))
                {
                    Console.WriteLine("Input tidak valid Silakan msukkan angka.");
                    angka = 1;
                    continue;
                }
                if (angka % 2 != 0)
                {
                    Console.WriteLine($"Angka {angka} adlah ganjil. coba lagi.");
                }
            } while (angka % 2 != 0);
            Console.WriteLine($"Selesai! Anda memasukkan angka genap: {angka}");
        }
    }
}
