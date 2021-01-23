using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
     class Ogrenci
    {


        Dictionary<int, string> Student = new Dictionary<int, string>();
      

        public void Add(int numara,string adsoyad)
        {
            Student.Add(numara, adsoyad);

        }

        public void List()
        {

            foreach (var item in Student)
            {

                Console.WriteLine(item.Key + " " + item.Value);
            }

        }
        
    }
}

