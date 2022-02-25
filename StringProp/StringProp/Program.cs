using System;

namespace StringProp
{
    class Program
    {
        static void Main(string[] args)
        {
            String nama = "firdausramadhan";
            String nama_belakang = "Alfarizqi";

            Console.WriteLine(nama.Insert(7, " "));

            Console.WriteLine(nama.IndexOf("a"));

            Console.WriteLine(nama.Insert(2, "a"));

            Console.WriteLine(nama.Replace("P", "0"));

            Console.WriteLine(nama.Remove(1, 2));

            Console.WriteLine(nama.Substring(1, 3));

            Console.WriteLine(String.Concat(nama + nama_belakang));

            Console.WriteLine(String.Join("  ", nama, nama_belakang));
           
        }
    }
}
