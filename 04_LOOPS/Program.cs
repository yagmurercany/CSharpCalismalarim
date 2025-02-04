using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR DONGUSU
            //For(x;y;z)
            //x : başlangıç
            //y : bitiş
            //z : artış miktarı

            //int i;
            //for (int i; i<=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for(int i=1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i =3; i<=50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz : ");
            //int finishValue = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion

            #region FOR DONGUSU ILE KARAR YAPILARI

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i < 50; i++) {
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for (int i = 1; i <= bacterium; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + " . Saat Sonunda : " + bacterium);
            //}

            #endregion

            #region WHILE DONGUSU
            //WHİLE (ŞART)
            //{
            //İŞLEMLER
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler !");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region ORNEK SINAV SORUSU

            //SORU: KLAVYEDEN GİRİLEN 3 BASAMAKLI SAYININ BASAMAKLARI TOPLAMINI HESAPLAYAN KODU YAZINIZ?

            //456

            //Console.Write("Sayı Giriniz : ");
            //int number=int.Parse(Console.ReadLine());
            //int birler, onlar, yuzler;
            //int toplam;

            //birler = number % 10;
            //yuzler=number / 100;
            //onlar = (number % 100) / 10;
            //Console.WriteLine("Birler Basamağı : "+birler);
            //Console.WriteLine("Onlar Basamağı : "+onlar);
            //Console.WriteLine("Yüzler Basamağı : " + yuzler);

            //toplam = birler + onlar + yuzler;
            //Console.WriteLine("Basamak sayılarının toplamı : " +toplam);
            #endregion
            Console.ReadKey();
            }
        }
    }

