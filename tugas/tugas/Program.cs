using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" BIODATA SISWA");
            Console.WriteLine(" Nama siswa :");
            String nama = Console.ReadLine();
            Console.WriteLine(" Nama panggilan : ");
            String panggil = Console.ReadLine();
            Console.WriteLine(" Jenis Kelamain : ");
            String jk = Console.ReadLine();
            Console.WriteLine(" Agama : ");
            String gm = Console.ReadLine();
            Console.WriteLine(" usia : ");
            String usia = Console.ReadLine();
            Console.WriteLine(" Sekolah di : ");
            String sol = Console.ReadLine();
            Console.WriteLine("Jurusan : ");
            String jur = Console.ReadLine();
            Console.WriteLine(" Alamat : ");
            String al = Console.ReadLine();
            Console.WriteLine(" Hobi : ");
            String hob = Console.ReadLine();
            Console.WriteLine(" Cita-Cita :");
            String cita = Console.ReadLine();
            Console.WriteLine("**********************");
            Console.WriteLine("     BIODATA SISWA    ");
            Console.WriteLine("**********************");
            Console.WriteLine(" Nama siswa     : " + nama);
            Console.WriteLine(" Nama panggilan : " + panggil);
            Console.WriteLine(" Jenis kelamin  : " + jk);
            Console.WriteLine(" Agama          : " + al);
            Console.WriteLine(" Usia           : " + usia);
            Console.WriteLine(" Sekolah di     : " + sol);
            Console.WriteLine(" Jurusan        : " + jur);
            Console.WriteLine(" Alamat         : " + al);
            Console.WriteLine(" Hobi           : " + hob);
            Console.WriteLine(" Cita-Cit       : " + cita);
        }
    }
}
