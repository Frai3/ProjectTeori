using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeori
{
    public partial class Ramen : Form
    {
        public Ramen()
        {
            InitializeComponent();
        }

        public static string warn { get; set; }
        public static int count { get; set; }
        public static string namaMakanan { get; set; }
        public static double harga { get; set; }
        public static double totalHarga { get; set; }
        public static double noInput { get; set; }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\ProjectTeori\\dbProject.accdb");

        int noMeja = HomeScreen.no;
        int id = HomeScreen.id;
        string tgl = DateTime.Now.ToString("dd/MM/yyyy");


        private void btnRamen1_Click(object sender, EventArgs e)
        {
            transaksi input = new transaksi();

            namaMakanan = "Legendary Chicken Ramen";
            harga = 35000;
            count = Convert.ToInt32(txtRamen1.Text);
            totalHarga = harga * count;

            input.insetDatabase(namaMakanan, harga, count, totalHarga, noMeja, tgl);
            if (transaksi.warn == "Y")
            {
                MessageBox.Show("Data Berhasil Ditambahkan");
            }
            else
            {
                MessageBox.Show("Gagal");
            }
        }

        private void btnRamen2_Click(object sender, EventArgs e)
        {
            transaksi input = new transaksi();
            namaMakanan = "Spicy Legendary Chicken Ramen";
            harga = 40000;
            count = Convert.ToInt32(txtRamen2.Text);
            totalHarga = harga * count;

            input.insetDatabase(namaMakanan, harga, count, totalHarga, noMeja, tgl);
            if (transaksi.warn == "Y")
            {
                MessageBox.Show("Data Berhasil Ditambahkan");
            }
            else
            {
                MessageBox.Show("Gagal");
            }
        }

        private void btnRamen3_Click(object sender, EventArgs e)
        {
            transaksi input = new transaksi();
            namaMakanan = "Volcano Ramen";
            harga = 42000;
            count = Convert.ToInt32(txtRamen3.Text);
            totalHarga = harga * count;
            input.insetDatabase(namaMakanan, harga, count, totalHarga, noMeja, tgl);
            if(transaksi.warn == "Y")
            {
                MessageBox.Show("Data Berhasil Ditambahkan");
            }
            else
            {
                MessageBox.Show("Gagal");
            }
        }

        private void btnRamen4_Click(object sender, EventArgs e)
        {
            transaksi input = new transaksi();
            namaMakanan = "Chicken Hot Ramen";
            harga = 45000;
            count = Convert.ToInt32(txtRamen4.Text);
            totalHarga = harga * count;
            input.insetDatabase(namaMakanan, harga, count, totalHarga, noMeja, tgl);
            if (transaksi.warn == "Y")
            {
                MessageBox.Show("Data Berhasil Ditambahkan");
            }
            else
            {
                MessageBox.Show("Gagal");
            }
        }
    }
}
