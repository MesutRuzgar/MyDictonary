using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> Ogrenci = new MyDictonary<int, string>();
            Ogrenci.Add(1, "Okan");
            Ogrenci.Add(2, "Mesut");
            Ogrenci.Add(3, "Furkan");
            Ogrenci.Add(4, "Umut");
            Ogrenci.Add(5, "Mehmet");
       
        }


    }
}

