using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ALT ALTA 10 TANE YILDIZ OLUŞTURMA
            //for (int i=1; i<=10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region YAN YANA 10 TANE YILDIZ OLUŞTURMA
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region ALT ALTA YILDIZ OLUŞTURMA HER SATIRDA 10 TANE YILDIZ OLSUN
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            #endregion

            #region DIK UCGEN
            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j=1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region TERS DİK ÜÇGEN
            //for(int i =5; i >= 1; i--)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region DİK VE TERS DİK ÜÇGEN BERABER
            //for (int i = 1; i <= 6; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region BAKLAVA DİLİMİ
            //ÜST KISIM 

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n-1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k=1; k <=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //ALT KISIM
            // for(int i= n-1; i>=1; i--)
            //{
            //    for (int j= n-1;j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k <=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region PIRAMIT
            //int n = 5;
            //for (int i = 1; i <= n; i++) {
            //    //boşlukları yazdırırız. 
            //    for (int j = n-i; j >0; j--) {
            //        Console.Write(" ");
            //    }
            //    //yıldızları burada yazdırırız. 
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region TERS PIRAMIT
            //int n = 5;
            //for (int i = n; i >=1; i--)
            //{
            //    for(int j = n - i; j > 0; j--) {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
                
            //}
            #endregion
            Console.ReadKey();
        }
    }
}
