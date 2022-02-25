using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] agent = { "Reyna", "Yoru", "Omen", "Jett" };


            //Length
            Console.WriteLine("===== Length =====");
            Console.WriteLine("Jumlah Kalimat Pertama " + agent[0].Length);
            Console.WriteLine("Jumlah Kalimat Kedua " + agent[1].Length);
            Console.WriteLine("Jumlah Kalimat Ketiga " + agent[2].Length);
            Console.WriteLine("Jumlah Kalimat Keempat " + agent[3].Length);
            Console.WriteLine(" ");


            //Indexof
            Console.WriteLine("===== Index Off =====");
            Console.WriteLine("Huruf e ada pada index " + agent[0].IndexOf("e"));
            Console.WriteLine("Huruf o ada pada index " + agent[1].IndexOf("o"));
            Console.WriteLine("Huruf e ada pada index " + agent[2].IndexOf("e"));
            Console.WriteLine("Huruf J ada pada index " + agent[3].IndexOf("J"));
            Console.WriteLine(" ");


            //Insert
            Console.WriteLine("===== Insert =====");
            Console.WriteLine("Memasukan huruf e pada baris pertama  " + agent[0].Insert(0, "e"));
            Console.WriteLine("Memasukan huruf e pada baris pertama  " + agent[1].Insert(0, "e"));
            Console.WriteLine("Memasukan huruf e pada baris pertama  " + agent[2].Insert(0, "e"));
            Console.WriteLine("Memasukan huruf e pada baris pertama  " + agent[3].Insert(0, "e"));
            Console.WriteLine(" ");

            //Remove
            Console.WriteLine("===== Remove =====");
            Console.WriteLine("Menghapus huruf " + agent[0].Remove(0, 1));
            Console.WriteLine("Menghapus huruf " + agent[1].Remove(0, 1));
            Console.WriteLine("Menghapus huruf " + agent[2].Remove(0, 1));
            Console.WriteLine("Menghapus huruf " + agent[3].Remove(0, 1));
            Console.WriteLine(" ");

            //Replace
            Console.WriteLine("===== Replace =====");
            Console.WriteLine("Mengganti huruf R " + agent[0].Replace("R", "L"));
            Console.WriteLine("Mengganti huruf Y " + agent[1].Replace("Y", "L"));
            Console.WriteLine("Mengganti huruf O " + agent[2].Replace("O", "L"));
            Console.WriteLine("Mengganti huruf J " + agent[3].Replace("J", "L"));
            Console.WriteLine(" ");

            //SubString
            Console.WriteLine("===== SubString =====");
            Console.WriteLine("SubString " + agent[0].Substring(0, 5));
            Console.WriteLine("SubString " + agent[1].Substring(0, 4));
            Console.WriteLine("SubString " + agent[2].Substring(1, 2));
            Console.WriteLine("SubString " + agent[3].Substring(0, 1));
            Console.WriteLine(" ");


            //Join
            Console.WriteLine("===== Join =====");
            Console.WriteLine("Menggabungkan Nama " + string.Join(" & ", agent[0], agent[2]));
            Console.WriteLine("Menggabungkan Nama " + string.Join(" & ", agent[1], agent[2]));
            Console.WriteLine("Menggabungkan Nama " + string.Join(" & ", agent[2], agent[3]));
            Console.WriteLine("Menggabungkan Nama " + string.Join(" & ", agent[0], agent[3]));
            Console.WriteLine(" ");


            //Concatenate
            Console.WriteLine("===== Concatenate =====");
            Console.WriteLine(string.Concat(agent[0] + agent[2]));
            Console.WriteLine(string.Concat(agent[1] + agent[2]));
            Console.WriteLine(string.Concat(agent[2] + agent[3]));
            Console.WriteLine(string.Concat(agent[3] + agent[1]));


        }
    }
}
