using System;
using System.Collections;


Stack st = new Stack();
st.Push("saya");
st.Push("adalah");
st.Push("siswa");
st.Push("pintar");

st.Pop();
st.Push("keren");
st.Pop();


foreach (var item in st)
    Console.WriteLine(item+ "");