namespace TrackstankDesktop
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIndexTracks = new System.Windows.Forms.Label();
            this.labelIndexAlbums = new System.Windows.Forms.Label();
            this.labelIndexArtists = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.listBox3);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.labelIndexTracks);
            this.panel1.Controls.Add(this.labelIndexAlbums);
            this.panel1.Controls.Add(this.labelIndexArtists);
            this.panel1.Location = new System.Drawing.Point(183, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 527);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelIndexTracks
            // 
            this.labelIndexTracks.AutoSize = true;
            this.labelIndexTracks.BackColor = System.Drawing.Color.Transparent;
            this.labelIndexTracks.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexTracks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIndexTracks.Location = new System.Drawing.Point(418, 89);
            this.labelIndexTracks.Name = "labelIndexTracks";
            this.labelIndexTracks.Size = new System.Drawing.Size(46, 17);
            this.labelIndexTracks.TabIndex = 5;
            this.labelIndexTracks.Text = "Tracks";
            // 
            // labelIndexAlbums
            // 
            this.labelIndexAlbums.AutoSize = true;
            this.labelIndexAlbums.BackColor = System.Drawing.Color.Transparent;
            this.labelIndexAlbums.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexAlbums.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIndexAlbums.Location = new System.Drawing.Point(222, 89);
            this.labelIndexAlbums.Name = "labelIndexAlbums";
            this.labelIndexAlbums.Size = new System.Drawing.Size(54, 17);
            this.labelIndexAlbums.TabIndex = 4;
            this.labelIndexAlbums.Text = "Albums";
            // 
            // labelIndexArtists
            // 
            this.labelIndexArtists.AutoSize = true;
            this.labelIndexArtists.BackColor = System.Drawing.Color.Transparent;
            this.labelIndexArtists.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexArtists.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIndexArtists.Location = new System.Drawing.Point(27, 89);
            this.labelIndexArtists.Name = "labelIndexArtists";
            this.labelIndexArtists.Size = new System.Drawing.Size(47, 17);
            this.labelIndexArtists.TabIndex = 3;
            this.labelIndexArtists.Text = "Artists";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 394);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(225, 109);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(167, 394);
            this.listBox2.TabIndex = 7;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(421, 109);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(167, 394);
            this.listBox3.TabIndex = 8;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // Index
            // 
            

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelIndexTracks;
        private System.Windows.Forms.Label labelIndexAlbums;
        private System.Windows.Forms.Label labelIndexArtists;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private viewContent viewContent1;
    }
}
