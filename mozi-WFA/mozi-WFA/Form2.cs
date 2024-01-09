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
    public partial class frmFilm : Form
    {
        public event Action<string, string, string, string, string> DataTransferRequested;

        public frmFilm()
        {
            InitializeComponent();
            LoadDirectors();
        }

        private void LoadDirectors()
        {
            try
            {
                string connectionString = "Server=localhost;Database=mozi;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT DISTINCT NEV FROM Ember ORDER BY NEV ASC";
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string directorName = reader["NEV"].ToString();
                                rendezo.Items.Add(directorName);
                            }
                        }
                    }
                    connection.Close();
                    if (rendezo.Items.Count > 0)
                    {
                        rendezo.SelectedIndex = 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a rendezők betöltésekor: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFilmLista filmWindow = new frmFilmLista();
            filmWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cim = cimTextBox.Text;
            string hossz = hosszTextBox.Text;
            string mufaj = mufajTextBox.Text;
            string gyartasiev = gyartevTextBox.Text;
            string szarmazas = szarmazasTextBox.Text;
            string kivalasztottRendezo = rendezo.SelectedItem.ToString();

            if (gyartasiev.Length == 4 && int.TryParse(gyartasiev, out int ev))
            {
                if (!string.IsNullOrWhiteSpace(cim))
                {
                    try
                    {
                        string connectionString = "Server=localhost;Database=mozi;Uid=root;Pwd=;";
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            string directorIdQuery = $"SELECT EAZON FROM Ember WHERE NEV = '{kivalasztottRendezo}'";

                            using (MySqlCommand directorIdCommand = new MySqlCommand(directorIdQuery, connection))
                            {
                                int directorId = Convert.ToInt32(directorIdCommand.ExecuteScalar());

                                string query = $"INSERT INTO Film (CIM, HOSSZ, MUFAJ, GYART_EV, SZARMAZAS, RENDEZO) VALUES ('{cim}', '{hossz}', '{mufaj}', {ev}, '{szarmazas}', {directorId})";

                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.ExecuteNonQuery();

                                    string lastInsertedIdQuery = "SELECT LAST_INSERT_ID()";
                                    using (MySqlCommand lastIdCommand = new MySqlCommand(lastInsertedIdQuery, connection))
                                    {
                                        int lastInsertedId = Convert.ToInt32(lastIdCommand.ExecuteScalar());

                                        azonositoTextBox.Text = lastInsertedId.ToString();
                                    }
                                }
                            }

                            MessageBox.Show("Az adatok sikeresen hozzá lettek adva a Film táblához.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hiba történt az adatok hozzáadása közben: " + ex.Message);
                        MessageBox.Show($"Hiba történt az adatok hozzáadása közben: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("A cím mező kitöltése kötelező!");
                }
                DataTransferRequested?.Invoke(cim, hossz, mufaj, gyartasiev, szarmazas);
            }
            else
            {
                MessageBox.Show("Hibás gyártási év formátum. Kérlek, adj meg egy négy számjegyű évszámot.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan törölni szeretnéd a rekordot?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                string cim = cimTextBox.Text;
                string hossz = hosszTextBox.Text;
                string mufaj = mufajTextBox.Text;
                string gyartasiev = gyartevTextBox.Text;
                string szarmazas = szarmazasTextBox.Text;
                string kivalasztottRendezo = rendezo.SelectedItem.ToString();

                if (gyartasiev.Length == 4 && int.TryParse(gyartasiev, out int ev))
                {
                    try
                    {
                        string connectionString = "Server=localhost;Database=mozi;Uid=root;Pwd=;";
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            string directorIdQuery = $"SELECT EAZON FROM Ember WHERE NEV = '{kivalasztottRendezo}'";

                            using (MySqlCommand directorIdCommand = new MySqlCommand(directorIdQuery, connection))
                            {
                                int directorId = Convert.ToInt32(directorIdCommand.ExecuteScalar());

                                string deleteQuery = $"DELETE FROM Film WHERE CIM = '{cim}' AND HOSSZ = '{hossz}' AND MUFAJ = '{mufaj}' AND GYART_EV = {ev} AND SZARMAZAS = '{szarmazas}' AND RENDEZO = {directorId}";

                                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                                {
                                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        cimTextBox.Clear();
                                        hosszTextBox.Clear();
                                        mufajTextBox.Clear();
                                        gyartevTextBox.Clear();
                                        szarmazasTextBox.Clear();
                                        rendezo.SelectedIndex = -1;
                                        azonositoTextBox.Clear();
                                        MessageBox.Show("A rekord sikeresen törölve lett a Film táblából.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nincs találat a megadott rekordra a Film táblában.");
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hiba történt a rekord törlése közben: " + ex.Message);
                        MessageBox.Show($"Hiba történt a rekord törlése közben: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Hibás gyártási év formátum. Kérlek, adj meg egy négy számjegyű évszámot.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cimTextBox.Text = string.Empty;
            hosszTextBox.Text = string.Empty;
            mufajTextBox.Text = string.Empty;
            gyartevTextBox.Text = string.Empty;
            szarmazasTextBox.Text = string.Empty;
        }
    }
}
