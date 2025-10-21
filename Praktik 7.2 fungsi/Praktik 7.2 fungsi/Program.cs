using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_7._2_fungsi
{
    internal class Program
    {
        static void Sapanama(string nama)
        {
            Console.WriteLine("Halo, " + nama + "!");
            Console.WriteLine("Semangat belajar C# hari ini:");
        }
        static void Main(string[] args)
        {
            Console.Write("MAsukkan nama anda: ");
            string namaSiswa = Console.ReadLine();
            Sapanama(namaSiswa); // Memanggil fungsi dengan argumen
        }
    }
}
