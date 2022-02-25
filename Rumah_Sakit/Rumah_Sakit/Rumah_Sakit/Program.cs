using System;

namespace Rumah_Sakit
{
    class Program
    {
        static void Main(string[] args)
        {
            user user = new user();
            Console.WriteLine(user.Bangsal = "Kamar = Joni");
            Console.WriteLine();
            Dokter dokter = new Dokter();
            dokter.biodataDokter();
            Console.WriteLine("");
            pasien Pasien = new pasien();
            Pasien.biodataPasien();
        }
    }
}
