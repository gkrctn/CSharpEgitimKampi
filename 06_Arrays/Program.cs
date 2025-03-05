using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] colors = new string[4];
            //colors[0] = "sarı";
            //colors[1] = "kırmızı";
            //colors[2] = "mavi"; 
            //colors[3] = "pembe";

            //Console.WriteLine(colors[2]);           
            //#endregion

            //string[] cities = { "prag", "roma", "istanbul", "ankara" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki tüm elemanları listele

            //string[] colors = { "mavi", "yeşil", "kırmızı", "beyaz", "pembe", "mor" };
            //for (int i = 0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //---------------------------------------------------------------------------

            //int[] numbers = { 1, 34, 54, 7, 567, 234, 8, 97, 50 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2== 0) 
            //    { 
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //--------------------------------------------------------
            //int[] myArray = { 47, 86, 92, 80, 56, 23, 45, 35 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            //--------------------------------------------------------
            //string[] persons = {"ali", "ayse","deniz","faruk","buse","cem"};
            //Console.WriteLine(persons.Length);
            //--------------------------------------------------------
            //int[] myArray = { 47, 86, 92, 80, 56, 23, 45, 35 };
            //Array.Sort(myArray);
            //for (int i = 0; i < myArray.Length; i++) {Console.WriteLine(myArray[i]);}
            //Array.Reverse(myArray);
            //for (int i = 0; i < myArray.Length; i++) { Console.WriteLine(myArray[i]); }
            #endregion

            #region Dizi Metotları
            //string[] colors = { "mavi", "yeşil", "kırmızı", "beyaz", "pembe", "mor" };
            //int index = Array.IndexOf(colors, "pembe");
            //Console.WriteLine(index);   
            //----------------------------------------------------------------------------
            //int[] myArray = { 47, 86, 92, 80, 56, 23, 45, 35 };
            //Console.WriteLine(myArray.Max()+" "+ myArray.Min());
            #endregion

            #region kullanıcıdan değer alma 
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //for (int i = 0; i < cities.Length; i++) { Console.WriteLine(cities[i]); }
            //----------------------------------------------------------
            //int[] numbers = { 13, 7, 33 ,57,68,12,43,21};
            //int sum =0;
            //for (int i = 0; i < numbers.Length; i++) {sum+= numbers[i];}    
            //Console.WriteLine(sum);
            //----------------------------------------------------------
            //int[] numbers = { 21,42,53,78,56,69,77,38,91,20 };
            //Console.WriteLine("çift sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("tek sayılar");
            //    for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion
            Console.ReadLine();

        }
    }
}