using System;
using System.Collections.Generic;
using System.Text;

namespace Rumah_Sakit
{
    class Dokter : user
    {
        public void biodataDokter()
        {
            Console.WriteLine("=======Biodata Dokter=======");
            base.Nama = "Dr.Ratna";
            Console.WriteLine("Nama Dokter : " + Nama);

            base.NomorID = 0747;
            Console.WriteLine("Nomor ID : " + NomorID);

            Console.WriteLine("Nomor HP Dokter : " + setNomorHPDok());

            Console.WriteLine("Riwayat Dokter : " + RiwayatDok());

            
        }

        

        public String RiwayatDok()
        {
            base.Riwayat = "Covid 19";
            return Riwayat;
        }
    }
}