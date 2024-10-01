using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // CultureInfo ile ilgili hatalar almamak için ekledik.

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            double number;
            number = 4.85; // Kod tarafında nokta olarak giriyoruz, console ekranında ise virgül olarak karşımıza çıkıyor.
            Console.WriteLine(number);

            Console.WriteLine("**** Fiyat Listesi ****");
            Console.WriteLine();

            double applePrice, strawberryPrice, potatoPrice, tomatoPrice;
            decimal orangePrice; 
            applePrice = 14.85;
            orangePrice = 20.95m;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            CultureInfo culture = new CultureInfo("en-US"); //  Amerikan doları için kullanılan kültürü belirtir.
            Console.WriteLine("--- Elma Birim Fiyatı: " + applePrice.ToString("C", culture)); // ToStirng yöntemi kullanırak dönüşüm gerçekleştirdik.
            CultureInfo TrCulture = new CultureInfo("tr-TR");
            Console.WriteLine("--- Portakal Birim Fiyatı: " + orangePrice.ToString("C", TrCulture));
            Console.WriteLine("--- Çilek Birim Fiyatı: " + +strawberryPrice + " TL");
            Console.WriteLine("--- Patates Birim Fiyatı: " + potatoPrice + " TL");
            Console.WriteLine("--- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            // Her şeyi test ederek gidin. Her bir parçayı test etmek uzun kodlu projelerin yapım aşamasında sorunsuz ilerlemesini sağlar.
            Console.WriteLine();
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * Convert.ToDouble(orangePrice); // Yukarıda orangaPrice'ı decimal olarak tanımlamıştık. Convert ile Double'a dönüştürdük.
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Alınan ürün: Elma - " +"Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + "- Toplam Tutar: " + appleTotalPrice +" TL");

            Console.WriteLine("Alınan ürün: Portakal - " +"Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + "- Toplam Tutar: " + orangeTotalPrice + " TL");

            Console.WriteLine("Alınan ürün: Çilek - " +"Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + "- Toplam Tutar: " + strawberryTotalPrice + " TL");

            Console.WriteLine("Alınan ürün: Patates - " +"Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + "- Toplam Tutar: " + potatoTotalPrice + " TL");

            Console.WriteLine("Alınan ürün: Domates - " +"Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + "- Toplam Tutar: " + tomatoTotalPrice + " TL");

            Console.WriteLine();
            Console.WriteLine();

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
                     
            Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");

            #endregion // Double Değişkenler

            #region Char Değişkenler
            // Karakter türü tek bir değer alır ve o değer tek tırnak içerisinde gösterilir.

            char symbol;
            symbol = 'a';

            Console.WriteLine(symbol);

            #endregion // Char Değişkenler

            #region Klavyeden Veri Girişleri - String Değişkenler

            Console.WriteLine("*** CSharp Hava Yolları Yolcu Bilgisi ***");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            // Ctrl + F Tuşu ile istediğimiz kelimeyi yenisiyle değiştirebiliyoruz.
            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu Tc Kimlik No: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("---------------");
            Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

            #endregion // Klavyeden Veri Girişleri

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            Console.WriteLine();
            Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);

            #endregion // Klavyeden Tam Sayı Girişleri ve Dönüşümler

            #region Klavyeden Ondalıklı Sayı İşlemleri
            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1. Sınva notunuzu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. Sınva notunuzu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. Sınva notunuzu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Sınav ortalamanız: " + result);

            #endregion // Klavyeden Ondalıklı Sayı İşlemleri

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + (gender == 'e' ? "Erkek" : "Kadın"));
            // Ternary Operatörünü Kullandım.
                   // Tek satırda şart kontrolü yapmak için kullanılır.
                   //  degiskenAdi = sart/durum ? true : false
                   // ? sağında yazılacak işlem karşılaştırma true ise gerçekleşecektir.
                   // : sağında yazılacak işlem karşılaştırma false ise gerçekleşecektir.
                   // Geriye dönecek değerler aynı türde olmalıdır.
            #endregion // Klavyeden Karakter Girişleri

            Console.Read();
        }
    }
}
