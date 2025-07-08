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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;username=root;password=;database=dbinventarisbarang";

            string username = Username.Text.Trim();
            string password = Password.Text.Trim(); // Simpan dalam plaintext untuk uji coba

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                LabelError.Text = "Username dan Password tidak boleh kosong!";
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query untuk memeriksa username dan password
                    string query = "SELECT Role FROM tblUsers WHERE Username = @username AND Password = @password";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString();
                            MessageBox.Show($"Login Berhasil! Role Anda: {role}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Buka form utama setelah login sukses
                            Form1 mainForm = new Form1(); // Ganti dengan form utama Anda
                            this.Hide();
                            mainForm.Show();
                        }
                        else
                        {
                            LabelError.Text = "Username atau Password salah!";
                        }
                    }
                }
            }
            catch (MySqlException mysqlEx)
            {   
                MessageBox.Show("MySQL Error: " + mysqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
