using System;
using System.Collections.Generic;
using System.Text;

namespace Rumah_Sakit
{
    class user
    {
        public String Nama;
        public int NomorID;
        private double NomorHP;
        protected String Riwayat;
        internal String Bangsal;


        public double getNomorHP()
        {
            return NomorHP;
        }

        public double setNomorHPDok()
        {
            NomorHP = 08138334325;
            return NomorHP;
        }

        public double setNomorHPPas()
        {
            NomorHP = 085325493259;
            return NomorHP;
        }

        internal String bangsal; public String getBangsal()
        {
            return Bangsal;
        }
    }

}