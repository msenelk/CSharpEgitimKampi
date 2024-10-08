using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops // Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            // Genellikle ardkışık işlemlerde kullanılan bir döngü yapılanmasıdır.

            // Prototip;
            // for{1    ;   2;  3)
            //{
            // şart
            //}

            // 1:
            // Genellikle başlangıç değeri ismi verilen değişken burada tanımlanır.
            // Zorunlu değildir.
            // Başlangıç değer ya da ilk değer atama kısmı olarak aklımızda tutabiliriz.
            // 2: 
            // Şart
            // Herhangi bir şart/koşul ifadesi tanımlanabilir.
            // Lakin genellikle il değer olarak tanımlanan değişken durumu burada kontrol edilebilir ve bir şarta bağlanır.
            // şart true olduğu sürece döngü tetiklenecektir.
            // 3:
            // Genellikle başlangıç değerinin değerini bir arttırmak ya da azatlmak için burası kullanılır.
            // Herhangi bir değişken üzerinde işlem yapabiliriz.
            // Bir değerin dışında değer arttırma ve azaltma işlemleri de ihtiyaca bianen yapılmaktadır.

            // Başlangıç değeri tanımlanıyorsa eğer değer ataması yapılması gerekmektedir.

            // for(x;y;z)
            // x: başlangıç
            // y: bitiş
            // z: artış-azalış

            #region Örnek 1
            int i;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("C# Eğitim Kampı.");
            }
            #endregion // Örnek 1
            Console.WriteLine("----------------");
            #region Örnek 2
            for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine(a);
            }

            #endregion // Örnek 2
            Console.WriteLine("----------------");
            #region Örnek 3
            for (int b = 3; b <= 50; b += 3)
            {
                Console.WriteLine(b);
            }
            #endregion // Örnek 3
            Console.WriteLine("----------------");
            #region Örnek 4
            Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            int finishValue = int.Parse(Console.ReadLine());

            for (int f = 1; f <= finishValue; f++)
            {
                Console.WriteLine("Yaşasın Cumhuriyet");
            }
            #endregion // Örnek 4
            Console.WriteLine("----------------");
            #endregion // For Döngüsü

            #region For Döngüsü İle Karar Yapıları
            #region Örnek 1
            for (int d = 1; d <= 100; d++)
            {
                if (d % 5 == 0)
                {
                    Console.WriteLine(d);
                }
            }
            #endregion // Örnek 1
            #region Örnek 2
            int totalValue = 0;
            for (int f = 1; f <= 10; f++)
            {
                totalValue += f;
            }
            Console.WriteLine(totalValue);
            #endregion
            #region Örnek 3
            int totalValue2 = 0;
            for (int g = 0; g < 20; g++)
            {
                if (g % 2 == 0)
                {
                    totalValue2 += g;
                    Console.WriteLine(g);
                }

            }
            Console.WriteLine("------");
            Console.WriteLine(totalValue2);

            #endregion // Örnek 3
            #region Örnek 4
            int count = 0;
            for (int h = 1; h <= 50; h++)
            {
                if (h % 7 == 0)
                {
                    count++;
                }

            }
            Console.WriteLine(count);
            #endregion // Örnek 4
            #region Örnek 5
            int bacterium = 1;
            for (int j = 1; j <= 24; j++)
            {
                bacterium *= 2;
                Console.WriteLine(j + ". Saat sonunda: " + bacterium);
            }
            #endregion // Örnek 5
            #endregion // For Döngüsü İle Karar Yapıları

            #region While Döngüsü
            // Sadece şarta bağlı bir döngüdür.
            // Şart doğrulandıkça scope içersindeki kodlar tetiklenecektir.
            // While döngüsü içerisindeki kodlar tetiklendikçe tekrardan şarta bakacak ve şart true ise kodlar tetiklenecek ve tekrar şart kontrolü yapılacak bu durum şartın false olmasına kadar gider sona while döngüsünden çıkılıyor.
            // programın ilk tasarlanmış döngüsüdür.
            // Scope içerisinde ki kodlar sadece şartın true olması durumunda tetiklenir.

            // prototip
            // while(true)
            //{
            //işlemler
            //}

            #region Örnek 1
            int w = 1;
            while (w <= 10)
            {
                Console.WriteLine("Merhaba Döngüler");
                w++;
            }
            #endregion
            #region Örnek 2
            int e = 1;
            while (e <= 10)
            {
                if (e % 3 == 0)
                {
                    Console.WriteLine(e);
                }
                e++;
            }
            #endregion
            #region Örnek 2
            // 1 - 10 arasındaki sayıların toplamı
            int r = 1;
            int sum = 0;
            while (r < 11)
            {
                sum += r;
                r++;
            }
            Console.WriteLine(sum);
            #endregion // Örnek 2

            #endregion // While Döngüsü

            #region Örnek Sınav Sorusu
            // Klavyedene girilen 3 basamaklı sayının toplamını hesaplayan kodu yazınız.
            Console.Write("Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum2;

            ones = number % 10; // Sayının ona bölümünden kalan birler basamığıdır.
            tens = (number % 100) / 10;
            hundreds = number / 100;

            Console.WriteLine(hundreds + "-" + ones + "-" + tens);
            sum2 = ones + tens + hundreds;
            Console.WriteLine(sum2);
            #endregion

            Console.Read();
        }
    }
}
