using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi
            string[] kurslar = new string[]
            {
                "Yazılım geliştirici yetiştirme kampı",
                "Programlamaya başlangıç için temel kurs",
                "java",
                "python"
            };
            for (int i = 0; i < kurslar.Length;i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarar
            {
                Console.WriteLine(kurs); //kurs her bi elemanı dolaşırken verdiğimiz takma isim
            }
            Console.WriteLine("sayfa sonu");
            for (int i = 1; i < 10; i++)// i+=2,i=i+2,i=i+1yadai++:şeklinde yazılabilir
            {
                Console.WriteLine(i);
            }
        }
    }
}
