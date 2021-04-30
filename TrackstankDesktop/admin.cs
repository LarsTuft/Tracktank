using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrackstankDesktop
{
    public partial class admin : UserControl
    {
        public admin()
        {
            InitializeComponent();
        }

        public String table = "";
        public String parameter = "";

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            string query = "SELECT name FROM registeredUser;";
            listBoxContent.Items.Clear();

            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank; convert zero datetime=True";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                table = "registeredUser";
                parameter = "name";

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            listBoxContent.Items.Add(reader.GetString(i));

                        }
                    }
                }

                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }
        }

        private void buttonArtist_Click(object sender, EventArgs e)
        {
            string query = "SELECT name FROM artist;";
            listBoxContent.Items.Clear();

            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank; convert zero datetime=True";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                table = "artist";
                parameter = "name";

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            listBoxContent.Items.Add(reader.GetString(i));

                        }
                    }
                }

                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }
        }

        private void buttonAlbum_Click(object sender, EventArgs e)
        {
            string query = "SELECT albumName FROM album;";
            listBoxContent.Items.Clear();

            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank; convert zero datetime=True";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                table = "album";
                parameter = "albumName";

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            listBoxContent.Items.Add(reader.GetString(i));

                        }
                    }
                }

                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }
        }

        private void buttonTrack_Click(object sender, EventArgs e)
        {
            string query = "SELECT trackName FROM track;";
            listBoxContent.Items.Clear();

            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank; convert zero datetime=True";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                table = "track";
                parameter = "TrackName";

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            listBoxContent.Items.Add(reader.GetString(i));

                        }
                    }
                }

                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            String choosen = listBoxContent.Text.ToString();
            string query = "DELETE FROM " + table + " WHERE " + parameter + " = '" + choosen +"';";

            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank; convert zero datetime=True";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                label1.Visible = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }
        }

        private void listBoxContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
