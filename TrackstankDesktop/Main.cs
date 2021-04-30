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


namespace TrackstankDesktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            customizeDesign();
        }

        public String username = "";
        public bool isSignedIn = false;

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            DropdownListPanel.Visible = false;
            welcome2.BringToFront();
        }

        private void DropdownMenuButton_Click(object sender, EventArgs e)
        {
            if (DropdownListPanel.Visible == false)
            {
                DropdownListPanel.Visible = true;
                DropdownListPanel.BringToFront();
            }
            else
                DropdownListPanel.Visible = false;
        }
        private void hideSubMenu()
        {
            DropdownListPanel.Visible = false;
        }


        private void SignUpButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            createUser2.BringToFront();
        }

        private void DropdownButton1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            welcome2.BringToFront();
        }

        private void DropdownButton2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            submitArtist1.BringToFront();
        }

        private void DropdownButton4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            addAlbum31.BringToFront();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profile1_Load(object sender, EventArgs e)
        {

        }

        private void submit1_Load(object sender, EventArgs e)
        {

        }

        private void welcome1_Load(object sender, EventArgs e)
        {

        }

        private void DropdownButton3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            addTrack1.BringToFront();
        }

        private void DropdownButton5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            indexNew1.BringToFront();
            indexNew1.viewContent1.SendToBack();
        }

        private void submitAlbum1_Load(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (panelSignIn.Visible == false)
            {
                panelSignIn.Visible = true;
                panelSignIn.BringToFront();
            }
            else
                panelSignIn.Visible = false;
        }

        public String name = "";
        public String email = "";
        public String password = "";
        private void button1_Click(object sender, EventArgs e)
        {
            String usernameTest = textBoxUsername.Text;
            String passwordTest = textBoxPassword.Text;

            string query = "SELECT name, email, password FROM registeredUser WHERE email = '" + usernameTest + "';";
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
                        name = reader.GetString(0);
                        email = reader.GetString(1);
                        password = reader.GetString(2);

                    }
                }
                else
                {
                    labelUsernameError.Text = "Email not found";
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Query error: " + ex.Message);

            }

            if (passwordTest == password && password != "")
            {
                username = name;
                MessageBox.Show("Successfully Signed in as: " + name);
                labelSignedInAs.Visible = true;
                labelSignedInAs.Text = "Signed In As: " + username;
                panelSignIn.Visible = false;
                if (name == "admin")
                {
                    buttonAdmin.Visible = true;
                }
            }
            else 
            {
                labelPasswordError.Text = "Wrong Password";
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            DropdownListPanel.Visible = false;
            hideSubMenu();
            admin1.BringToFront();
        }
    }
}
