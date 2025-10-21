using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Inisialisasi variabel penghitung (counter)
            int hitungan = 5;

            Console.WriteLine("Memulai hitungan mundur:");
            //2.Perulangan 'wline'
            // Kondisi: selama nilai 'hitungan' lebih besar dari 0
            while (hitungan > 0)
            {
                // Blok kode di dalam perulangan
                Console.WriteLine($"Hitungan: {hitungan}");

                //3.UPdate variabel penghitungan(decrement/perulangan)
                // ini penting agar perulangan tidak mrnjadi loop tak terbatas (infinite loop)
                hitungan = hitungan - 1;
                //atau bisa juga ditulis hitungan--;
            }
            // kode setelah perulangan selesai
            Console.WriteLine("selesai Hitungan mundur telah berakhir.");
        }
    }
}
