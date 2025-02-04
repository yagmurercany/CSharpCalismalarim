using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE

            //Console.WriteLine("Lütfen şifreyi giriniz : ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru !");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış !");
            //}
            //------------------------------------------------------------------------------------------------------------------
            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz : ");
            //capital=Console.ReadLine();
            //Console.WriteLine("Ülkeyi giriniz : ");
            //    country=Console.ReadLine();

            //if(capital=="ankara"& country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı !!!");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi !!!");
            //}
            //-----------------------------------------------------------------------------------------------------------------------
            //int number;
            //Console.Write("Sayı Giriniz : ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru...");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı..!");
            //}
            //--------------------------------------------------------------------------------------------------------------------------

            //int exam1, exam2, exam3, average;

            //string result=" ";

            //Console.WriteLine("Sınav 1 : ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sınav 2 : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sınav 3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalamanız : " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";

            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";

            //}
            //if (average > 85 & average <= 100)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //---------------------------------------------------------------------------------------------

            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız : ");
            //city = Console.ReadLine();
            //if(city=="adana"| city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcuttur.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değildir.");
            //}

            //---------------------------------------------------------------------------------------------

            //Console.WriteLine("Lütfen kullanıcı adını giriniz : ");
            //string username=Console.ReadLine();
            //if (username != "admin")  //Bu ifade (!=) kabul edilemez anlamı taşır.
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez ! ");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz...");
            //}
            #endregion

            #region MOD İŞLEMLERİ
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayı giriniz : ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayı giriniz : ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1. Sayının 2.Sayıya bölümünden kalan : " +result);

            // Tek mi Çift mi konsol uygulaması
            //Console.Write("Lütfen sayıyı giriniz : ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else {
            //    Console.WriteLine("Sayı tektir.");
            //}

            //KLAVYEDEN GİRİLEN VERİLERİ YAZDIRAN CHAR DEĞİŞKENİ İLE KARAR YAPILARI

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz : ");
            //team = char.Parse(Console.ReadLine());
            //if(team=='g'| team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}


            #endregion

            #region ORNEK PROJE UYGULAMASI
            Console.WriteLine("********** C# EĞİTİM KAMPI RESTORANT **********");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1 - ANA YEMEKLER");
            Console.WriteLine("2 - ÇORBALAR");
            Console.WriteLine("3 - PİZZALAR");
            Console.WriteLine("4 - İÇECEKLER");
            Console.WriteLine("5 - TATLILAR");
            Console.WriteLine("-----------------------------------------------------");
            string menuItem;
            Console.Write("Lütfen detayını görmek istediğiniz menüyü seçiniz : ");
            menuItem = Console.ReadLine();
            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("---------- ANA YEMEKLER ----------");
                Console.WriteLine();
                Console.WriteLine("1 - KÖRİ SOSLU TAVUK");
                Console.WriteLine("2 - KIZARTMA TABAĞI");
                Console.WriteLine("3 - FASULYE PİLAV");
                Console.WriteLine("4 - FIRINDA SOMON");
                Console.WriteLine("5 - PATLICAN MUSAKKA");
                Console.WriteLine();
                Console.WriteLine("---------- ANA YEMEKLER ----------");

            }

            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("---------- ÇORBALAR ----------");
                Console.WriteLine();
                Console.WriteLine("1 - MERCİMEK ÇORBASI");
                Console.WriteLine("2 - EZOGELİN ÇORBASI");
                Console.WriteLine();
                Console.WriteLine("---------- ÇORBALAR ----------");

            }

            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("---------- PİZZALAR ----------");
                Console.WriteLine();
                Console.WriteLine("1 - MARGARİTHA ");
                Console.WriteLine("2 - AKDENİZ PİZZA");
                Console.WriteLine("3 - TAVUKLU PİZZA");
                Console.WriteLine();
                Console.WriteLine("---------- PİZZALAR ----------");

            }

            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("---------- İÇECEKLER ----------");
                Console.WriteLine();
                Console.WriteLine("1 - SU ");
                Console.WriteLine("2 - KOLA");
                Console.WriteLine("3 - AYRAN");
                Console.WriteLine();
                Console.WriteLine("---------- İÇECEKLER ----------");

            }

            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("---------- TATLILAR ----------");
                Console.WriteLine();
                Console.WriteLine("1 - TRİLEÇE ");
                Console.WriteLine("2 - KAZANDİBİ");
                Console.WriteLine("3 - SÜTLAÇ");
                Console.WriteLine();
                Console.WriteLine("---------- TATLILAR ----------");

            }
            #endregion

            #region SAYIDAN AY GÖSTERME UYGULAMASI 
            //Console.Write("Lütfen Ay Girişi Yapınız : ");
            //int monthNumber;
            //monthNumber= int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül");   break;   
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi ! ");
            //        break;
            //}
            #endregion

            #region SWITCH CASE HESAP MAKINESI
            //int number1, number2, result;
            //char symbol;
            //Console.Write("Birinci sayıyı giriniz : ");
            //number1=int.Parse(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz : ");
            //number2=int.Parse(Console.ReadLine());

            //Console.Write("Yapılmasını istediğiniz işlemi seçiniz : ");
            //symbol=char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam : "+result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarma : " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım : " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm : " + result);
            //        break;

            //}

            #endregion
            Console.ReadKey();



        }
    }
}
