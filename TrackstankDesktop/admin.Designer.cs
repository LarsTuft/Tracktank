namespace TrackstankDesktop
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxContent = new System.Windows.Forms.ListBox();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonArtist = new System.Windows.Forms.Button();
            this.buttonAlbum = new System.Windows.Forms.Button();
            this.buttonTrack = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonTrack);
            this.panel1.Controls.Add(this.buttonAlbum);
            this.panel1.Controls.Add(this.buttonArtist);
            this.panel1.Controls.Add(this.buttonUsers);
            this.panel1.Controls.Add(this.listBoxContent);
            this.panel1.Location = new System.Drawing.Point(183, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 527);
            this.panel1.TabIndex = 0;
            // 
            // listBoxContent
            // 
            this.listBoxContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxContent.DisplayMember = "text";
            this.listBoxContent.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxContent.FormattingEnabled = true;
            this.listBoxContent.ItemHeight = 17;
            this.listBoxContent.Location = new System.Drawing.Point(63, 157);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(211, 310);
            this.listBoxContent.TabIndex = 10;
            this.listBoxContent.SelectedIndexChanged += new System.EventHandler(this.listBoxContent_SelectedIndexChanged);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.buttonUsers.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUsers.Location = new System.Drawing.Point(63, 87);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(75, 29);
            this.buttonUsers.TabIndex = 11;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonArtist
            // 
            this.buttonArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.buttonArtist.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArtist.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArtist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonArtist.Location = new System.Drawing.Point(199, 87);
            this.buttonArtist.Name = "buttonArtist";
            this.buttonArtist.Size = new System.Drawing.Size(75, 29);
            this.buttonArtist.TabIndex = 12;
            this.buttonArtist.Text = "Artist";
            this.buttonArtist.UseVisualStyleBackColor = false;
            this.buttonArtist.Click += new System.EventHandler(this.buttonArtist_Click);
            // 
            // buttonAlbum
            // 
            this.buttonAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.buttonAlbum.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbum.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlbum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAlbum.Location = new System.Drawing.Point(345, 87);
            this.buttonAlbum.Name = "buttonAlbum";
            this.buttonAlbum.Size = new System.Drawing.Size(75, 29);
            this.buttonAlbum.TabIndex = 13;
            this.buttonAlbum.Text = "Album";
            this.buttonAlbum.UseVisualStyleBackColor = false;
            this.buttonAlbum.Click += new System.EventHandler(this.buttonAlbum_Click);
            // 
            // buttonTrack
            // 
            this.buttonTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.buttonTrack.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrack.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTrack.Location = new System.Drawing.Point(489, 87);
            this.buttonTrack.Name = "buttonTrack";
            this.buttonTrack.Size = new System.Drawing.Size(75, 29);
            this.buttonTrack.TabIndex = 14;
            this.buttonTrack.Text = "Track";
            this.buttonTrack.UseVisualStyleBackColor = false;
            this.buttonTrack.Click += new System.EventHandler(this.buttonTrack_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(345, 157);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 29);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(60, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Choose What To Delete:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(342, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Successfully Deleted";
            this.label1.Visible = false;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "admin";
            this.Size = new System.Drawing.Size(984, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxContent;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonTrack;
        private System.Windows.Forms.Button buttonAlbum;
        private System.Windows.Forms.Button buttonArtist;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
