using System;
using System.Collections.Generic;
using System.Text;

namespace Rumah_Sakit
{
    class pasien : user
    {
        public void biodataPasien()
        {
            Console.WriteLine("=======Biodata Pasien=======");
            base.Nama = "Muhamad Rafli Alfarizqi";
            Console.WriteLine("Nama Pasien : " + Nama);

            base.NomorID = 52273;
            Console.WriteLine("Nomor ID : " + NomorID);

            Console.WriteLine("Nomor HP Pasien : " + setNomorHPPas());

            Console.WriteLine("Riwayat Pasien : " + RiwayatPas());

            
        }

        public String RiwayatPas()
        {
            base.Riwayat = "gamon,pas move on malah di ghosting";
            return Riwayat;
        }
    }
}
