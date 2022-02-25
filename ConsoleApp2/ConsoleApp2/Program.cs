using System;
using System.Collections;

menu:
Console.WriteLine("----Daftar Pilihan----");
Console.WriteLine("1. Menambah Data Album");
Console.WriteLine("2. Mencari Data Album");
Console.WriteLine("3. Menghapus Data Album");
Console.WriteLine("4. Menyisipkan Data Album");

Console.WriteLine("----Pilih Pilihan Album----");
int pilih;
pilih = int.Parse(Console.ReadLine());

ArrayList ar = new ArrayList();
ar.Add("LOVE YOURSELF: HER");
ar.Add("LOVE YOURSELF: TEAR");
ar.Add("LOVE YOURSELF: ANSWER");

switch (pilih)
{

    case 1:
        Console.WriteLine("Tambah Data Album: ");
        string tambah;
        tambah = Console.ReadLine();
        ar.Add(tambah);
        foreach (string input in ar)
            Console.WriteLine(input);

        Console.WriteLine("Apakah Anda ingin menambah data album lagi? (y/n)");
        string y1;
        y1 = Console.ReadLine();
        if (y1 == "y")
            goto menu;
        else
            break;


    case 2:
        Console.WriteLine("Mencari Data Album: ");
        string mencari;
        mencari = Console.ReadLine();
        ar.Add(mencari);
        foreach (string Hasil in ar)
            Console.WriteLine(Hasil);

        Console.WriteLine("Kembali ke menu? (y/n)");
        string y2;
        y2 = Console.ReadLine();
        if (y2 == "y")
            goto menu;
        else
            break;


    case 3:
        Console.WriteLine("Menghapus Data Album: ");
        string hapus;
        hapus = Console.ReadLine();
        ar.Add(hapus);
        foreach (string Hasil in ar)
            Console.WriteLine(Hasil);

        Console.WriteLine("Kembali ke menu? (y/n)");
        string y3;
        y3 = Console.ReadLine();
        if (y3 == "y")
            goto menu;
        else
            break;


    case 4:
        Console.WriteLine("Menyisipkan Data Album: ");
        string sisip;
        sisip = Console.ReadLine();
        ar.Add(sisip);
        foreach (string Hasil in ar)
            Console.WriteLine(Hasil);

        Console.WriteLine("Kembali ke menu? (y/n)");
        string y4;
        y4 = Console.ReadLine();
        if (y4 == "y")
            goto menu;
        else
            break;

}