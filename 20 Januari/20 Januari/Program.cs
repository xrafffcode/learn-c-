using System;
using System.Collections;

// Hashtable

Hashtable datasiswa = new Hashtable();
datasiswa.Add("NIS", 3103120138);
datasiswa.Add("NAMA", "Muhamad Rafli Alfarizqi");
datasiswa.Add("ALAMAT", "Purwokerto");
datasiswa.Add("GOLDAR", "A+");

/*foreach (object key in datasiswa.Keys)
	Console.WriteLine(key);*/


foreach (DictionaryEntry de in datasiswa)
	Console.WriteLine("{0} : {1}", de.Key, de.Value);





//creating a Hashtable using collection-initializer syntax
/*var cities = new Hashtable(){
	{"UK", "London, Manchester, Birmingham"},
	{"USA", "Chicago, New York, Washington"},
	{"India", "Mumbai, New Delhi, Pune"}
};

foreach (DictionaryEntry de in cities)
	Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);*/


// Stack

Stack st = new Stack();

st.Push("Pilows Coklat");
st.Push("Ultra Milk");
st.Push("Beng Beng");


Console.WriteLine("Current stack: ");
foreach (string c in st)
{
    Console.WriteLine(c + " ");
}

Console.WriteLine("Jumlah Tumpukan Ada" +  " " + st.Count);


Console.WriteLine("Data Teratas Adalah" + " " + st.Peek());

Console.WriteLine("Data Teratas Yang Dihapus Adalah" + " " + st.Pop());

/*Console.WriteLine();

st.Push('P');
st.Push('Q');
Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
Console.WriteLine("Current stack: ");

foreach (char c in st)
{
    Console.Write(c + " ");
}
Console.WriteLine();

Console.WriteLine("Removing values....");
st.Pop();
st.Pop();
st.Pop();

Console.WriteLine("Current stack: ");
foreach (char c in st)
{
    Console.Write(c + " ");
}

*/

Queue q = new Queue();
q.Enqueue("Beng Beng");
q.Enqueue("Beng");

foreach (string c in q)
{
	Console.WriteLine(c + " ");
}

Console.WriteLine("Data Teratas Adalah" + " " + q.Dequeue());