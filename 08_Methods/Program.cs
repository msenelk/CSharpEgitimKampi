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
            #region gencayyildiz.com
            #region İşlevsel Açıdan Metot Bize Ne Kazandırır?
            // Kodun içindeki tekrar eden kodları tek seferlik tanımlayıp/inşa edip tek seferde çağırmamızı/kullanmamızı sağlar.
            // Yazılmış olan bir kodu tekrar çağırmakla, tekrar yazmak arasında fark vardır!
            // Metotlar, içerisine yazılan kodun, tekrarlı bir şekilde kullanılmasını sağlarlar. Ve bunu yaparken kaynak kodun tekrar etmesini de engellemiş olurlar. Böylecek ideal kodlamaya erişmiş oluruz.
            // Nerede çağırırsan çağır, aynı işlevi yapacaktır.
            #endregion // İşlevsel Açıdan Metot Bize Ne Kazandırır?
            #region Metot Anatomisi Nasıldır? Gelin Metot İmzasını İnceleyelim
            // Şu an için class içerisinde metot tanımlıyoruz.
            // Bir metot oluşturabilmek için:
            // Önce; Metodun dışarıdan erişebilirliliğini belirlememiz gerekir.
            // [erişim belirleyicisi] [geri dönüş değeri] [metodun adı] () - imza
            //{
            // gövde
            //}
            // [erişim belirleyicisi] ileride göreceğimiz Access Modifer yapılardır.
            // Oluşturulmuş olan bir yapının dışarıdan erişilip erişilemeyeceğini belirlememizi sağlayan komutlardır.
            // public: Erişilsin
            // private : Gizli/Erişilmesin.
            // [geri dönüş değeri]
            // Metotlar yaptıkları operasyonlar/algoritmalar/işlemler neticesinde geriye değerler dönebilmektedirler.
            // Bu değer kodun içerisinde yakalanabilir ve programatik olarak işlemlere tabii tutulabilir.
            // Geri dönüş değerini ekran çıktısıyla karıştırmamak gerekmektedir.
            // [metodun adı]
            // Metotlarda diğer yapılar gibi bir isim almakta ve diğer tanımlama özellikleri geçerlidir.
            // ( )
            // Metot dediğimiz bu yapılanmalar dış dünyadan parametreler alabilmekte ve bu parametrelerdeki değerler üzerinde işlemler gerçekleştirebilmektedir. İşte bu parametreleri parantez içerisinden alabilmekteyiz.
            // Bir metot illaki parametre almak zorunda değildir.
            // (int sayi1) (int sayi1, int sayi2) ()
            // bir parametre iki parametre hiç :)
            // {}
            // Metodun gerçekleştireceği operasyonu/fiiliyatı/eylemi/algoritmayı oluşturduğumuz kodladığımız faaliyet alanıdır.
            #endregion // Metot Anatomisi Nasıldır? Gelin Metot İmzasını İnceleyelim
            #region İşlevine Göre Metot Türleri Nelerdir?
            // Yapılacak işleme göre dört farklı türde/varyasyonda metot oluşturulabilmektedir.
            // Geriye Değer Döndürmeyen, Parametre Almayan
            // Geriye Değer Döndürmeyen, Parametre Alan
            // Geriye Değer Döndüren, Parametre Almayan
            // Geriye Değer Döndüren, Parametre Alan
            #region Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndürmeyen Parametre Almayan Metot Türü
            // [erişim belirleyicisi] [geriye dönüş değeri] [Metot adı]()
            //{
            //}
            void Metot2() => Console.WriteLine("Geriye değer döndürmeyen, paramaetre almayan metot oluşturuldr.");
            // Bir metot geriye değer döndürmüyorsa bunun void ile bildirilmesi zorunludur.
            #endregion // Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndürmeyen Parametre Almayan Metot Türü
            #region Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndürmeyen Parametre Alan Metot Türü
            void Metot3(int a)
            // parametre
            {
            }
            void Metot4(int a, bool b)
            {
            }
            void Metot5(int a, bool b, char c)
            {
            }
            #endregion // Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndürmeyen Parametre Alan Metot Türü
            #region Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndüren Parametre Almayan Metot Türü
            // Eğer ki bir metot geriye herhangi bir türde değer döndüreceğini ifade ediyorsa kesinlikle o türde bir değer döndürmelidir. Aksi taktirde hata verir.
            char Metot5()
            // geriye char değerinde değer döndürür
            {
                return 'a'; // Geriye değer döndüren fonksiyonlarda, bildirilen türde bir değer döndürebilmek için return keywordünü kullanmamız gerekmektedir.
                            // Return; nerede işlenirse orada ilgili fonksiyondan/metotdan çıkılır.
                            // Türlere uygun şekilde bir değer döndürülmelidir.
                            // Yazsan da yazmasan da private dir. Default olan o :)
            }
            #endregion // Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndüren Parametre Almayan Metot Türü
            #region Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndüren Parametre Alan Metot Türü
            bool Metot6(int r)
            {
                return true;
            }
            #endregion // Metot Tanımlama/Oluşturma Varyasyonları - Geriye Değer Döndüren Parametre Alan Metot Türü
            #endregion // İşlevine Göre Metot Türleri Nelerdir?
            #region Metodun Geriye Değer Döndürmesi Ne Demektir?
            int Topla(int sayi1, int sayi2)
            {
                int sonuc = sayi1 + sayi2;
                Console.WriteLine(sonuc); // ekrana çıktı verir
                return sonuc; // ekrana çıktı vermez sonucu kullanmamız için tutar
                              // Metodun geriye değer döndürmesi demek, metodun yaptığı işlem neticesinde üretilen değeri ekrana/console/veritabanına/herhangi bir log ekranına çıktı vermesi demek değildir.
                              // Metodun geriye döndürdüğü değer, programatik olarak yakalanıp algoritmanın akışında farklı yönlendirmelere sebebiyet verebilen değerdir.
                              // Metodun geriye döndürdüğü değer algoritmanın akışında kullanılabilir değerdir.
            }
            #endregion // Metodun Geriye Değer Döndürmesi Ne Demektir?
            #endregion // gencayyildiz.com
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
