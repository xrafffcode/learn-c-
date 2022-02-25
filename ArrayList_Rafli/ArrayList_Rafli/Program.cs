/*TUGAS POKOK +85
1. Tuliskan proses input output untuk menambahkan data arraylist, jika “yes” maka terus melakukan penambahan data, jika “No” maka berhenti melakukan penambahan data
2. Tampilkan semua data arraylist

BONUS +20
3. Tuliskan proses input output melakukan proses insert pada index tertentu
4. Tuliskan proses input output melakukan proses pencarian menggunakan Contains
5. Tuliskan proses input output melakukan 
    a. Remove berdasarkan item
    b. Remove berdasarkan urutan index
    c. Remove beberapa item (removeRange)

TUGAS + 15
6.Menggunakan Menu*/

using System;
using System.Collections;

menu:
Console.WriteLine("1. Menambah Data");
Console.WriteLine("2. Menyisipkan Data");
Console.WriteLine("3. Mencari data");
Console.WriteLine("4. Melihat data");
Console.WriteLine("5. Remove Item");
Console.WriteLine("6. Remove Range");

Console.WriteLine("Pilih Pilihan : ");
int choose;
choose = int.Parse(Console.ReadLine());

ArrayList Array = new ArrayList();
Array.Add("Adam");
Array.Add("Raka");
Array.Add("Rafli");

switch (choose)
{
    case 1:
        Console.WriteLine("Masukkan Data");
        string data;
        data = Console.ReadLine();
        Array.Add(data);
        foreach (string input in Array)
        Console.WriteLine(input);
        Console.WriteLine("Apakah Anda Ingin Melakukan Aksi Lagi ? (Y/N)");
        string answer;
        answer = Console.ReadLine();
        if (answer == "Y" || answer == "y")
            goto menu;
        else
            break;

    case 2:
        Console.WriteLine("Masukkan Urutan dan Nama Data");
        int index;
        index = int.Parse(Console.ReadLine());
        string inputname;
        inputname = Console.ReadLine();
        Array.Insert(index, inputname);
        foreach (string rel in Array)
        Console.WriteLine(rel); ;
        Console.WriteLine("Apakah Anda Ingin Melakukan Aksi Lagi? (Y/N)");
        string answer2;
        answer2 = Console.ReadLine();
        if (answer2 == "Y" || answer2 == "y")
            goto menu;
        else
            break;

    case 3:
        Console.WriteLine("Cari Nama Data");
        string namedata;
        namedata = Console.ReadLine();

        if (Array.Contains(namedata))
            Console.WriteLine( namedata + " " + "Ditemukan");
        else
        {
            Console.WriteLine("Maaf" + " " + namedata + " " + "Tidak Ditemukan");
        }
        Console.WriteLine("Apakah Anda Ingin Melakukan Aksi Lagi ? (Y/N)");
        string answer3;
        answer3 = Console.ReadLine();
        if (answer3 == "Y" || answer3 == "y")
            goto menu;
        else
            break;

    case 4:
        foreach (var item in Array)
        {
            Console.WriteLine(item.ToString()); // Assumes a console application
        }
        Console.WriteLine("Apakah Anda Ingin Melakukan Aksi Lagi ? (Y/N)");
        string answer4;
        answer4 = Console.ReadLine();
        if (answer4 == "Y" || answer4 == "y")
            goto menu;
        else
            break;

    case 5:
        Console.Write("Mau hapus data apa: ");

        string hapus = Console.ReadLine();
        Array.Remove(hapus);
        Console.WriteLine("Apakah Anda Ingin Melakukan Aksi Lagi ? (Y/N)");
        string answer5;
        answer5 = Console.ReadLine();
        if (answer5 == "Y" || answer5 == "y")
            goto menu;
        else
            break;

    case 6:
        Console.WriteLine("Masukkan Range");
        int range1;
        range1 = int.Parse(Console.ReadLine());
        int range2;
        range2 = Console.ReadLine();
        Array.RemoveRange(range1, range2);
        Console.WriteLine("Apakah Anda Ingin Melakukan Aksi Lagi ? (Y/N)");
        string answer6;
        answer6 = Console.ReadLine();
        if (answer6 == "Y" || answer6 == "y")
            goto menu;
        else
            break;


}