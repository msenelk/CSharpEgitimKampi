using System;
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
            // mor renkli küp = metot
            // Geriye Değer Döndürmeyen Metotlar
            //Customer => Listele, ekle, sil, güncelle
            // Void

            void CustomerList()
            {
                Console.WriteLine("Ali Yıldız");
                Console.WriteLine("Ayşe Yıldız");
                Console.WriteLine("Hakan Öztürk");
                Console.WriteLine("Merve Çınar");
            }
            CustomerList();
            CustomerList();
            CustomerList();
            CustomerList();

            void Sum()
            {
                int x1 = 1;
                int y1 = 2;
                int z1 = x1 + y1;
                Console.WriteLine(z1);
            }
            Sum();
            #endregion // Void Metotlar

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            void WriteMethod(string customerName)
            {
                Console.WriteLine(customerName);
            }
            WriteMethod("Muhammed Şenel Kızılırmak");

            void CustomerCard(string name, string surName)
            {
                Console.WriteLine("Müşteri: " + name + " " + surName);
            }
            CustomerCard("Muhammed", "Kızılırmak");
            #endregion // Geriye Değer Döndürmeyen  String Parametreli Metotlar

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            void sum2(int number1,int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }
            sum2(2, 5, 6);
            #endregion // Geriye Değer Döndürmeyen Int Parametreli Metotlar

            #region Geriye Değer Döndüren Metotlar
            // değişken veya sınıf türüyle tanımlanır
            
            string CustomerName()
            {
                return "Muhammed Kızılırmak";
            }
            CustomerName();

            string StudentCard()
            {
                string name = "Ali";
                string surname = "Kaya";

                return name + " " + surname;
            }
            Console.WriteLine(StudentCard());

            #endregion // Geriye Değer Döndüren Metotlar

            #region Geriye Değer Döndüren String Parametreli Metotlar
            string CountryCard(string countryName, string capital, string flagColor)
            {
                string cardInfo = "Ülke: " +  countryName + " - Başkent: " + capital + " Bayrak Rengi: " + flagColor;
                return cardInfo;
            }
            string x, y, z;
            Console.Write("Ülke Adını Giriniz: ");
            x = Console.ReadLine();
            Console.Write("Başkenti Girinizi: ");
            y = Console.ReadLine();
            Console.Write("Bayrak Rengini Giriniz: ");
            z= Console.ReadLine();

            Console.WriteLine(CountryCard(x, y, z));

            Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı - Beyaz"));
            #endregion // Geriye Değer Döndüren String Parametreli Metotlar

            #region Geriye Değer Döndüren Int Parametreli Metotlar
            int Sum2(int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }
            Console.WriteLine(Sum2(45,95));
            Console.WriteLine(Sum2(36,70));
            Console.WriteLine(Sum2(14,20));
            #endregion // Geriye Değer Döndüren Int Parametreli Metotlar

            #region Örnek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if(result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti" + " Ortalama " + result;
                }
                else
                {
                    return student + "isimli öğrenci başarısız oldu" + " Ortalama " + result;
                }
            }
            Console.WriteLine(ExamResult("Muhammed",25,41,55));
            Console.WriteLine(ExamResult("Şenel",36,88,33));
            #endregion // Örnek Uygulama


            Console.Read();
        }
    }
}
