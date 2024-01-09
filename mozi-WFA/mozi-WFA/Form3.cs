using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mozi_WFA
{
    public partial class frmFilmLista : Form
    {
        public frmFilmLista()
        {
            InitializeComponent();
            LoadFilmData();
        }

        private void LoadFilmData()
        {
            try
            {
                string connectionString = "Server=localhost;Database=mozi;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT Film.CIM, Film.HOSSZ, Film.MUFAJ, Film.GYART_EV, Film.SZARMAZAS, Ember.NEV AS RENDEZO " +
                                   "FROM Film " +
                                   "JOIN Ember ON Film.RENDEZO = Ember.EAZON";

                    connection.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataTable.Columns["RENDEZO"].ColumnName = "RENDEZO";

                        dataGridView1.DataSource = dataTable.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok betöltésekor: " + ex.Message, "Hiba");
            }
        }

        private void szuresTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string szures = szuresTextBox.Text;

                string connectionString = "Server=localhost;Database=mozi;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = $"SELECT Film.CIM, Film.HOSSZ, Film.MUFAJ, Film.GYART_EV, Film.SZARMAZAS, Ember.NEV AS RENDEZO " +
                                   $"FROM Film " +
                                   $"JOIN Ember ON Film.RENDEZO = Ember.EAZON " +
                                   $"WHERE Film.CIM LIKE '%{szures}%'";

                    connection.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataTable.Columns["RENDEZO"].ColumnName = "RENDEZO";

                        dataGridView1.DataSource = dataTable.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok betöltésekor: " + ex.Message, "Hiba");
            }
        }
    }
}
