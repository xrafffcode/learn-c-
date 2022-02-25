using System;
using System.Collections;

ArrayList arr = new ArrayList();

arr.Add("jeruk");
arr.Add("melon");
arr.Add("cherry");
arr.Add(200);
arr.Add(100);

Console.WriteLine(arr.Capacity);

arr.Insert(0, "salak");
// arr.Remove("jeruk");
// arr.RemoveRange(0, 4);
// arr.Clear();


//Contains
// if (arr.Contains("melon"))
//    Console.WriteLine("Melon Tersedia");
// else
//    Console.WriteLine("Melon kosong");


// bikin input output data apa yang ingin dicari

Console.Write("Mau cari data apa: ");

string cari = Console.ReadLine();

if (arr.Contains(cari))
        Console.WriteLine(cari + " " + "Tersedia");
     else
        Console.WriteLine( cari + " " + "kosong");


//menampilkan dara arrayList
//perulangan foreach 

foreach (object i in arr)
    Console.WriteLine(i);