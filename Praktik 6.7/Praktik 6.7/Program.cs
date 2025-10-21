using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_6._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pilihan;

            do
            {
                Console.WriteLine("\n=== Menu Aplikasi ===");
                Console.WriteLine("1. Lihat Data");
                Console.WriteLine("2. Tambah Data");
                Console.WriteLine("3. Keluar");
                Console.Write("Masukkan pilihan anda (1-3): ");

                if (int.TryParse(Console.ReadLine(), out pilihan))
                   {
                    Console.WriteLine("Pilihan tidak valid. Harap masukkan angka 1, 2, atau 3. ");
                    pilihan = 0;
                    continue;
                   }

                    switch (pilihan)
                   {
                      case 1:
                             Console.WriteLine("Anda memilih : Lihat Data.");
                     case 2:
                             Console.WriteLine("Anda memilih : Tembah Data.");
                     break;
                     case 3:
                            Console.WriteLine("Program Akan berhenti...");
                 break;
                 default:
                 Console.WriteLine("Pilihan di luar jangkauan. harap masukkan 1, 2, atau 3.");
                 break;
                }
            }while(pilihan != 3);
            Console.WriteLine("Terima kasih telah menggunakan Aplikasi.");
        }
    }
}
