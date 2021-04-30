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
    public partial class CreateUser : UserControl
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        public bool workingPassword = false;

        private string ValidatePassword
        {
            get
            {
                if (textBoxCreateUserChoosePassword.Text != textBoxCreateUserRepeatPassword.Text) {

                    MessageBox.Show("Passwords do not match!");
                    return null;

                } else if (textBoxCreateUserChoosePassword.Text.Length < 8) {

                    MessageBox.Show("Passwords must be at least 8 characters long!");
                    return null;

                } else {

                    return textBoxCreateUserChoosePassword.Text;
                }
            }
        }

        private void textBoxCreateUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            string name     = textBoxCreateUserName.Text;
            string address  = textBoxCreateUserAddress.Text;
            string email    = textBoxCreateUserEmail.Text;
            string password = ValidatePassword;

            string query    = "INSERT INTO registereduser(userID, NAME, adress, email, PASSWORD) VALUES (NULL,'" + name +"','" + address + "','" + email + "','" + password + "')";

            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tracktank;";

            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            if (password != null)
            {
                try
                {

                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Successfully added user");
                    databaseConnection.Close();
                    textBoxCreateUserAddress.Text = "";
                    textBoxCreateUserName.Text = "";
                    textBoxCreateUserEmail.Text = "";
                    textBoxCreateUserChoosePassword.Text = "";
                    textBoxCreateUserRepeatPassword.Text = "";

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Query error: " + ex.Message);

                }
            }
        }
    }
}
