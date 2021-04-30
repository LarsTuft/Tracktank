namespace TrackstankDesktop
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.labelSignedInAs = new System.Windows.Forms.Label();
            this.panelNonUser = new System.Windows.Forms.Panel();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.DropdownMenuPanel = new System.Windows.Forms.Panel();
            this.DropdownMenuButton = new System.Windows.Forms.Button();
            this.DropdownListPanel = new System.Windows.Forms.Panel();
            this.DropdownButton5 = new System.Windows.Forms.Button();
            this.DropdownButton3 = new System.Windows.Forms.Button();
            this.DropdownButton4 = new System.Windows.Forms.Button();
            this.DropdownButton2 = new System.Windows.Forms.Button();
            this.DropdownButton1 = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPasswordError = new System.Windows.Forms.Label();
            this.labelUsernameError = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.admin1 = new TrackstankDesktop.admin();
            this.addAlbum31 = new TrackstankDesktop.AddAlbum3();
            this.submitArtist1 = new TrackstankDesktop.SubmitArtist();
            this.createUser2 = new TrackstankDesktop.CreateUser();
            this.welcome2 = new TrackstankDesktop.Welcome();
            this.indexNew1 = new TrackstankDesktop.IndexNew();
            this.addTrack1 = new TrackstankDesktop.AddTrack();
            this.TopPanel.SuspendLayout();
            this.panelNonUser.SuspendLayout();
            this.DropdownMenuPanel.SuspendLayout();
            this.DropdownListPanel.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panelSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TopPanel.Controls.Add(this.buttonAdmin);
            this.TopPanel.Controls.Add(this.labelSignedInAs);
            this.TopPanel.Controls.Add(this.panelNonUser);
            this.TopPanel.Controls.Add(this.DropdownMenuPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(984, 50);
            this.TopPanel.TabIndex = 3;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint_1);
            // 
            // labelSignedInAs
            // 
            this.labelSignedInAs.AutoSize = true;
            this.labelSignedInAs.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignedInAs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSignedInAs.Location = new System.Drawing.Point(77, 18);
            this.labelSignedInAs.Name = "labelSignedInAs";
            this.labelSignedInAs.Size = new System.Drawing.Size(113, 17);
            this.labelSignedInAs.TabIndex = 8;
            this.labelSignedInAs.Text = "Signed In As: Test";
            this.labelSignedInAs.Visible = false;
            // 
            // panelNonUser
            // 
            this.panelNonUser.Controls.Add(this.SignUpButton);
            this.panelNonUser.Controls.Add(this.SignInButton);
            this.panelNonUser.Controls.Add(this.buttonSignOut);
            this.panelNonUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNonUser.Location = new System.Drawing.Point(709, 0);
            this.panelNonUser.Name = "panelNonUser";
            this.panelNonUser.Size = new System.Drawing.Size(275, 50);
            this.panelNonUser.TabIndex = 7;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.SignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignUpButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignUpButton.Location = new System.Drawing.Point(16, 10);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(120, 34);
            this.SignUpButton.TabIndex = 8;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.SignInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignInButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignInButton.Location = new System.Drawing.Point(143, 10);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(120, 34);
            this.SignInButton.TabIndex = 7;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(152, 14);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(75, 23);
            this.buttonSignOut.TabIndex = 9;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            // 
            // DropdownMenuPanel
            // 
            this.DropdownMenuPanel.Controls.Add(this.DropdownMenuButton);
            this.DropdownMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DropdownMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.DropdownMenuPanel.Name = "DropdownMenuPanel";
            this.DropdownMenuPanel.Size = new System.Drawing.Size(61, 50);
            this.DropdownMenuPanel.TabIndex = 6;
            // 
            // DropdownMenuButton
            // 
            this.DropdownMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.DropdownMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DropdownMenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropdownMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.DropdownMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropdownMenuButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DropdownMenuButton.Location = new System.Drawing.Point(0, 0);
            this.DropdownMenuButton.Name = "DropdownMenuButton";
            this.DropdownMenuButton.Size = new System.Drawing.Size(61, 50);
            this.DropdownMenuButton.TabIndex = 0;
            this.DropdownMenuButton.Text = "Menu";
            this.DropdownMenuButton.UseVisualStyleBackColor = false;
            this.DropdownMenuButton.Click += new System.EventHandler(this.DropdownMenuButton_Click);
            // 
            // DropdownListPanel
            // 
            this.DropdownListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.DropdownListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DropdownListPanel.Controls.Add(this.DropdownButton5);
            this.DropdownListPanel.Controls.Add(this.DropdownButton3);
            this.DropdownListPanel.Controls.Add(this.DropdownButton4);
            this.DropdownListPanel.Controls.Add(this.DropdownButton2);
            this.DropdownListPanel.Controls.Add(this.DropdownButton1);
            this.DropdownListPanel.Location = new System.Drawing.Point(0, 50);
            this.DropdownListPanel.Name = "DropdownListPanel";
            this.DropdownListPanel.Padding = new System.Windows.Forms.Padding(5);
            this.DropdownListPanel.Size = new System.Drawing.Size(160, 215);
            this.DropdownListPanel.TabIndex = 4;
            // 
            // DropdownButton5
            // 
            this.DropdownButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.DropdownButton5.FlatAppearance.BorderSize = 0;
            this.DropdownButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropdownButton5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DropdownButton5.Location = new System.Drawing.Point(5, 161);
            this.DropdownButton5.Name = "DropdownButton5";
            this.DropdownButton5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.DropdownButton5.Size = new System.Drawing.Size(148, 42);
            this.DropdownButton5.TabIndex = 4;
            this.DropdownButton5.Text = "Content Index";
            this.DropdownButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DropdownButton5.UseVisualStyleBackColor = true;
            this.DropdownButton5.Click += new System.EventHandler(this.DropdownButton5_Click);
            // 
            // DropdownButton3
            // 
            this.DropdownButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.DropdownButton3.FlatAppearance.BorderSize = 0;
            this.DropdownButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropdownButton3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DropdownButton3.Location = new System.Drawing.Point(5, 119);
            this.DropdownButton3.Name = "DropdownButton3";
            this.DropdownButton3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.DropdownButton3.Size = new System.Drawing.Size(148, 42);
            this.DropdownButton3.TabIndex = 3;
            this.DropdownButton3.Text = "Add Track";
            this.DropdownButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DropdownButton3.UseVisualStyleBackColor = true;
            this.DropdownButton3.Click += new System.EventHandler(this.DropdownButton3_Click);
            // 
            // DropdownButton4
            // 
            this.DropdownButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.DropdownButton4.FlatAppearance.BorderSize = 0;
            this.DropdownButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropdownButton4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DropdownButton4.Location = new System.Drawing.Point(5, 85);
            this.DropdownButton4.Name = "DropdownButton4";
            this.DropdownButton4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.DropdownButton4.Size = new System.Drawing.Size(148, 34);
            this.DropdownButton4.TabIndex = 2;
            this.DropdownButton4.Text = "Add Album";
            this.DropdownButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DropdownButton4.UseVisualStyleBackColor = true;
            this.DropdownButton4.Click += new System.EventHandler(this.DropdownButton4_Click);
            // 
            // DropdownButton2
            // 
            this.DropdownButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.DropdownButton2.FlatAppearance.BorderSize = 0;
            this.DropdownButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropdownButton2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DropdownButton2.Location = new System.Drawing.Point(5, 45);
            this.DropdownButton2.Name = "DropdownButton2";
            this.DropdownButton2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.DropdownButton2.Size = new System.Drawing.Size(148, 40);
            this.DropdownButton2.TabIndex = 1;
            this.DropdownButton2.Text = "Add Artist";
            this.DropdownButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DropdownButton2.UseVisualStyleBackColor = true;
            this.DropdownButton2.Click += new System.EventHandler(this.DropdownButton2_Click);
            // 
            // DropdownButton1
            // 
            this.DropdownButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.DropdownButton1.FlatAppearance.BorderSize = 0;
            this.DropdownButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropdownButton1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DropdownButton1.Location = new System.Drawing.Point(5, 5);
            this.DropdownButton1.Name = "DropdownButton1";
            this.DropdownButton1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.DropdownButton1.Size = new System.Drawing.Size(148, 40);
            this.DropdownButton1.TabIndex = 0;
            this.DropdownButton1.Text = "Home";
            this.DropdownButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DropdownButton1.UseVisualStyleBackColor = true;
            this.DropdownButton1.Click += new System.EventHandler(this.DropdownButton1_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panelChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChildForm.BackgroundImage")));
            this.panelChildForm.Controls.Add(this.admin1);
            this.panelChildForm.Controls.Add(this.panelSignIn);
            this.panelChildForm.Controls.Add(this.addAlbum31);
            this.panelChildForm.Controls.Add(this.submitArtist1);
            this.panelChildForm.Controls.Add(this.createUser2);
            this.panelChildForm.Controls.Add(this.welcome2);
            this.panelChildForm.Controls.Add(this.indexNew1);
            this.panelChildForm.Controls.Add(this.addTrack1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 50);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(984, 561);
            this.panelChildForm.TabIndex = 5;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // panelSignIn
            // 
            this.panelSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.panelSignIn.Controls.Add(this.button1);
            this.panelSignIn.Controls.Add(this.label2);
            this.panelSignIn.Controls.Add(this.label1);
            this.panelSignIn.Controls.Add(this.labelPasswordError);
            this.panelSignIn.Controls.Add(this.labelUsernameError);
            this.panelSignIn.Controls.Add(this.textBoxUsername);
            this.panelSignIn.Controls.Add(this.textBoxPassword);
            this.panelSignIn.Location = new System.Drawing.Point(820, 0);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(164, 215);
            this.panelSignIn.TabIndex = 8;
            this.panelSignIn.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(29)))), ((int)(((byte)(41)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(41, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // labelPasswordError
            // 
            this.labelPasswordError.AutoSize = true;
            this.labelPasswordError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordError.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPasswordError.Location = new System.Drawing.Point(16, 151);
            this.labelPasswordError.Name = "labelPasswordError";
            this.labelPasswordError.Size = new System.Drawing.Size(0, 14);
            this.labelPasswordError.TabIndex = 5;
            // 
            // labelUsernameError
            // 
            this.labelUsernameError.AutoSize = true;
            this.labelUsernameError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameError.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsernameError.Location = new System.Drawing.Point(13, 73);
            this.labelUsernameError.Name = "labelUsernameError";
            this.labelUsernameError.Size = new System.Drawing.Size(0, 14);
            this.labelUsernameError.TabIndex = 6;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(16, 46);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(136, 24);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(16, 120);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(136, 24);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.buttonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdmin.Location = new System.Drawing.Point(569, 10);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(120, 34);
            this.buttonAdmin.TabIndex = 9;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Visible = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // admin1
            // 
            this.admin1.Location = new System.Drawing.Point(0, 0);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(984, 561);
            this.admin1.TabIndex = 10;
            // 
            // addAlbum31
            // 
            this.addAlbum31.Location = new System.Drawing.Point(0, 0);
            this.addAlbum31.Name = "addAlbum31";
            this.addAlbum31.Size = new System.Drawing.Size(984, 561);
            this.addAlbum31.TabIndex = 6;
            // 
            // submitArtist1
            // 
            this.submitArtist1.Location = new System.Drawing.Point(0, 0);
            this.submitArtist1.Name = "submitArtist1";
            this.submitArtist1.Size = new System.Drawing.Size(984, 561);
            this.submitArtist1.TabIndex = 5;
            // 
            // createUser2
            // 
            this.createUser2.Location = new System.Drawing.Point(0, 0);
            this.createUser2.Name = "createUser2";
            this.createUser2.Size = new System.Drawing.Size(984, 561);
            this.createUser2.TabIndex = 3;
            // 
            // welcome2
            // 
            this.welcome2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcome2.BackgroundImage")));
            this.welcome2.Location = new System.Drawing.Point(0, -1);
            this.welcome2.Name = "welcome2";
            this.welcome2.Size = new System.Drawing.Size(984, 561);
            this.welcome2.TabIndex = 0;
            // 
            // indexNew1
            // 
            this.indexNew1.Location = new System.Drawing.Point(0, 0);
            this.indexNew1.Name = "indexNew1";
            this.indexNew1.Size = new System.Drawing.Size(984, 561);
            this.indexNew1.TabIndex = 9;
            // 
            // addTrack1
            // 
            this.addTrack1.Location = new System.Drawing.Point(0, 0);
            this.addTrack1.Name = "addTrack1";
            this.addTrack1.Size = new System.Drawing.Size(984, 561);
            this.addTrack1.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.DropdownListPanel);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackTank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panelNonUser.ResumeLayout(false);
            this.DropdownMenuPanel.ResumeLayout(false);
            this.DropdownListPanel.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel DropdownMenuPanel;
        private System.Windows.Forms.Button DropdownMenuButton;
        private System.Windows.Forms.Panel DropdownListPanel;
        private System.Windows.Forms.Button DropdownButton1;
        private System.Windows.Forms.Button DropdownButton4;
        private System.Windows.Forms.Button DropdownButton2;
        private System.Windows.Forms.Panel panelNonUser;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Panel panelChildForm;
        private Profile profile1;
        private Submit submit1;
        private Index index1;
        private CreateUser createUser1;
        private System.Windows.Forms.Button DropdownButton3;
        private Welcome welcome1;
        private Welcome welcome2;
        private CreateUser createUser2;
        private SubmitArtist submitArtist1;
        private System.Windows.Forms.Button DropdownButton5;
        private AddAlbum3 addAlbum31;
        private AddTrack addTrack1;
        private System.Windows.Forms.Panel panelSignIn;
        private System.Windows.Forms.Label labelUsernameError;
        private System.Windows.Forms.Label labelPasswordError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelSignedInAs;
        private IndexNew indexNew1;
        private System.Windows.Forms.Button buttonAdmin;
        private admin admin1;
    }
}

