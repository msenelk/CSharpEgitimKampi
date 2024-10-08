using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision // Karar Yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            // if yapılanması, elimizdeki bir değerin eşitlik durumuda dahil bütün karşılaştırmları yapmamızı sağlayan ve sonuca göre akışı yönlendirmemize yarayan bir yapılanmadır.

            // prototip
            // şart kısmı her daim bool türünde olmalıdır yani True veya False
            // Karşılaştırma operatörleri ve mantıksal operatörler kullanılabilir.

                 // Karşılaştırma Operatörleri
                     // Karşılaştırma operatörleri geriye her daim "bool" türde bir değer döndürecektir.
                        // < Küçüklük
                        // > Büyüklük
                        // <= Küçük veya Eşitlik
                        // >= Büyük veya Eşitlik
                        //== Eşitlik

                 // Mantıksal Operatörler
                      // Tüm şartları değerlendirip, kendine göre sonuç (bool) döndüren operatörlerdir. 
                        // ve &
                            // tüm şartların yerine getirilmiş olmasını ister.
                            // true & true = true
                     
                        // veya |
                         //  en az bir tanesinin yerine getirilmiş olmasını ister
                         // true | false => true - false | true => true

                        // ya da ^
                            // şartlardan kesinlikle bir tanesinin yerine getirilmiş olmasını ister
                            // iki şart aynı anda true olamaz
                            // ya da iki şart aynı anda false olamaz.

            // if(şart)
            //{ şart true ise burası tetiklenir.
            //} eğer ki şart false ise compiler if scope'undan çıkacak ve yoluna devam edecektir.

            // if yapılanması tek başına kullanılıyorsa sadece şarta bağlı çalışacak koda odaklanır.

            #region Örnek 1
            Console.Write("Lütfen şifreyi giriniz: ");
            string password;
            password = Console.ReadLine();
            if (password == "abc")
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }

            #endregion // Örnek 1

            #region Örnek 2
            string capital, country;
            Console.Write("Başkenti Giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi Giriniz: ");
            country = Console.ReadLine();

            if (capital == "Ankara" & country == "Türkiye")
            {
                Console.WriteLine("Veriler Doğrulandı");
            }
            else
            {
                Console.WriteLine("Hatalı Bilgi.");
            }
            #endregion // Örnek 2

            #region Örnek 3
            int number;
            Console.Write("Sayı Giriniz: ");
            number = int.Parse(Console.ReadLine());
            if (number == 5)
            {
                Console.WriteLine("Sayı Doğru!");
            }
            else
            {
                Console.WriteLine("Sayı Hatalı");
            }
            #endregion // Örnek 3

            #region Örnek 4
            int exam1, exam2, exam3, average;
            string result = "Hata";

            Console.Write("Sınav 1: ");
            exam1 = int.Parse(Console.ReadLine());

            Console.Write("Sınav 2: ");
            exam2 = int.Parse(Console.ReadLine());

            Console.Write("Sınav 3: ");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınavların Ortalaması: " + average);

            if (average > 0 & average <= 50)
            {
                result = "Sonuç Vasat!";
            }
            if (average > 50 & average <= 70)
            {
                result = "Sonuç Orta";
            }
            if (average > 70 & average <= 84)
            {
                result = "Sonuç İyi";
            }
            if (average > 84)
            {
                result = "Sonuç Çok İyi";
            }

            //  Console.WriteLine(result); // result'a bir değer ataması veya if bloğunda else olarak atama yapmamız gerekiyor yoksa bize hata döndürecektir. Hata sebebi ise gelen değelerin yukarıdaki hiçbir şarta uymaması durumunda result'a hiçbir değer atanamayacağı içindir. Bu yüzden her şeye değer ata. :)
            #endregion // Örnek 4

            #region Örnek 5
            string city;
            Console.Write("Lütfen şehir girişi yapınız: ");
            city = Console.ReadLine();
            if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            {
                Console.WriteLine("Şehir mevcut");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil.");
            }
            #endregion // Örnek 5

            #region Örnek 6
            Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            string username = Console.ReadLine();
            if (username != "admin") // Başına ! koyuldığında ise sonucu true ise false; false ise true yapıyor.
            {
                Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            }
            else
            {
                Console.WriteLine("Hoş geldiniz!");
            }
            #endregion // Örnek 6
            #endregion // If

            #region Mod İşlemleri
            #region Örnek 1
            int number2 = 26;
            int result2 = number2 % 5; // number sayısının 5'e bölümünden kalanını yazdırmamıza yarar = %
            Console.WriteLine(result);

            #endregion // Örnek 1

            #region Örnek 2
            Console.Write("Lütfen 1. sayıyı giriniz: ");
            int number3 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. sayıyı giriniz: ");
            int number4 = int.Parse(Console.ReadLine());

            int result3 = number3 % number4;
            Console.WriteLine("Birinci sayı: " + number3 + "'ın 2. sayıya " + number4 + " bölümünden kalan: " + result);
            #endregion // Örnek 2

            #region Örnek 3
            Console.Write("Lütfen sayıyı giriniz: ");
            int number5 = int.Parse(Console.ReadLine());

            if (number5 % 2 == 0)
            {
                Console.WriteLine("Say çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }
            #endregion // Örnek 3

            #endregion // Mod İşlemleri

            #region Char Değişkenler İle Karar Yapıları
            char team;
            Console.Write("Lütfen takım sembolünü giriniz: ");
            team = char.Parse(Console.ReadLine());
            if (team == 'g' | team == 'G')
            {
                Console.WriteLine("Galatasaray");
            }
            if (team == 'f' | team == 'F')
            {
                Console.WriteLine("Fenerbahçe");
            }
            if (team == 'b' | team == 'B')
            {
                Console.WriteLine("Beşiktaş");
            }

            #endregion // Char Değişkenler İle Karar Yapıları

            #region Örnek Uygulama
            Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine("1 - Ana Yemekler ");
            Console.WriteLine("2 - Çorbalar");
            Console.WriteLine("3 - Pizzalar");
            Console.WriteLine("4 - İçecekler");
            Console.WriteLine("5 - Tatlılar");
            Console.WriteLine("-----------------");

            string menuItem;
            Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("------ 1 - Ana Yemekler ------");
                Console.WriteLine();
                Console.WriteLine("1 - Köri Soslu Tavuk");
                Console.WriteLine("2 - Kızartma Tabağı");
                Console.WriteLine("3 - Fasulye Pilav");
                Console.WriteLine("4 - Fırında Somon");
                Console.WriteLine("5 - Patlıcan Musakka");
                Console.WriteLine("------ 1 - Ana Yemekler ------");
            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("------ 2 - Çorbalar ------");
                Console.WriteLine();
                Console.WriteLine("1 - Mercimek Çorbası");
                Console.WriteLine("2 - Ezogelin Çorbası");
                Console.WriteLine("------ 2 - Çorbalar ------");
            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("------ 3 - Pizzalar ------");
                Console.WriteLine();
                Console.WriteLine("1 - Akdeniz Pizza");
                Console.WriteLine("2 - Margaritha");
                Console.WriteLine("------ 3 - Pizzalar ------");
            }
            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("------ 4 - İçecekler ------");
                Console.WriteLine();
                Console.WriteLine("1 - Kola");
                Console.WriteLine("2 - Ayran");
                Console.WriteLine("3 - Su");
                Console.WriteLine("------ 4 - İçecekler ------");
            }
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("------ 5 - Tatlılar ------");
                Console.WriteLine();
                Console.WriteLine("1 - Triliçe");
                Console.WriteLine("2 - Kazandibi");
                Console.WriteLine("3 - Sütlaç");
                Console.WriteLine("------ 5 - Tatlılar ------");
            }
            #endregion // Örnek Uygulama

            #region Switch Case
            // Switch Kod bloğun anahtar kısmı
            // Case ise anahtarın durumları

            // Switch case yapılanması sadece bir değişkenin değerini sadece eşitlik durumlarını kontrol ederken kullanılabilir.

            // parantez içerisine, süreçte eşitlik durumunu kontrol edilecek olan değeri yazıyoruz.
            // case den sonra gelen yere ise eşitlik durumunu kontrol etmek istediğimiz veriyi yazıyoruz.
            // case ile break arasında yazılan kodlar ilgili case'in doğrulanması sürecinde işlenecek kodlardır.

            // switch-case yapılanmasında hiçbir eşitlik şartları çalıştırılmıyorsa default break arasında ki kodlar çalıştırılacaktır.
                // default kalıbı zorunlu değildir. Tetiklenmeden akış devam eder.

            // swtich-case yapılanmasında kontrol edilen değer ile eşitlik sağlayan case varsa diğer case'lere bakılmaksızın kod bloğu sonlanacaktır.

            // Kontrol edilen değerin türü ne ise case bloklarında da aynı türde değerler kontrol edilmelidir.

            // case deki değerler değişkenlerden alınamaz, sabit/statik olmak zorundadır.

            #region Örnek 1
            Console.Write("Lütfen ay girişini yapınız: ");
            int monthNumber = int.Parse(Console.ReadLine());
            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break; // Case burada çalıştığı anda kod bloğundan çıkmak için break yazılır.
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Hatalı Veri Girişi");
                    break;
            }
            #endregion // Örnek 1

            #region Örnek 2 - Hesap Makinesi
            int number6, number7, result4;
            char symbol;

            Console.Write("Birinci sayıyı giriniz: ");
            number6 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            number7 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result4 = number6 + number7;
                    Console.WriteLine("Toplam: " + result4);
                    break;
                case '-':
                    result4 = number6 - number7;
                    Console.WriteLine("Fark: " + result4);
                    break;
                case '*':
                    result4 = number6 * number7;
                    Console.WriteLine("Çarpım: " + result4);
                    break;
                case '/':
                    result4 = number6 / number7;
                    Console.WriteLine("Bölüm: " + result4);
                    break;
                default: Console.WriteLine("Hatalı Seçim Yaptınız:");
                    break;
                    
            }
            #endregion // Örnek 2 - Hesap Makinesi

            #endregion // Switch Case
            Console.Read();
        }
    }
}
