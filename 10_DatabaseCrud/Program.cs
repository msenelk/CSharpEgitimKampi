using System;
using System.Data;
using System.Data.SqlClient;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud => Create, Read, Update, Delete

            Console.WriteLine("**** Menü Sipariş İşlem Panel ****");
            Console.WriteLine();

            Console.WriteLine("----------------------------------");
            #region Kategori Ekleme İşlemi
            Console.Write("Eklemek İstediğiniz Kategori Ad: ");
            string categoryName = Console.ReadLine();
            // Sql bağlantısın için SqlConnection
            SqlConnection connection = new SqlConnection("Data Source = MSENELK\\SQLEXPRESS;initial Catalog = EgitimKampiDb; integrated security = true");

            connection.Open();
            // Sql sorgulaması için SqlCommand
            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            // insert ekle
            // into içine
            command.Parameters.AddWithValue("@p1", categoryName);
            // Koşulsuz bir şekilde sorguyu çalıştırmak için:
            command.ExecuteNonQuery();
            // Bağlantıyı kapat
            connection.Close();

            Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion // Kategori Ekleme İşlemi
            #region Ürün Ekleme İşlemi
            string productName;
            decimal productPrice;
            // bool productStatus = true;

            Console.Write("Ürün Adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = MSENELK\\SQLEXPRESS;initial Catalog = EgitimKampiDb; integrated security = true");
            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName, @productPrice,@productStatus)", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus", true);
            command.ExecuteNonQuery();
            connection.Close();
            Console.Write("Ürün eklemesi başarılı.");

            #endregion // Ürün Ekleme İşlemi
            #region Ürün Listeleme İşlemi
            SqlConnection connection = new SqlConnection("Data Source = MSENELK\\SQLEXPRESS;initial Catalog = EgitimKampiDb; integrated security = true");
            connection.Open();
            // Connection da tanımladık işte :D
            SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            // command bağlantısı da select * from TblProduct sorgusunu çalıştırıp connection bağlantısı üzerinden devam ediyor.
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            // adapter da command bağlantısından değer alıyor.
            // Ramin içerisinde bir alan hazırlanıyor.
            DataTable dataTable = new DataTable();
            // dataTable dan gelen değer;
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows) // dataTable nin tüm satırlarını okumak istiyoruz
            {

                foreach (var item in row.ItemArray) // satırdaki sütunları görmek için
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }
            connection.Close();
            #endregion // Ürün Listeleme İşlemi
            #region Ürün Silme İşlemi
            Console.Write("Silinecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = MSENELK\\SQLEXPRESS;initial Catalog = EgitimKampiDb; integrated security = true");

            connection.Open();

            SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductID = @productId", connection);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Silme İşlemi Yapıldı");
            #endregion // Ürün Silme İşlemi
            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellenecek Ürün ID: ");
            int productId2 = int.Parse(Console.ReadLine());

            Console.Write("Güncellecek Ürün Adı: ");
            string productName2 = Console.ReadLine();

            Console.Write("Güncellecek Ürün Fiyatı: ");
            decimal productPrice2 = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = MSENELK\\SQLEXPRESS;initial Catalog = EgitimKampiDb; integrated security = true");
            connection.Open();

            SqlCommand command = new SqlCommand ("Update TblProduct Set ProductName=@productName, ProductPrice = @productPrice where ProductId =@productId", connection);

            command.Parameters.AddWithValue("@productName", productName2);
            command.Parameters.AddWithValue("@productPrice", productPrice2);
            command.Parameters.AddWithValue("@productId", productId2);
            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("Güncelleme Başarılı.");
            #endregion // Ürün Güncelleme 
            Console.Read();
        }
    }
}
