using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci Student = new Ogrenci();

            Student.Add(244,"Faruk");
            Student.Add(234, "Ahmet");
            Student.Add(13, "Ayşe");

         

            Student.List();
        }

         
    }
}
