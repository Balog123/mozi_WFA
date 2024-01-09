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
using MySql.Data.MySqlClient;

namespace mozi_WFA
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            LoadData();
            label1.Text = DateTime.Now.ToString("yyyy-MM-dd");
            LoadMovieTypes();
        }

        private void LoadData()
        {
            try
            {
                string connectionString = "Server=localhost;Database=mozi;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Mozi ORDER BY NEV";
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            var dataTable = new System.Data.DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable.DefaultView;
                        }
                    }
                    connection.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok betöltésekor: " + ex.Message);
            }
        }

        private void LoadMovieTypes()
        {
            try
            {
                string connectionString = "Server=localhost;Database=mozi;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT DISTINCT TIPUS FROM Mozi";
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string movieType = reader["TIPUS"].ToString();
                                comboBox1.Items.Add(movieType);
                            }
                        }
                    }
                    connection.Close();
                    if (comboBox1.Items.Count > 0)
                    {
                        comboBox1.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a mozi típusok betöltésekor: " + ex.Message);
            }
        }

        private void valamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilm filmWindow = new frmFilm();
            filmWindow.Show();
        }

        private void keresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilmLista filmWindow = new frmFilmLista();
            filmWindow.Show();
        }
    }
}
