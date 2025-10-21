using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabel untuk menyimpan hasil penjumlahan
            int total = 0;

            Console.WriteLine("Menghitung jumlah angka dari 1 ssampai 5: ");

            // Perulangan for dari 1 hingga 5
            for (int i = 1; i <= 5; i++)
            {
             // Tambahkan nilai i saat ini ke variabel total
             total = total + i; // bisa juga gitulis sabagai: total +=1;

             // Tambahkan proses penjumlahan di setiap langakh
             Console.WriteLine("Menambahkan " + i + ", total sementara: " + total);
            }

            // Tampilkan hasil akhir setelah perulahan selsesai
            Console.WriteLine("\nHAsil akhir penjumlahan adalah: " + total);
        }
    }
}
