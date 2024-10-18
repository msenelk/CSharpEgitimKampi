using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Diziler (Array) Nedir?
        //Tek bir değişken altında birden fazla “aynı türde” değeri toplamamızı sağlayan veri kümelerine dizi denmektedir.
        //Yazılımsal boyutta, yazılım adına RAM’de birden fazla değeri tek bir değişken altında bir veri kümesi halinde tutabilirler.
        //Diziler, veri kümeleri oldukları için, içlerindeki birden fazla veri üzerinde kümesel işlemler yapmamızı sağlayabilirler.
        //Diziler referans türlü değerlerdir. Yani nesnel yapılardır.Özlerinde classtırlar.
        //Yapısal olarak RAM’de Heap’te tutulurlar.

        //Dizi içerisine her türlü değer koyulabilir.
        //Bir dizi sade ve sadece tek bir türde değer alabilir.
        //Eğer dizi int olarak tanımlandıysa içerisine sadece int olan değerleri alır.
        //Dizi içerisine koyulan değerler işlevsel olarak aynı mahiyette olmalıdır.
        //Yaş dizisine maaş bilgisi aynı türde olduğu halde verilmemelidir.

        //Diziler içerisine elaman / değer eklendikçe bunları serseri bir şekilde depolamaz, düzenli bir şekilde sıralı depolayacaktır.
        //Dizilerde eklenen elamanlar index ismini verdiğimiz numaralarla ardışık bir şekilde numaralandırılırlar.
        //Prototip index numarası 0’dan başlar, n – 1 ‘ e kadar gider.

        //type a; => Bu normal bir değişken
        //dizininTürü[] dizininAdı = new dizininTürü[maxDeger]; => Bu da dizi.

        //[ ] => Bir değişken tanımlanırken türünün yanına bu operatörü koyarsak o değişken o türde bir dizi değişkeni olacaktır. Bu operatöre INDEXER ismi verilmektedir.
        //maxDeger => Bu dizinin alacağı elaman sayısını belirtir.


            #endregion

            #region Temel Dizi Örnekleri
            // Aynı veri tipindeki farklı verileri bir arada tutmamıza yarar.
            // 2,4,6,8 - çiftler
            // sarı,kırmızı,beyaz - renkler

            // DeğişkenTürü [] DiziAdi = new DeğişkenTürü[ElamanSayısı]

            string[] colors = new string[4];

            colors[0] = "Sarı";
            colors[1] = "Kırmızı";
            colors[2] = "Beyaz";
            colors[3] = "Mavi";

            Console.WriteLine(colors[2]);

            int[] numbers = new int[10];
            numbers[0] = 150;
            numbers[1] = 122;
            numbers[2] = 140; 
            numbers[6] = 20; // Tanımlamada index sırasına uymak zorunda değiliz.
            numbers[7] = 22;

            Console.WriteLine(numbers[8]); // Var olan ama tanımlanmamış indexi yazdırmaya çalıştığımızda 0 değerini döndürür.

            string[] cities = {"Prag", "Roma", "Atina","Ankara" }; // Farklı olarak dizi tanımlama.

            #endregion // Temel Dizi Örnekleri

            #region Dizideki Tüm Elamanları Listeleme

            string[] colors2 = {"Sarı", "Kırmızı", "Beyaz", "Mavi", "Turuncu", "Pembe"};

            for (int i = 0; i < colors2.Length; i++)
            {
                Console.WriteLine(colors2[i]);
            }

            #endregion // Dizideki Tüm Elamanları Listeleme

            #region Dizi Metotları
            //Length: Dizinin veya string'in eleman sayısını döndürür. (Örn: array.Length veya string.Length).
            //Short: Bu bir veri tipi olup, -32,768 ile 32,767 arasındaki tam sayıları tutar.
            //Reverse: Diziyi veya string'i ters çevirir. (Örn: Array.Reverse() veya string.Reverse()).
            //IndexOf: Bir string veya dizide belirli bir öğenin ilk bulunduğu indeksi döndürür. (Örn: string.IndexOf("a")).
            //Max(): Bir koleksiyondaki en büyük değeri döndürür. (Örn: array.Max()).
            //Min(): Bir koleksiyondaki en küçük değeri döndürür. (Örn: array.Min()).


            #endregion //Dizi Metotları

            #region Kullanıcıdan Değer Alma
            string[] cities2 = new string[5];

            for(int i = 0;i < cities2.Length; i++)
            {
                Console.Write($"Lüften {i + 1}. Şehri Giriniz: ");
                cities2[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("----------------");

            for (int i = 0; i < cities2.Length; i++){
                Console.WriteLine(cities2[i]);
            }
            #endregion // Kullanıcıdan Değer Alma

            #region Dizi İçerisindeki Sayıları Tek ve Çift Olarak Listele
            int[] numbers3 = { 21, 42, 33, 54, 55, 66, 787, 38, 79, 220 };
            Console.WriteLine("Çift sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers3.Length; i++)
            {
                if (numbers3[i] % 2 == 0)
                {
                    Console.WriteLine(numbers3[i]);
                }
            }
            Console.WriteLine("------------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers3.Length; i++)
            {
                if (numbers3[i] % 2 == 1)
                {
                    Console.WriteLine(numbers3[i]);
                }
            }
            #endregion // Dizi İçerisindeki Sayıları Tek ve Çift Olarak Listele

            Console.Read();
        }
    }
}
