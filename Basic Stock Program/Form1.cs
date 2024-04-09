using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Stock_Program
{
    public partial class Form1 : Form
    {
        private int stokMiktari = 0;
        private int stokmiktari1 = 0;
        private int stokmiktari2 = 0;
        private int stokmiktari3 = 0;
        private int stokmiktari4 = 0;
        private int stokmiktari5 = 0;
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();

            // Bağlantıyı başlat
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Stok;Integrated Security=True;";


            connection = new SqlConnection(connectionString);

            GuncelleStokLabel();
        }
        private void GuncelleStokLabel()
        {
            string query = "SELECT * FROM StokTablosu WHERE ID = 1"; // ID'si 1 olan kaydı seç

            try
            {
                // Bağlantıyı aç
                connection.Open();

                // SqlCommand nesnesini oluştur
                SqlCommand command = new SqlCommand(query, connection);

                // SqlDataReader nesnesini oluştur
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Verileri sırayla oku ve ilgili değişkenlere atama yap
                    stokMiktari = reader.GetInt32(reader.GetOrdinal("Sutun1"));
                    stokmiktari1 = reader.GetInt32(reader.GetOrdinal("Sutun2"));
                    stokmiktari2 = reader.GetInt32(reader.GetOrdinal("Sutun3"));
                    stokmiktari3 = reader.GetInt32(reader.GetOrdinal("Sutun4"));
                    stokmiktari4 = reader.GetInt32(reader.GetOrdinal("Sutun5"));
                    stokmiktari5 = reader.GetInt32(reader.GetOrdinal("Sutun6"));

                    // Etiketleri güncelle
                    label1.Text = "Stok Miktarı: " + stokMiktari.ToString();
                    label8.Text = "Stok Miktarı: " + stokmiktari1.ToString();
                    label9.Text = "Stok Miktarı: " + stokmiktari2.ToString();
                    label10.Text = "Stok Miktarı: " + stokmiktari3.ToString();
                    label11.Text = "Stok Miktarı: " + stokmiktari4.ToString();
                    label12.Text = "Stok Miktarı: " + stokmiktari5.ToString();
                    // Diğer etiketleri de güncelleyin
                }
                else
                {
                    MessageBox.Show("ID'si 1 olan kayıt bulunamadı.");
                }

                // SqlDataReader nesnesini kapat
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
 

            // TextBox'tan değeri alıyoruz
            if (int.TryParse(textBox1.Text, out int girilenMiktar))
            {

                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // UPDATE SQL komutunu oluştur
                    string updateQuery = "UPDATE StokTablosu SET Sutun1 = Sutun1 + @GirilenMiktar WHERE ID = 1";

                    // SqlCommand nesnesini oluştur
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@GirilenMiktar", girilenMiktar);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            GuncelleStokLabel();
            textBox1.Clear();
        }



        private void textBox2_Leave(object sender, EventArgs e)
        {
            // TextBox2'den değeri alıyoruz
            if (int.TryParse(textBox2.Text, out int cikarilacakMiktar))
            {
                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // UPDATE SQL komutunu oluştur
                    string updateQuery = "UPDATE StokTablosu SET Sutun1 = Sutun1 - @CikarilacakMiktar WHERE ID = 1";

                    // SqlCommand nesnesini oluştur
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@CikarilacakMiktar", cikarilacakMiktar);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            GuncelleStokLabel(); // Stok miktarını güncelle
            textBox2.Clear(); // TextBox'ı temizle
        }


        private void textBox3_Leave(object sender, EventArgs e)
        {


            // TextBox'tan değeri alıyoruz
            if (int.TryParse(textBox3.Text, out int girilenMiktar))
            {

                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // UPDATE SQL komutunu oluştur
                    string updateQuery = "UPDATE StokTablosu SET Sutun2 = Sutun2 + @GirilenMiktar WHERE ID = 1";

                    // SqlCommand nesnesini oluştur
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@GirilenMiktar", girilenMiktar);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            GuncelleStokLabel();
            textBox3.Clear();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            // TextBox'tan değeri alıyoruz
            if (int.TryParse(textBox4.Text, out int girilenMiktar))
            {

                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // UPDATE SQL komutunu oluştur
                    string updateQuery = "UPDATE StokTablosu SET Sutun2 = Sutun2 - @GirilenMiktar WHERE ID = 1";

                    // SqlCommand nesnesini oluştur
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@GirilenMiktar", girilenMiktar);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            GuncelleStokLabel();
            textBox4.Clear();
        }

     

        private void textBox6_Leave(object sender, EventArgs e)
        {
            // TextBox'tan değeri alıyoruz
            if (int.TryParse(textBox6.Text, out int girilenMiktar))
            {

                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // UPDATE SQL komutunu oluştur
                    string updateQuery = "UPDATE StokTablosu SET Sutun3 = Sutun3 - @GirilenMiktar WHERE ID = 1";

                    // SqlCommand nesnesini oluştur
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@GirilenMiktar", girilenMiktar);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            GuncelleStokLabel();
            textBox6.Clear();
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            // TextBox'tan değeri alıyoruz
            if (int.TryParse(textBox7.Text, out int girilenMiktar))
            {

                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // UPDATE SQL komutunu oluştur
                    string updateQuery = "UPDATE StokTablosu SET Sutun4 = Sutun4 + @GirilenMiktar WHERE ID = 1";

                    // SqlCommand nesnesini oluştur
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@GirilenMiktar", girilenMiktar);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            GuncelleStokLabel();
            textBox7.Clear();
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            // TextBox'tan değeri alıyoruz
            if (int.TryParse(textBox8.Text, out int girilenMiktar))
            {

                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // UPDATE SQL komutunu oluştur
                    string updateQuery = "UPDATE StokTablosu SET Sutun4 = Sutun4 - @GirilenMiktar WHERE ID = 1";

                    // SqlCommand nesnesini oluştur
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@GirilenMiktar", girilenMiktar);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            GuncelleStokLabel();
            textBox8.Clear();
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            // TextBox'tan değeri alıyoruz
            if (int.TryParse(textBox9.Text, out int girilenMiktar))
            {

                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // UPDATE SQL komutunu oluştur
                    string updateQuery = "UPDATE StokTablosu SET Sutun5 = Sutun5 + @GirilenMiktar WHERE ID = 1";

                    // SqlCommand nesnesini oluştur
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@GirilenMiktar", girilenMiktar);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            GuncelleStokLabel();
            textBox9.Clear();
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            // TextBox'tan değeri alıyoruz
            if (int.TryParse(textBox10.Text, out int girilenMiktar))
            {

                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // UPDATE SQL komutunu oluştur
                    string updateQuery = "UPDATE StokTablosu SET Sutun5 = Sutun5 - @GirilenMiktar WHERE ID = 1";

                    // SqlCommand nesnesini oluştur
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@GirilenMiktar", girilenMiktar);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            GuncelleStokLabel();
            textBox10.Clear();
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            // TextBox'tan değeri alıyoruz
            if (int.TryParse(textBox11.Text, out int girilenMiktar))
            {

                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // UPDATE SQL komutunu oluştur
                    string updateQuery = "UPDATE StokTablosu SET Sutun6 = Sutun6 + @GirilenMiktar WHERE ID = 1";

                    // SqlCommand nesnesini oluştur
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@GirilenMiktar", girilenMiktar);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            GuncelleStokLabel();
            textBox11.Clear();
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            // TextBox'tan değeri alıyoruz
            if (int.TryParse(textBox12.Text, out int girilenMiktar))
            {

                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // UPDATE SQL komutunu oluştur
                    string updateQuery = "UPDATE StokTablosu SET Sutun6 = Sutun6 - @GirilenMiktar WHERE ID = 1";

                    // SqlCommand nesnesini oluştur
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@GirilenMiktar", girilenMiktar);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            GuncelleStokLabel();
            textBox12.Clear();
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            // TextBox'tan değeri alıyoruz
            if (int.TryParse(textBox5.Text, out int girilenMiktar))
            {

                try
                {
                    // Bağlantıyı aç
                    connection.Open();

                    // UPDATE SQL komutunu oluştur
                    string updateQuery = "UPDATE StokTablosu SET Sutun3 = Sutun3 + @GirilenMiktar WHERE ID = 1";

                    // SqlCommand nesnesini oluştur
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@GirilenMiktar", girilenMiktar);

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            GuncelleStokLabel();
            textBox5.Clear();
        }
    }
}
