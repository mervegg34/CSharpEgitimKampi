using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
            //colors[0] = "Kırmızı";
            //colors[1] = "Beyaz";
            //colors[2] = "Sarı";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);

            ///////////////////////////////////

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[3]);

            ///////////////////////////////////

            //string[] cities = { "Prag", "İstanbul", "Atina", "Bursa", "Roma" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Kırmızı", "Sarı", "Turuncu", "Yeşil", "Mavi", "Pembe", "Beyaz", "Siyah" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]); 
            //}

            ///////////////////////////////////

            //int [] numbers = { 125, 785, 6849, 235, 41525, 64, 72, 936 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            ///////////////////////////////////

            //int[] myArray = { 75, 29, 289, 2654, 3654, 45, 96944, 7848956, 25, 1 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //} Console.WriteLine(maxNumber);

            ///////////////////////////////////

            //int[] numbers = { 78, 52, 46, 23, 956, 100, 789 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            ///////////////////////////////////

            //int[] numbers = { 78, 52, 46, 23, 956, 100, 789 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ali", "enes", "merve", "sena", "ayşe" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            ////////////////////////////

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //Console.WriteLine("En Büyük Sayı: " +numbers.Max()+ "  En Küçük Sayı: " +numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //////////////////////////////////////////

            //int[] numbers = { 10, 20, 30, 50, 60 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //////////////////////////////////////////

            //int[] numbers = { 17, 85, 64, 325, 423, 672, 96 };

            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();

            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

        }
    }
}
