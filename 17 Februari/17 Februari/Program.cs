using System.Threading;

/*LoopOne();
LoopTwo();*/

Thread thr1 = new Thread(LoopOne);
Thread thr2 = new Thread(LoopTwo);
Thread thr3 = new Thread(LoopThree);

thr1.Start();
thr2.Start();
thr3.Start();


static void LoopOne()
{
    for (int i = 0; i <= 50; i++)
    {
        Console.WriteLine("Perulangan 1 ke" + "" + i);
        if (i == 25)
        {
            Console.WriteLine("tunggu Ya");
            Thread.Sleep(5000);
            
        }
    }
}

static void LoopTwo()
{
    for (int i = 0; i <= 50; i++)
    {
        Console.WriteLine("Perulangan 2 ke" + "" + i);
        if (i == 25)
        {
            Console.WriteLine("tunggu Ya");
            Thread.Sleep(5000);
           
        }
    }
}

static void LoopThree()
{
    for (int i = 0; i <= 50; i++)
    {
        Console.WriteLine("Perulangan 3 ke" + "" + i);
        if (i == 25)
        {
            Console.WriteLine("tunggu Ya");
            Thread.Sleep(5000);
            
        }
    }
}

