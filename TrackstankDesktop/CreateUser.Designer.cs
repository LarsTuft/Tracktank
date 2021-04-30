namespace TrackstankDesktop
{
    partial class CreateUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.labelCreateUserEmail = new System.Windows.Forms.Label();
            this.textBoxCreateUserEmail = new System.Windows.Forms.TextBox();
            this.labelCreateUserRepeatPassword = new System.Windows.Forms.Label();
            this.labelCreateUserChoosePassword = new System.Windows.Forms.Label();
            this.labelCreateUserAddress = new System.Windows.Forms.Label();
            this.labelCreateUserName = new System.Windows.Forms.Label();
            this.textBoxCreateUserRepeatPassword = new System.Windows.Forms.TextBox();
            this.textBoxCreateUserChoosePassword = new System.Windows.Forms.TextBox();
            this.textBoxCreateUserAddress = new System.Windows.Forms.TextBox();
            this.textBoxCreateUserName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.buttonCreateUser);
            this.panel1.Controls.Add(this.labelCreateUserEmail);
            this.panel1.Controls.Add(this.textBoxCreateUserEmail);
            this.panel1.Controls.Add(this.labelCreateUserRepeatPassword);
            this.panel1.Controls.Add(this.labelCreateUserChoosePassword);
            this.panel1.Controls.Add(this.labelCreateUserAddress);
            this.panel1.Controls.Add(this.labelCreateUserName);
            this.panel1.Controls.Add(this.textBoxCreateUserRepeatPassword);
            this.panel1.Controls.Add(this.textBoxCreateUserChoosePassword);
            this.panel1.Controls.Add(this.textBoxCreateUserAddress);
            this.panel1.Controls.Add(this.textBoxCreateUserName);
            this.panel1.Location = new System.Drawing.Point(364, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 410);
            this.panel1.TabIndex = 2;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.buttonCreateUser.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateUser.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateUser.Location = new System.Drawing.Point(66, 318);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(119, 31);
            this.buttonCreateUser.TabIndex = 10;
            this.buttonCreateUser.Text = "Create User";
            this.buttonCreateUser.UseVisualStyleBackColor = false;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // labelCreateUserEmail
            // 
            this.labelCreateUserEmail.AutoSize = true;
            this.labelCreateUserEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelCreateUserEmail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateUserEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCreateUserEmail.Location = new System.Drawing.Point(43, 157);
            this.labelCreateUserEmail.Name = "labelCreateUserEmail";
            this.labelCreateUserEmail.Size = new System.Drawing.Size(43, 17);
            this.labelCreateUserEmail.TabIndex = 9;
            this.labelCreateUserEmail.Text = "Email:";
            // 
            // textBoxCreateUserEmail
            // 
            this.textBoxCreateUserEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCreateUserEmail.Location = new System.Drawing.Point(46, 173);
            this.textBoxCreateUserEmail.Name = "textBoxCreateUserEmail";
            this.textBoxCreateUserEmail.Size = new System.Drawing.Size(161, 20);
            this.textBoxCreateUserEmail.TabIndex = 8;
            // 
            // labelCreateUserRepeatPassword
            // 
            this.labelCreateUserRepeatPassword.AutoSize = true;
            this.labelCreateUserRepeatPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelCreateUserRepeatPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateUserRepeatPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCreateUserRepeatPassword.Location = new System.Drawing.Point(43, 256);
            this.labelCreateUserRepeatPassword.Name = "labelCreateUserRepeatPassword";
            this.labelCreateUserRepeatPassword.Size = new System.Drawing.Size(114, 17);
            this.labelCreateUserRepeatPassword.TabIndex = 7;
            this.labelCreateUserRepeatPassword.Text = "Repeat Password:";
            // 
            // labelCreateUserChoosePassword
            // 
            this.labelCreateUserChoosePassword.AutoSize = true;
            this.labelCreateUserChoosePassword.BackColor = System.Drawing.Color.Transparent;
            this.labelCreateUserChoosePassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateUserChoosePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCreateUserChoosePassword.Location = new System.Drawing.Point(43, 207);
            this.labelCreateUserChoosePassword.Name = "labelCreateUserChoosePassword";
            this.labelCreateUserChoosePassword.Size = new System.Drawing.Size(118, 17);
            this.labelCreateUserChoosePassword.TabIndex = 6;
            this.labelCreateUserChoosePassword.Text = "Choose Password:";
            // 
            // labelCreateUserAddress
            // 
            this.labelCreateUserAddress.AutoSize = true;
            this.labelCreateUserAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelCreateUserAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateUserAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCreateUserAddress.Location = new System.Drawing.Point(43, 106);
            this.labelCreateUserAddress.Name = "labelCreateUserAddress";
            this.labelCreateUserAddress.Size = new System.Drawing.Size(60, 17);
            this.labelCreateUserAddress.TabIndex = 5;
            this.labelCreateUserAddress.Text = "Address:";
            // 
            // labelCreateUserName
            // 
            this.labelCreateUserName.AutoSize = true;
            this.labelCreateUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelCreateUserName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCreateUserName.Location = new System.Drawing.Point(43, 57);
            this.labelCreateUserName.Name = "labelCreateUserName";
            this.labelCreateUserName.Size = new System.Drawing.Size(47, 17);
            this.labelCreateUserName.TabIndex = 4;
            this.labelCreateUserName.Text = "Name:";
            // 
            // textBoxCreateUserRepeatPassword
            // 
            this.textBoxCreateUserRepeatPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCreateUserRepeatPassword.Location = new System.Drawing.Point(46, 272);
            this.textBoxCreateUserRepeatPassword.Name = "textBoxCreateUserRepeatPassword";
            this.textBoxCreateUserRepeatPassword.PasswordChar = '*';
            this.textBoxCreateUserRepeatPassword.Size = new System.Drawing.Size(161, 20);
            this.textBoxCreateUserRepeatPassword.TabIndex = 3;
            // 
            // textBoxCreateUserChoosePassword
            // 
            this.textBoxCreateUserChoosePassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCreateUserChoosePassword.Location = new System.Drawing.Point(46, 223);
            this.textBoxCreateUserChoosePassword.Name = "textBoxCreateUserChoosePassword";
            this.textBoxCreateUserChoosePassword.PasswordChar = '*';
            this.textBoxCreateUserChoosePassword.Size = new System.Drawing.Size(161, 20);
            this.textBoxCreateUserChoosePassword.TabIndex = 2;
            // 
            // textBoxCreateUserAddress
            // 
            this.textBoxCreateUserAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCreateUserAddress.Location = new System.Drawing.Point(46, 122);
            this.textBoxCreateUserAddress.Name = "textBoxCreateUserAddress";
            this.textBoxCreateUserAddress.Size = new System.Drawing.Size(161, 20);
            this.textBoxCreateUserAddress.TabIndex = 1;
            // 
            // textBoxCreateUserName
            // 
            this.textBoxCreateUserName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCreateUserName.Location = new System.Drawing.Point(46, 73);
            this.textBoxCreateUserName.Name = "textBoxCreateUserName";
            this.textBoxCreateUserName.Size = new System.Drawing.Size(161, 20);
            this.textBoxCreateUserName.TabIndex = 0;
            this.textBoxCreateUserName.TextChanged += new System.EventHandler(this.textBoxCreateUserName_TextChanged);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CreateUser";
            this.Size = new System.Drawing.Size(984, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Label labelCreateUserEmail;
        private System.Windows.Forms.TextBox textBoxCreateUserEmail;
        private System.Windows.Forms.Label labelCreateUserRepeatPassword;
        private System.Windows.Forms.Label labelCreateUserChoosePassword;
        private System.Windows.Forms.Label labelCreateUserAddress;
        private System.Windows.Forms.Label labelCreateUserName;
        private System.Windows.Forms.TextBox textBoxCreateUserRepeatPassword;
        private System.Windows.Forms.TextBox textBoxCreateUserChoosePassword;
        private System.Windows.Forms.TextBox textBoxCreateUserAddress;
        private System.Windows.Forms.TextBox textBoxCreateUserName;
    }
}
