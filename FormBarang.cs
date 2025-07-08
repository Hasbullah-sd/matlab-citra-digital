using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InventarisBarang
{
    public partial class FormBarang : Form
    {
        private string connectionString = "Server=localhost;username=root;password=;database=dbinventarisbarang";

        public FormBarang()
        {
            InitializeComponent();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblBarang";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tblBarang (NamaBarang, Kategori, Stok, Harga) VALUES (@NamaBarang, @Kategori, @Stok, @Harga)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NamaBarang", NamaBarang.Text);
                        command.Parameters.AddWithValue("@Kategori", kategori.Text);
                        command.Parameters.AddWithValue("@Stok", int.Parse(Stok.Text));
                        command.Parameters.AddWithValue("@Harga", decimal.Parse(Harga.Text));

                        command.ExecuteNonQuery();
                        MessageBox.Show("Barang berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string namaBarang = dataGridView1.SelectedRows[0].Cells["NamaBarang"].Value.ToString();

                string query = "DELETE FROM tblBarang WHERE NamaBarang = @NamaBarang";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NamaBarang", namaBarang);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Barang berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string namaBarang = dataGridView1.SelectedRows[0].Cells["NamaBarang"].Value.ToString();

                string query = "UPDATE tblBarang SET Kategori = @Kategori, Stok = @Stok, Harga = @Harga WHERE NamaBarang = @NamaBarang";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NamaBarang", namaBarang);
                            command.Parameters.AddWithValue("@Kategori", kategori.Text);
                            command.Parameters.AddWithValue("@Stok", int.Parse(Stok.Text));
                            command.Parameters.AddWithValue("@Harga", decimal.Parse(Harga.Text));

                            command.ExecuteNonQuery();
                            MessageBox.Show("Barang berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
