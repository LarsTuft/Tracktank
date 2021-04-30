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
    public partial class IndexNew : UserControl
    {
        public IndexNew()
        {
            InitializeComponent();
        }

        private void listBoxArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAlbum.ClearSelected();
            listBoxTracks.ClearSelected();
            viewContent1.BringToFront();
            viewContent1.panelContent.Visible = true;
            viewContent1.labelTextBox1.Text = "Name:";
            viewContent1.labelTextBox2.Text = "Nationality:";
            viewContent1.labelTextBox3.Text = "Age:";
            viewContent1.labelRichTextBox.Text = "Bio:";
            viewContent1.labelTextBox4.Text = "";
            viewContent1.textBox4.Visible = false;
            viewContent1.pictureBox2.Visible = false;
            viewContent1.labelAlbumPicture.Visible = false;
            viewContent1.textBox3.Visible = true;
            viewContent1.richTextBox1.Visible = true;
            viewContent1.pictureBox2.Visible = true;
            viewContent1.pictureBox1.Visible = true;
            viewContent1.labelAlbumPicture.Visible = true;
            viewContent1.labelArtistPicture.Visible = true;

            String artistName = listBoxArtist.Text.ToString();

            string query = "SELECT * FROM artist WHERE name = '" + artistName + "';";
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
                        viewContent1.textBox1.Text = reader.GetString(1);
                        viewContent1.textBox2.Text = reader.GetString(2);
                        viewContent1.textBox3.Text = reader.GetInt32(3).ToString();
                        viewContent1.richTextBox1.Text = reader.GetString(4);
                        byte[] img = (byte[])(reader[7]);
                        if (img == null)
                        {
                            viewContent1.pictureBox1.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            viewContent1.pictureBox1.Image = Image.FromStream(ms);
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

        private void listBoxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxArtist.ClearSelected();
            listBoxTracks.ClearSelected();
            viewContent1.BringToFront();
            viewContent1.labelTextBox1.Text = "Title:";
            viewContent1.labelTextBox2.Text = "Recordlabel:";
            viewContent1.labelTextBox3.Text = "Number Of Tracks:";
            viewContent1.labelRichTextBox.Text = "Description:";
            viewContent1.labelTextBox4.Text = "";
            viewContent1.textBox4.Visible = false;
            viewContent1.textBox3.Visible = true;
            viewContent1.richTextBox1.Visible = true;
            viewContent1.pictureBox2.Visible = true;
            viewContent1.pictureBox1.Visible = true;
            viewContent1.labelAlbumPicture.Visible = true;
            viewContent1.labelArtistPicture.Visible = true;

            String albumName = listBoxAlbum.Text.ToString();

            string query = "SELECT * FROM album WHERE albumName = '" + albumName + "';";
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

                        viewContent1.textBox1.Text = reader.GetString(1);
                        viewContent1.textBox2.Text = reader.GetString(2);
                        viewContent1.textBox3.Text = reader.GetInt32(3).ToString();
                        viewContent1.richTextBox1.Text = reader.GetString(6);
                        byte[] img = (byte[])reader[5];
                        if (img == null)
                        {
                                viewContent1.pictureBox2.Image = null;
                        }
                        else
                        {
                                MemoryStream ms = new MemoryStream(img);
                                viewContent1.pictureBox2.Image = Image.FromStream(ms);
                        }
                        Application.DoEvents();
                    }
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }
        }

        private void listBoxTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAlbum.ClearSelected();
            listBoxArtist.ClearSelected();
            viewContent1.BringToFront();
            viewContent1.labelTextBox1.Text = "Title:";
            viewContent1.labelTextBox2.Text = "Length:";
            viewContent1.labelTextBox3.Text = "";
            viewContent1.labelTextBox4.Text = "";
            viewContent1.labelRichTextBox.Text = "";
            viewContent1.textBox3.Visible = false;
            viewContent1.richTextBox1.Visible = false;
            viewContent1.textBox4.Visible = false;
            viewContent1.pictureBox2.Visible = false;
            viewContent1.pictureBox1.Visible = false;
            viewContent1.labelAlbumPicture.Visible = false;
            viewContent1.labelArtistPicture.Visible = false;

            String trackName = listBoxTracks.Text.ToString();

            string query = "SELECT * FROM track WHERE trackName = '" + trackName + "';";
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

                        viewContent1.textBox1.Text = reader.GetString(1);
                        viewContent1.textBox2.Text = reader.GetString(2);
                        /*
                        byte[] img = (byte[])reader[5];
                        if (img == null)
                        {
                            viewContent1.pictureBox2.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            viewContent1.pictureBox2.Image = Image.FromStream(ms);
                        }
                        Application.DoEvents(); */
                    }
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }
        }

        private void IndexNew_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT name FROM artist;";
            string query2 = "SELECT albumName FROM album;";
            string query3 = "SELECT trackName FROM track;";

            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank; convert zero datetime=True";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);

            MySqlCommand commandDatabase1 = new MySqlCommand(query1, databaseConnection);
            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection);
            MySqlCommand commandDatabase3 = new MySqlCommand(query3, databaseConnection);
            commandDatabase1.CommandTimeout = 60;
            commandDatabase2.CommandTimeout = 60;
            commandDatabase3.CommandTimeout = 60;

            MySqlDataReader reader1;
            MySqlDataReader reader2;
            MySqlDataReader reader3;

            try
            {
                databaseConnection.Open();
                reader1 = commandDatabase1.ExecuteReader();

                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        for (int i = 0; i < reader1.FieldCount; i++)
                        {
                            listBoxArtist.Items.Add(reader1.GetString(i));

                        }
                    }
                }

                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }

            try
            {
                databaseConnection.Open();
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

                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }

            try
            {
                databaseConnection.Open();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
