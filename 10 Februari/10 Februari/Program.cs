using System.IO;
using System.Collections.Generic;

Directory.CreateDirectory(@"D:\\kk3");

Console.WriteLine(File.Exists(@"D:\\latihan.txt"));
File.Delete("@D:\\latihan.txt");

File.AppendAllText(@"D:\\latihan.txt", "hello pepek");


StreamWriter sw = new StreamWriter (@"D:\\latihan.txt");

sw.WriteLine("Halo imam");
sw.WriteLine("Mari Turu");
sw.WriteLine("Ava Iyah");


sw.Close ();


StreamReader sr = new StreamReader(@"D:\\latihan.txt");

String baris = sr.ReadLine();

while(baris != null)
{
    Console.WriteLine(baris);
    baris = sr.ReadLine();
}

sr.Close();  