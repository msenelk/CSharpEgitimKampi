using System;
using System.Data;
using System.Data.SqlClient;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ado.net

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-------------------------");
            Console.WriteLine("1 - Kategoriler");
            Console.WriteLine("2 - Ürünler");
            Console.WriteLine("3 - Siparişler");
            Console.WriteLine("4 - Çıkış Tap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------");

            // Sql Bağlantısı
            SqlConnection connection = new SqlConnection("Data Source = MSENELK\\SQLEXPRESS;initial Catalog = EgitimKampiDb; integrated security = true");
            // Sql Bağlantısını aç
            connection.Open();
            // Sorgu yazılması için hangi tabloya olduğunu bildirmek için connecition yazıyoruz çünkü sql bağlantısını o isme tanımladık
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            // köprü görevi görüyor.
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            // Verileri geçici belleğe almamızı sağlar
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            // Bağlantıyı kapat
            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
