using System;
using System.Collections.Generic;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> kelimeler = new MyDictionary<string,string>();
            kelimeler.Add("A", "Apple");
            kelimeler.Add("B", "Banana");
            kelimeler.Add("P","Pineapple");
            
            Console.WriteLine(kelimeler.Lengt);
            Console.WriteLine(kelimeler.Lengt2);
            
            
           
        }
    }
}
