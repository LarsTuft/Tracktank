using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TrackstankDesktop
{
    public partial class AddTrack : UserControl
    {
        public AddTrack()
        {
            InitializeComponent();
        }

        private void comboBoxChooseArtist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxArtist.Visible = false;
        }

        private void listBoxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = listBoxAlbum.Text.ToString();
        }

        private void listBoxTracks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool IsAllDigits(string s)
            {
                foreach (char c in s)
                {
                    if (!char.IsDigit(c))
                        return false;
                }
                return true;
            }

            if (!IsAllDigits(textBoxTrackLenght.Text))
            {
                textBoxTrackLenght.Text = "";
                label10.Text = "Please enter only digits";
            }
            else if (textBoxTrackLenght.TextLength > 4)
            {
                textBoxTrackLenght.Text = "";
                label10.Text = "Max 4 digits";
            }
            else
            {
                label10.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string albumName = label6.Text;

            string query = "SELECT albumID FROM album WHERE albumName = '" + albumName + "';";
            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank; convert zero datetime=True";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int albumID2 = reader.GetInt32(0);
                        label7.Text = albumID2.ToString();
                    }
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }

            string trackName = textBoxTrackName.Text;
            string trackLength = textBoxTrackLenght.Text;
            int artistID = Int32.Parse(label2.Text);
            int albumID = Int32.Parse(label7.Text);
            DateTime releaseDate = dateTimePicker1.Value;
            string release = releaseDate.Date.ToString("yyyy-MM-dd");

            string query2 = "INSERT INTO track (trackID, trackName, trackLength, releaseYear, artistID, albumID) VALUES (NULL,'" + trackName + "','" + trackLength + "','" + release + "','" + artistID + "','" + albumID + "')";
            string query4 = "SELECT trackName FROM track WHERE trackName = '" + trackName + "';";

            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection);
            commandDatabase2.CommandTimeout = 60;
            MySqlDataReader reader2;
            MySqlCommand commandDatabase4 = new MySqlCommand(query4, databaseConnection);
            commandDatabase2.CommandTimeout = 60;
            MySqlDataReader reader4;

            try
            {

               databaseConnection.Open();
               reader4 = commandDatabase4.ExecuteReader();

               if (reader4.HasRows)
               {
                   label11.Text = "Track allready exist";
                   databaseConnection.Close();
                }
               else 
               {
                    databaseConnection.Close();
                    databaseConnection.Open();
                    reader2 = commandDatabase2.ExecuteReader();
                    label11.Text = "Track added successfully";
                    databaseConnection.Close();
               }
            }
            catch (Exception ex)
            {

                    MessageBox.Show("Query error: " + ex.Message);

            }


            string query3 = "SELECT trackName FROM track WHERE albumID = '" + albumID + "';";
            string MySqlConnectionString3 = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank; convert zero datetime=True";
            MySqlConnection databaseConnection3 = new MySqlConnection(MySqlConnectionString3);
            MySqlCommand commandDatabase3 = new MySqlCommand(query3, databaseConnection3);
            commandDatabase3.CommandTimeout = 60;
            MySqlDataReader reader3;

            try
            {
                databaseConnection3.Open();
                reader3 = commandDatabase3.ExecuteReader();

                if (reader3.HasRows)
                {
                    while (reader3.Read())
                    {
                        for (int i = 0; i < reader3.FieldCount; i++)
                        {
                            listBoxTracks.Items.Add(reader3.GetString(i));

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

        private void comboBoxChooseArtist_TextUpdate(object sender, EventArgs e)
        {
            string textToSearch = comboBoxChooseArtist.Text.ToLower();
            listBoxArtist.Visible = false;
            listBoxArtist.Items.Clear();
            if (String.IsNullOrEmpty(textToSearch))
                return;

            string query = "SELECT name FROM artist WHERE name LIKE '%" + textToSearch + "%';";

            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank;";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            listBoxArtist.Items.Add(reader.GetString(i));

                        }
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }

            listBoxArtist.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string artistName = comboBoxChooseArtist.Text;

            string query = "SELECT artistID FROM artist WHERE name = '" + artistName + "';";
            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank;";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int artistID2 = reader.GetInt32(0);
                        label2.Text = artistID2.ToString();
                    }
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }

            int numberToSearch = Int32.Parse(label2.Text);
            listBoxAlbum.Items.Clear();

            string query2 = "SELECT albumName FROM album WHERE artistID = '" + numberToSearch + "';";

            string MySqlConnectionString2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank;";
            MySqlConnection databaseConnection2 = new MySqlConnection(MySqlConnectionString2);
            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection2);
            commandDatabase2.CommandTimeout = 60;
            MySqlDataReader reader2;

            try
            {

                databaseConnection2.Open();
                reader2 = commandDatabase2.ExecuteReader();


                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        for (int i = 0; i < reader2.FieldCount; i++)
                        {
                            listBoxAlbum.Items.Add(reader2.GetString(i));

                        }
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection2.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
