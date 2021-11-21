using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTeori
{
    class transaksi
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\ProjectTeori\\dbProject.accdb");

        public static string warn { get; set; }

        int id = HomeScreen.id;
        int noInput;
        public void insetDatabase(string menu, double harga, int jumlah, double totalHarga, int noMeja, string tanggal)
        {
            connection.Open();

            string query = "SELECT * FROM transaksi WHERE noMeja = @noMeja";
            OleDbCommand command = new OleDbCommand(query, connection);

            command.Parameters.AddWithValue("@noMeja", noMeja);
            OleDbDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                noInput = Convert.ToInt32(dataReader.GetValue(5));
            }


            if (noMeja == noInput && tanggal == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                
            }
            else
            {
                string queryRebus = "INSERT INTO transaksi (id, menu, harga, jumlah, totalHarga, noMeja, tanggal) VALUES (@id, @namaMakanan, @harga, @count, @totalHarga, @noMeja, @tgl)";
                OleDbCommand commandRebus = new OleDbCommand(queryRebus, connection);

                commandRebus.Parameters.AddWithValue("@id", id);
                commandRebus.Parameters.AddWithValue("@namaMakanan", menu);
                commandRebus.Parameters.AddWithValue("@harga", harga);
                commandRebus.Parameters.AddWithValue("@count", jumlah);
                commandRebus.Parameters.AddWithValue("@totalHarga", totalHarga);
                commandRebus.Parameters.AddWithValue("@noMeja", noMeja);
                commandRebus.Parameters.AddWithValue("@tgl", tanggal);

                commandRebus.ExecuteNonQuery();

            }
            warn = "Y";
            connection.Close();
        }
    }
}
