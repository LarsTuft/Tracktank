namespace TrackstankDesktop
{
    partial class IndexNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexNew));
            this.panelIndex = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxArtist = new System.Windows.Forms.ListBox();
            this.listBoxTracks = new System.Windows.Forms.ListBox();
            this.listBoxAlbum = new System.Windows.Forms.ListBox();
            this.viewContent1 = new TrackstankDesktop.viewContent();
            this.panelIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIndex
            // 
            this.panelIndex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIndex.BackgroundImage")));
            this.panelIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelIndex.Controls.Add(this.label3);
            this.panelIndex.Controls.Add(this.label2);
            this.panelIndex.Controls.Add(this.label1);
            this.panelIndex.Controls.Add(this.listBoxArtist);
            this.panelIndex.Controls.Add(this.listBoxTracks);
            this.panelIndex.Controls.Add(this.listBoxAlbum);
            this.panelIndex.Location = new System.Drawing.Point(183, 17);
            this.panelIndex.Name = "panelIndex";
            this.panelIndex.Size = new System.Drawing.Size(618, 527);
            this.panelIndex.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(419, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tracks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(224, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Album";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Artists";
            // 
            // listBoxArtist
            // 
            this.listBoxArtist.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxArtist.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxArtist.FormattingEnabled = true;
            this.listBoxArtist.ItemHeight = 14;
            this.listBoxArtist.Location = new System.Drawing.Point(33, 118);
            this.listBoxArtist.Name = "listBoxArtist";
            this.listBoxArtist.Size = new System.Drawing.Size(163, 382);
            this.listBoxArtist.TabIndex = 2;
            this.listBoxArtist.SelectedIndexChanged += new System.EventHandler(this.listBoxArtist_SelectedIndexChanged);
            // 
            // listBoxTracks
            // 
            this.listBoxTracks.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxTracks.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTracks.FormattingEnabled = true;
            this.listBoxTracks.ItemHeight = 14;
            this.listBoxTracks.Location = new System.Drawing.Point(422, 118);
            this.listBoxTracks.Name = "listBoxTracks";
            this.listBoxTracks.Size = new System.Drawing.Size(163, 382);
            this.listBoxTracks.TabIndex = 1;
            this.listBoxTracks.SelectedIndexChanged += new System.EventHandler(this.listBoxTracks_SelectedIndexChanged);
            // 
            // listBoxAlbum
            // 
            this.listBoxAlbum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxAlbum.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbum.FormattingEnabled = true;
            this.listBoxAlbum.ItemHeight = 14;
            this.listBoxAlbum.Location = new System.Drawing.Point(227, 118);
            this.listBoxAlbum.Name = "listBoxAlbum";
            this.listBoxAlbum.Size = new System.Drawing.Size(163, 382);
            this.listBoxAlbum.TabIndex = 0;
            this.listBoxAlbum.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbum_SelectedIndexChanged);
            // 
            // viewContent1
            // 
            this.viewContent1.Location = new System.Drawing.Point(0, 0);
            this.viewContent1.Name = "viewContent1";
            this.viewContent1.Size = new System.Drawing.Size(984, 561);
            this.viewContent1.TabIndex = 1;
            // 
            // IndexNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelIndex);
            this.Controls.Add(this.viewContent1);
            this.Name = "IndexNew";
            this.Size = new System.Drawing.Size(984, 561);
            this.Load += new System.EventHandler(this.IndexNew_Load);
            this.panelIndex.ResumeLayout(false);
            this.panelIndex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxAlbum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxArtist;
        private System.Windows.Forms.ListBox listBoxTracks;
        public System.Windows.Forms.Panel panelIndex;
        public viewContent viewContent1;
    }
}
