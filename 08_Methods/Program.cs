﻿using System;
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
            #region Void Metotlar

            //geriye değer döndürmeyen metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Merve ");
            //    Console.WriteLine("Ahmet");
            //    Console.WriteLine("Mehmet");
            //    Console.WriteLine("Enes");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Merve Gürler");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " +name+ " " +surName);
            //}
            //CustomerCard("Merve", "Gürler");
            //CustomerCard("Sena", "Gürler");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(1 ,2, 3);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string StudentCard()
            //{
            //    string name = "Merve";
            //    string surname = "Gürler";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " -Başkent: " + capital + " -Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 95));
            //Console.WriteLine(Sum(12, 56));
            //Console.WriteLine(Sum(70, 38));
            //Console.WriteLine(Sum(24, 55));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) /3;
            //    if (result >=50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti. " + " Ortalama: " + result; 
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi. " + " Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Merve", 50, 85, 14));
            //Console.WriteLine(ExamResult("Sena", 20, 73, 100));
            //Console.WriteLine(ExamResult("Enes", 63, 64, 89));

            #endregion

        }
    }
}
