using System;
using System.Collections;
using System.Collections.Generic;

/*Hashtable makanan = new Hashtable()
{
    {"buah", "jeruk, melon, salak" },
    {"sayuran", "kangkung, sawi, terong" }
};

makanan["buah"] = "sawo, durian";
Console.WriteLine(makanan["buah"]);

foreach (DictionaryEntry de in makanan)
    Console.WriteLine("{0} : {1}", de.Key, de.Value);

*/

/*LinkedList<object> ls = new LinkedList<object>();

ls.AddFirst("jeruk");
ls.AddLast("melon");

LinkedListNode<object> node = ls.Find("jeruk");
ls.AddAfter(node, "pisang");

node = ls.Find("jeruk");
ls.AddBefore(node, "durian")*/


Hashtable kota = new Hashtable()
{
    {"UK", "London, Manster, birgiram" },
    {"USA", "Chigago, new york, washinfton" },
    {"India", "Mubai, new delhi, pune" }
};

kota["UK"] = "Liverpool, Bristol";
kota["USA"] = "Los angles, boston";
Console.WriteLine(kota["UK"]);    