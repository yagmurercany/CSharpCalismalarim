﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DOUBLE DEGISKENLER
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("********** FİYAT LİSTESİ **********");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice+" TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine(  );
            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Alınan Ürün Elma - "+ "Birim Fiyat: "+applePrice+ " - Gramaj: " +
            //    appleGram + " - Toplam Tutar: " +appleTotalPrice);

            //Console.WriteLine("Alınan Ürün Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " +
            //   orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " +
            //   strawGram + " - Toplam Tutar: " + strawTotalPrice);

            //Console.WriteLine("Alınan Ürün Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " +
            //   potatoGram + " - Toplam Tutar: " + potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " +
            //  tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine(  );
            //Console.WriteLine("Toplam Ödenecek Tutar : " +shoppingTotalPrice+ " TL'dir.");
            #endregion

            #region CHAR DEGISKENLER
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region KLAVYEDEN VERİ GİRİSLERİ

            //Console.WriteLine("********** CSharp Hava Yolları Yolcu Bilgisi **********");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("T.C. Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.Write("Yolcu T.C. Kimlik No: "+passengerIdentityNumber+" Yolcu Ad Soyadı: " +passengerName+ " "+passengerSurname+" "+
            //    passengerDistrict+" / "+passengerCity+" "+passengerAge);
            //passengerDistrict = Console.ReadLine();
            //passengerCity = Console.ReadLine();
            //passengerAge = Console.ReadLine();
            //passengerIdentityNumber = Console.ReadLine();


            #endregion

            #region KLAVYEDEN TAM SAYI GİRİŞİ VE DÖNÜŞÜMLER

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice+computerCount*computerPrice+chairPrice*chairCount+tvPrice*tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödenecek tutar :" + totalPrice);

            #endregion

            #region KLAVYEDEN ONDALIKLI SAYI İŞLEMLERİ

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen birinci sınav notunu giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen üçüncü sınav notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());


            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız : " +result);
            #endregion

            #region KLAVYEDEN KARAKTER GİRİŞLERİ

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz : ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet :  "+gender);

            #endregion


            Console.Read();
        }
    }
}
