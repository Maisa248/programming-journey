using System;

namespace Tugas_tiga_bilangan_perkalian
{
    internal class Program
    {
        
       
            // Fungsi Kali menerima tiga bilangan dan menampilkan hasil perkalian
            static void Kali(int a, int b, int c)
            {
                int hasil = a * b * c;
                Console.WriteLine("Hasil perkalian: " + hasil);
            }

            static void Main(string[] args)
            {
                Console.Write("Masukkan bilangan pertama: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Masukkan bilangan kedua: ");
                int y = int.Parse(Console.ReadLine());
                Console.Write("Masukkan bilangan ketiga: ");
                int z = int.Parse(Console.ReadLine());

                Kali(x, y, z); // Panggil fungsi
            }
        
    }
}
