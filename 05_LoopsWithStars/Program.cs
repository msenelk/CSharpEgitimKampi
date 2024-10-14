using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız Oluşturma
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*");
            }
            #endregion // Alt Alta 10 Tane Yıldız Oluşturma

            #region Yan Yana 10 Tane Yıldız Oluşturma
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("*");
            }
            #endregion // Yan Yana 10 Tane Yıldız Oluşturma

            #region Alt Alta 10 Tane Yıldız Oluşturma Her Satırda 10 Tane Yıldız Olsun
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("**********");
            }
            #endregion // Alt Alta 10 Tane Yıldız Oluşturma Her Satırda 10 Tane Yıldız Olsun

            #region Dik Üçgen
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion // Dik Üçgen

            #region Ters Dik Üçgen
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion // Ters Dik Üçgen

            #region Dik ve Ters Dik Üçgen Beraber
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int k = 4; k >= 1; k--)
            {
                for (int m = 1; m <= k; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion // Dik ve Ters Dik Üçgen Beraber

            #region Baklava Dilimi
            // Üst Kısmı
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // Alt Kısmı
            for (int i = n - 1; i >= 1; i--)
            {
                for(int j = n - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 1;k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion // Baklava Dilimi

            #region Piramit
            int a = 5;
            for (int i = 1; i <= a; i++)
            {
                // Boşluklar için
                for (int j = a - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                // Yıldızlar için
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion // Piramit

            #region Ters Piramit
            int s = 5;
            for (int i = s; i >= 1; i--)
            {
                // Boşluklar
                for(int j = s - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                // Yıldızlar
                for(int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion // Ters Piramit

            Console.Read();
        }
    }
}
