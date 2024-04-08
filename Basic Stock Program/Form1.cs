using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
            GuncelleStokLabel();
        }
        private void GuncelleStokLabel()
        {
            label1.Text = "Stok Miktarı: " + stokMiktari.ToString();
            label8.Text = "Stok Miktarı: " + stokmiktari1.ToString();
            label9.Text = "Stok Miktarı: " + stokmiktari2.ToString();
            label10.Text = "Stok Miktarı: " + stokmiktari3.ToString();
            label11.Text = "Stok Miktarı: " + stokmiktari4.ToString();
            label12.Text = "Stok Miktarı: " + stokmiktari5.ToString();

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            // TextBox'tan değeri alıyoruz
            if (int.TryParse(textBox1.Text, out int girilenMiktar))
            {
                // TextBox'tan çıkıldığında, bu değeri mevcut stok miktarına ekleyip güncelliyoruz
                stokMiktari += girilenMiktar;
                GuncelleStokLabel();
                textBox1.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            // TextBox2'den değeri alıyoruz
            if (int.TryParse(textBox2.Text, out int cikarilacakMiktar))
            {
                // TextBox2'den çıkıldığında, bu değeri mevcut stok miktarından çıkarıp güncelliyoruz
                stokMiktari -= cikarilacakMiktar;
                GuncelleStokLabel();
                textBox2.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int girilenMiktar))
            {
                // TextBox'tan çıkıldığında, bu değeri mevcut stok miktarına ekleyip güncelliyoruz
                stokmiktari1 += girilenMiktar;
                GuncelleStokLabel();
                textBox3.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            // TextBox2'den değeri alıyoruz
            if (int.TryParse(textBox4.Text, out int cikarilacakMiktar))
            {
                // TextBox2'den çıkıldığında, bu değeri mevcut stok miktarından çıkarıp güncelliyoruz
                stokmiktari1 -= cikarilacakMiktar;
                GuncelleStokLabel();
                textBox4.Text = "";
            }
        }

     

        private void textBox6_Leave(object sender, EventArgs e)
        {
            // TextBox2'den değeri alıyoruz
            if (int.TryParse(textBox6.Text, out int cikarilacakMiktar))
            {
                // TextBox2'den çıkıldığında, bu değeri mevcut stok miktarından çıkarıp güncelliyoruz
                stokmiktari2 -= cikarilacakMiktar;
                GuncelleStokLabel();
                textBox6.Text = "";
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBox7.Text, out int girilenMiktar))
            {
                // TextBox'tan çıkıldığında, bu değeri mevcut stok miktarına ekleyip güncelliyoruz
                stokmiktari3 += girilenMiktar;
                GuncelleStokLabel();
                textBox7.Text = "";
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            // TextBox2'den değeri alıyoruz
            if (int.TryParse(textBox8.Text, out int cikarilacakMiktar))
            {
                // TextBox2'den çıkıldığında, bu değeri mevcut stok miktarından çıkarıp güncelliyoruz
                stokmiktari3 -= cikarilacakMiktar;
                GuncelleStokLabel();
                textBox8.Text = "";
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBox9.Text, out int girilenMiktar))
            {
                // TextBox'tan çıkıldığında, bu değeri mevcut stok miktarına ekleyip güncelliyoruz
                stokmiktari4 += girilenMiktar;
                GuncelleStokLabel();
                textBox9.Text = "";
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            // TextBox2'den değeri alıyoruz
            if (int.TryParse(textBox10.Text, out int cikarilacakMiktar))
            {
                // TextBox2'den çıkıldığında, bu değeri mevcut stok miktarından çıkarıp güncelliyoruz
                stokmiktari4 -= cikarilacakMiktar;
                GuncelleStokLabel();
                textBox10.Text = "";
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBox11.Text, out int girilenMiktar))
            {
                // TextBox'tan çıkıldığında, bu değeri mevcut stok miktarına ekleyip güncelliyoruz
                stokmiktari5 += girilenMiktar;
                GuncelleStokLabel();
                textBox11.Text = "";
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            // TextBox2'den değeri alıyoruz
            if (int.TryParse(textBox12.Text, out int cikarilacakMiktar))
            {
                // TextBox2'den çıkıldığında, bu değeri mevcut stok miktarından çıkarıp güncelliyoruz
                stokmiktari5 -= cikarilacakMiktar;
                GuncelleStokLabel();
                textBox12.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBox5.Text, out int girilenMiktar))
            {
                // TextBox'tan çıkıldığında, bu değeri mevcut stok miktarına ekleyip güncelliyoruz
                stokmiktari2 += girilenMiktar;
                GuncelleStokLabel();
                textBox5.Text = "";
            }
        }
    }
}
