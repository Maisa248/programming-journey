using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_tigaNilai_rata_rata
{
    internal class Program
    {
        // fungsi menghitung rata-rata dari tiga nilai
        static double RataRata(double a, double b, double c)
        {
            double hasil = (a + b + c) / 3;
            return hasil; // mengembalikan nilai
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--- MENCARI RATA-RATA---");
            Console.Write("Masukkan angka1: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Masukkan angka2: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Masukkan angka3: ");
            int z = int.Parse(Console.ReadLine());

            // Panggil fungsi dan simpan hasilkan
            double hasilRata = RataRata(x, y, z);
            // Tampil hasil ke layar
            Console.WriteLine("Hasil rata-rata: " + hasilRata);
        }
    }
}
