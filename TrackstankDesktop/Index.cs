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
    public partial class Index : UserControl
    {

        public String selected = "";

        public Index()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.ClearSelected();
            listBox1.ClearSelected();
            selected = listBox3.Text.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.ClearSelected();
            listBox1.ClearSelected();
            selected = listBox2.Text.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.ClearSelected();
            listBox3.ClearSelected();
            selected = listBox1.Text.ToString();
            viewContent1.BringToFront();
            viewContent1.labelTextBox1.Text = "Name:";
            viewContent1.labelTextBox2.Text = "Nationality:";
            viewContent1.labelTextBox3.Text = "Age:";
            viewContent1.labelTextBox3.Text = "";
        }
    }
    /*
        private void Index_Load(object sender, EventArgs e)
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
                            listBox1.Items.Add(reader1.GetString(i));

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
                            listBox2.Items.Add(reader2.GetString(i));

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
                            listBox3.Items.Add(reader3.GetString(i));

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
    }*/
}
