using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Void Metotlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //}

            //void Sum()
            //{
            //    int x = 6;
            //    int y=7;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region geriye değer döndürmeyen parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            #endregion

            #region geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int n1,int n2,int n3)
            //{
            //    int result=n1 + n2+n3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);
            #endregion

            #region geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "buse yıldız";
            //}
            //CustomerName();

            //string StudentKart()
            //{
            //    Console.Write("Adınız: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Soyadınız:");
            //    string surname = Console.ReadLine();
            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentKart());

            #endregion

            #region geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName, string capital)
            //{
            //    string cardInfo = "Ülke:" + countryName + "- Başkent";
            //    return cardInfo;
            //}
            //string x, y;

            //Console.WriteLine("Ülke adı giriniz:");
            //x= Console.ReadLine();
            //Console.WriteLine("Ülke başkentini giriniz:");
            //y = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y));

            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //string ExamResult(string student, int exam1, int exam2)
            //{
            //    int result = (exam1 + exam2) / 2;
            //    if (result >= 50) 
            //    {
            //        return student + " isimli öğrenci sınavı geçti";
            //    }
            //    else 
            //    {
            //        return student + " isimli öğrenci başarısız oldu";
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali", 24,95));
            #endregion



            Console.Read();

        }
    }
}