using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventarisBarang
{
    public partial class Produk : Form
    {
        private string connectionString = "Server=localhost;username=root;password=;database=dbinventarisbarang";
        public Produk()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Produk_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblProduk";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataTable;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tblProduk (NamaProduk, Deskripsi, Harga) VALUES (@NamaProduk, @Deskripsi, @Harga)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NamaProduk", NamaProduk.Text);
                command.Parameters.AddWithValue("@Deskripsi", Deskripsi.Text);
                command.Parameters.AddWithValue("@Harga", decimal.Parse(Harga.Text));

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Produk berhasil ditambahkan!");

                // Refresh data
            }
        }
    }
}
