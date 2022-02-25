using System;

namespace calculator
{
    public class kalkulator
    {
        public int penjumlahan()
        {
            Console.WriteLine("Masukan Angka 1 = ");
            int x = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Masukan Angka 2 = ");
            int y = int.Parse(Console.ReadLine());

            int jumlah = x + y;
            Console.WriteLine("Hasil = " + jumlah);
            return jumlah;
        }

        public int pengurangan()
        {
            Console.WriteLine("Masukan Angka 1 = ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukan Angka 2 = ");
            int y = int.Parse(Console.ReadLine());

            int jumlah = x - y;
            Console.WriteLine("Hasil = " + jumlah);
            return jumlah;
        }

        public int perkalian()
        {
            Console.WriteLine("Masukan Angka 1 = ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukan Angka 2 = ");
            int y = int.Parse(Console.ReadLine());

            int jumlah = x * y;
            Console.WriteLine("Hasil = " + jumlah);
            return jumlah;
        }

        public int pembagian()
        {
            Console.WriteLine("Masukan Angka 1 = ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukan Angka 2 = ");
            int y = int.Parse(Console.ReadLine());

            int jumlah = x / y;
            Console.WriteLine("Hasil = " + jumlah);
            return jumlah;
        }

    }
}
