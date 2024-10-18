using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForecahLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            // Döngü: Belirli bir kombinasyon eşliğinde çalışan ve belirli bir şarta bağlı olan periyodik işlemler gerçekleştiren yapılanmalardır.
            // İterasyon: İterasyon mantığında, ne kombinasyon ne de şart vardır. İterasyonda; sonraki veri, öteki veri anlamına gelen itere etme fiili vardır.Bir veri kümesi üzerinde işlem yapmamızı/ verileri elde etmemizi sağlayan yapılanmadır.

            #endregion

            #region Foreach İterasyonu Nasıl Kullanılır?
            int[] sayilar = { 10, 20, 30, 40, 50, 60 };
            // verilen veri kümesinde ki tüm elamanları temsil eden bir değişken tanımlarız.
            // eldeki veri kadar işlem yapılır.
            foreach (int i in sayilar)
            // elamanları temsil eden değişken in collection => Dizi, Koleksiyon, Veri kümesi
            {
                Console.WriteLine(i * 10); // her bir elamanı 10 ile çarpar
            }
            // kaynağın, veri kümesindeki elaman sayısı oynayacaksa forech yapılanması bozulacak ve hata verecektir.
            // kısaca foreach yapılanması kaynak da ki veri kadar işlem yapar bunu unutma.
            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            Console.Write("***** C# Eğitim Sınav Uygulaması ****");
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-----------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());

            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her Öğrenci İçin 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // notları topluyoruz
                }
                studentExamAvg[i] = totalExamResult / 3;
            }
            // Sınav Ortalamaları
            for (int i = 0; i < studentCount; i++)
                {
                Console.WriteLine("---------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                    // Öğrencinin ortalaması ve geçip kalma durumları
                    if (studentExamAvg[i] >= 50)
                    {
                        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                    }
                    else
                    {
                        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                    }
                Console.WriteLine("---------------------------");
                }
            #endregion // Örnek Sınav Sistemi Uygulaması
            Console.Read();
        }
    }
}
