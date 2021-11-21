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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }
        public static int no { get; set; }
        public static DateTime tgl { get; set; }
        public static int id { get; set; }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\ProjectTeori\\dbProject.accdb");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            no = Convert.ToInt32(textBox1.Text);
            tgl = DateTime.Now;

            connection.Open();

            string query = "SELECT id FROM transaksi";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader.GetValue(0));
            }

            if(id.ToString()=="0")
            {
                MessageBox.Show("Hello");
            }
            else
            {
                for(int i = id+1; i > id; i--)
                {
                    id = i;
                }
            }  
            connection.Close();
        }


        private void btnFood_Click(object sender, EventArgs e)
        {
            Ramen ramen = new Ramen();
            ramen.Show();
        }
    }
}
