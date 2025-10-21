using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inisisialsasi variabel untuk menyimpan input
            string inputUser = "";

            Console.WriteLine("Progam akan terus berjalan hingga anda mengtik 'keluar' .");

            // Pwrulangan selama isi variabel inputUser tidak dsms fengsn "kelusr"
            while (inputUser.ToLower() != "Keluar")
            {
                Console.Write("\nKetik Sesuatu (atau 'keluar' untuk berhenti): ");
                inputUser = Console.ReadLine(); // Baca input dari user

                Console.WriteLine("Anda mengetik: ");
            }

            Console.WriteLine("\nProgram selesai. TERIMA KASIH");
;
        }
    }
}
