using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Açıklama satırı

// using => Kullanacağımız kodlara ait kütüphaneleri eklememizi sağlar.
// Remove Unnecessary Usings => Kullanılmayan kütüphaneleri kaldırmamızı sağlar. - Kütüphaneleri seç, Ampül'e tıkla orada :)


namespace _01_MainSubjects // Proje ismi
{
    internal class Program // Program => Uygulamanın başta ayağa kalkacağı/çalışacağı sınıf.
        // internal => erişim belirleyici
    {
        static void Main(string[] args)
        {
            // Grup halinde toplamak için;
            // region Konu Başlığı
            // endregion

            #region YazdırmaKomutları

            Console.Write("Merhaba Dünya!");
            // Sol tarafında mor küp varsa o metoddur.
            // Metodun çıktısını parantez içinde yazıyoruz.
            // Eğer alfabetik olarak yazacaksak çift tırnak içinde yazıyoruz.
            Console.WriteLine("Selam");
            // WriteLine dan sonra imleç alt satıra iner.
            

            Console.WriteLine("***** Yemek Kategorileri ******");
            Console.WriteLine();
            Console.WriteLine("1 - Çorbalar");
            Console.WriteLine("2 - Ana Yemekler");
            // ctrl + d ile bulunduğu satırı aşağıya kopyalar
            Console.WriteLine("3 - Soğuk Başlangıçlar");
            Console.WriteLine("4 - Salatalar");
            Console.WriteLine("5 - Tatlılar");
            Console.WriteLine("6 - İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri ******");

            #endregion // YazdırmaKomutları

            #region Değişkenler
            // Variables - Değişkenler
            // Geçici olarak ramde tutulan değerler.

            // Değişken tanımlama
            // değişken_türü değişken_adı ;


            // string
            // Alfabetik, metinsel veriler için kullanılır.
            string name;

            #region Değişkene Değer Atama
            #region Tanımlama aşamasında değer atama için;

            // değişkenTürü degiskenAdi =  value;
            // value - değer demek
            // = Assing (Atama Operatörü)
            //  sağ tarafta verilen değeri sol taraftaki değişkene atar.
            string soyAd = "Kızılırmak";

            #endregion // Tanımlama aşamasında değer atama için;

            #region Tanımlandıktan Sonra Değer Atama

            // degiskenAdi = Value;
            // Eğer ki değişken ismi assing operatörünün solunda çağrılıyorsa o alana değişkenin kendisi (adı) gelecektir. Değişken türü yazılmaz.

            name = "Muhammed"; // Burada değişkene bir değer atıyoruz.
            #endregion // Tanımlandıktan Sonra Değer Atama

            #endregion // Değişkene Değer Atama

            Console.WriteLine(name); // Değişkeni yazdırmak istediğimiz zaman ismiyle çağırırız.

            // Değişken isimlendirme
            // Özel karakter kullanılamaz. "_" istisna.
            // Değişken isimleri rakam ile başlayamaz.

            #region İsimlendirme Kuralları
            #region Pascal Case
            // Her kelimenin ilk harfi büyük yazılır.
            // Kısaltma iki harfli ise her iki harf büyük yazılır.
            string CustomerName;
            #endregion

            #region Camel Case
            // İlk kelime haricindeki diğer kelimelerin ilk hargleri büyük yazılır.
            string customerSurname;
            #endregion

            #region Snake Case
            // Tüm karakter küçük kelime ile yazılır.
            // Kelimeler arası "_" kullanılır.
            string customer_phone;
            #endregion
            #endregion // İsimlendirme Kuralları

            string customerEmail, district, city; // Bir satırda aynı türde birden fazla tanımlama yapılabilir.

            CustomerName = "Muhammed";
            customerSurname = "Kızılırmak";
            customer_phone = "+90 500 400 30 20";
            customerEmail = "deneme@gmail.com";
            district = "Gebze";
            city = "Kocaeli";

            Console.WriteLine("*** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Müşteri: " + CustomerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customer_phone);
            Console.WriteLine("E-Posta Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine();

            CustomerName = "Ayşegül";
            Console.WriteLine(CustomerName);
            // Sıralı programlama (sequential programming) paradigmasında yazılan kodlar sırayla üstten alta doğru okunur ve çalıştırılır. Burada yukarıdaki çıktı alındıktan sonra CustomerName'i değiştirdiğimiz için farklı bir çıktı elde ettik.
            customerSurname = "Kaya";
            customer_phone = "+90 500 400 20 20";
            customerEmail = "test@gmail.com";
            district = "Sapanca";
            city = "Sakarya";

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Müşteri: " + CustomerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customer_phone);
            Console.WriteLine("E-Posta Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-----------------------------------------");

            #endregion // Değişkenler

            #region Int Değişkenler
            // Tam sayı türündeki değişkenler.
            // Rakamları normal yazıyoruz. :)
            int number = 24;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int leomanedePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("---- Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("---- Kola: " + cokePrice + " TL");
            Console.WriteLine("---- Limonata: " + leomanedePrice  + " TL");
            Console.WriteLine("---- Kızartma: " + friesPrice + " TL");
            Console.WriteLine("---- Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int leomaneCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaCount;
            int totalLeomaneCount;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 2;
            pizzaCount = 1;
            leomaneCount = 1;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFriesPrice = friesPrice * friesCount;
            totalPizzaCount = pizzaPrice * pizzaCount;
            totalLeomaneCount = leomaneCount * leomaneCount;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaCount + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limoanata Tutarı: " + totalLeomaneCount + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalLeomaneCount + totalFriesPrice + totalPizzaCount;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
            #endregion // Int Değişkenler

            Console.Read();
            // Enter tuşuna basana kadar ekranı bekletir.
        }
    }
}


