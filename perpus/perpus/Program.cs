using System;
using calculator;

namespace perpus
{
    class Program
    {
        static void Main(string[] args)
        {
            kalkulator casio = new kalkulator();
            casio.penjumlahan();
            casio.pengurangan();
            casio.perkalian();
            casio.pembagian();
        }
    }
}
