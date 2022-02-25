using System;
using System.Collections.Generic;

//create directory
Directory.CreateDirectory(@"D:\\Tugas IO");

//creat file
/*File.Create(@"D:\Tugas IO\deret_angka.txt");
File.Create(@"D:\Tugas IO\puisi.txt");*/


//eror handling using try and catch
try
{
    //write to file
    StreamWriter da = new StreamWriter(@"D:\\Tugas IO\deret_angka.txt");
    {
        for(int i = 32; i >= 0; i /= 2)
        {
            if (i == 1) continue;
            da.WriteLine(i);
            if (i == 0) break;
        }
        da.Close(); 
    }
}

catch (Exception ex)
{ Console.WriteLine(ex.Message); }

//eror handling using try and catch
try
{
    //write to file
    StreamWriter pu = new StreamWriter(@"D:\\Tugas IO\puisi.txt");
    pu.Write("Sunyi\nby Rafli\n\nDimalam itu burung hantu berbunyi\nMenemani rasa sepi ku\nBurung itu kemudian diam\nLalu terbang entah kemana\nDiriku pun merasa sunyi.");
    pu.Close();
}

catch(Exception ex)
{ Console.WriteLine(ex.Message); }