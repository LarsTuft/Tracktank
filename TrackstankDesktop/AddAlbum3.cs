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
using System.IO;

namespace TrackstankDesktop
{
    public partial class AddAlbum3 : UserControl
    {
        public AddAlbum3()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            string textToSearch = comboBox1.Text.ToLower();
            listBoxArtistList.Visible = false;
            listBoxArtistList.Items.Clear();
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
                            listBoxArtistList.Items.Add(reader.GetString(i));

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

            listBoxArtistList.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxArtistList_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxArtistList.Visible = false;
        }

        private void buttonChooseAlbumPicture_Click(object sender, EventArgs e)
        {
            string path = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path = dialog.FileName;
                    pictureBoxAlbum.ImageLocation = path;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSubmitAlbum_Click(object sender, EventArgs e)
        {
            string artistName = comboBox1.Text;
  
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
                    while (reader.Read()){ 

                        int artistID2 = reader.GetInt32(0);
                        label8.Text = artistID2.ToString();
                    }
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }
            
            listBoxArtistList.Visible = true;
            String artistID = label8.Text;
            string albumName = textBoxAlbumName.Text;
            int numbTracks = Int32.Parse(textBoxNumberOfTracks.Text);
            string recordLabel = textBoxRecordlabel.Text;
            string description = richTextBoxAlbumDesc.Text;
            DateTime releaseDate = dateTimePickerReleaseDate.Value;
            string release = releaseDate.Date.ToString("yyyy-MM-dd");
            MemoryStream ms1 = new MemoryStream();
            pictureBoxAlbum.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] albumImage = new byte[ms1.Length];
            ms1.Read(albumImage, 0, albumImage.Length);

            string query2 = "INSERT INTO album (albumID, albumName, recordLabel, numberOfTracks, releaseYear, albumPicture, description, artistID) VALUES (NULL, '"+ albumName + "', '" + recordLabel + "', '" + numbTracks + "', '" + release + "', '" + albumImage + "', '" + description + "', '" + artistID + "')";


            string MySqlConnectionString2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank;";

            MySqlConnection databaseConnection2 = new MySqlConnection(MySqlConnectionString2);

            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection2);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader2;

            try
            {

                databaseConnection2.Open();

                reader2 = commandDatabase2.ExecuteReader();

                MessageBox.Show("Successfully added album");

                databaseConnection2.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            } 
        } 

        private void textBoxNumberOfTracks_TextChanged(object sender, EventArgs e)
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

            if (!IsAllDigits(textBoxNumberOfTracks.Text)) 
            {
                textBoxNumberOfTracks.Text = "";
                label7.Text = "Please enter only digits";
            } else
            {
                label7.Text = "";
            }

        }
    }
}
