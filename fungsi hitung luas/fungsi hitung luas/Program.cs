using System;
namespace hitung_luas
{
    internal class Program
    {
        static double Hitungluas(double panjang, double lebar)
        {
            double luas = panjang + lebar;
            return luas;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan panjang: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar: ");
            double l = Convert.ToDouble(Console.ReadLine());

            double hasil = Hitungluas(p, l);
            Console.WriteLine("Luas persegi panjang adalah: " + hasil);
        }
    }

}
