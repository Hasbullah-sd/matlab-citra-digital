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
    public partial class Pembelian : Form
    {
        private string connectionString = "Server=localhost;username=root;password=;database=dbinventarisbarang";

        public Pembelian()
        {
            InitializeComponent();
            loadcombobox();
        }

        private void LoadDataPembelian()
        {
            string query = "SELECT p.IdPembelian, p.TanggalPembelian, b.NamaBarang, p.Jumlah " +
                           "FROM tblPembelian p INNER JOIN tblBarang b ON p.IdBarang = b.IdBarang";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void Pembelian_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tblPembelian (TanggalPembelian, IdBarang, Jumlah) VALUES (@Tanggal, @IdBarang, @Jumlah)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Tanggal", DateTime.Now);
                command.Parameters.AddWithValue("@IdBarang", Barang.SelectedValue);
                command.Parameters.AddWithValue("@Jumlah", int.Parse(Jumlah.Text));

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Pembelian berhasil ditambahkan!");

                // Refresh data
                LoadDataPembelian(); 
            }
        }

        public void loadcombobox()
        {
             string query = "SELECT IdBarang, NamaBarang FROM tblBarang";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
    adapter.Fill(dataTable);

                    Barang.DataSource = dataTable;
                    Barang.DisplayMember = "NamaBarang";
                    Barang.ValueMember = "IdBarang";
                }
            }
        }
    }
}
