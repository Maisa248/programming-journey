using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_while_jumlah_total_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menampilkan jumlah total dari bilangan 1 sampai 5.");

            int total = 0;
            int penambah = 1;

            Console.WriteLine("Nilai awal = " + total);

            while(total < 15)
            {
                Console.WriteLine("Nilai ditambah dengan " + penambah);
                total = total + penambah;
                penambah++;
                Console.WriteLine("Nilai saat ini = " + total +"\n");
            }

          
        }
    }
}
