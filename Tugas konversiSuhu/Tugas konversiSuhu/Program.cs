using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_konversiSuhu
{
    internal class Program
    {
            // Fungsi untuk mengonversi suhu dari Celcius ke Fahrenheit
            static double KonversiSuhu(double celsius)
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                return fahrenheit;
            }

            static void Main(string[] args)
            {
                Console.Write("Masukkan suhu dalam Celcius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());

                double hasil = KonversiSuhu(celsius);

                Console.WriteLine("Hasil konversi: " + hasil + " °F");

                Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
                Console.ReadKey();

            }
        }
}
