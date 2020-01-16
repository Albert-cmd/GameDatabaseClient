namespace GamesAPiClient
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.gamesList = new System.Windows.Forms.TableLayoutPanel();
            this.jocSeleccionatLabel = new System.Windows.Forms.Label();
            this.puntuacioJocSeleccionat = new System.Windows.Forms.Label();
            this.genreJocSeleccionat = new System.Windows.Forms.Label();
            this.descripcioJocSeleccionat = new System.Windows.Forms.RichTextBox();
            this.line = new System.Windows.Forms.Panel();
            this.videoLogo = new System.Windows.Forms.PictureBox();
            this.redditLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redditLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Database Client";
            // 
            // gamesList
            // 
            this.gamesList.AutoScroll = true;
            this.gamesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamesList.ColumnCount = 1;
            this.gamesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamesList.Location = new System.Drawing.Point(12, 70);
            this.gamesList.Name = "gamesList";
            this.gamesList.RowCount = 1;
            this.gamesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamesList.Size = new System.Drawing.Size(418, 492);
            this.gamesList.TabIndex = 1;
            // 
            // jocSeleccionatLabel
            // 
            this.jocSeleccionatLabel.AutoSize = true;
            this.jocSeleccionatLabel.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jocSeleccionatLabel.Location = new System.Drawing.Point(455, 70);
            this.jocSeleccionatLabel.Name = "jocSeleccionatLabel";
            this.jocSeleccionatLabel.Size = new System.Drawing.Size(280, 26);
            this.jocSeleccionatLabel.TabIndex = 2;
            this.jocSeleccionatLabel.Text = "NOM VIDEOJOC SEL.LECCIONAT";
            this.jocSeleccionatLabel.Click += new System.EventHandler(this.JocSeleccionatLabel_Click);
            // 
            // puntuacioJocSeleccionat
            // 
            this.puntuacioJocSeleccionat.AutoSize = true;
            this.puntuacioJocSeleccionat.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacioJocSeleccionat.ForeColor = System.Drawing.Color.DarkGreen;
            this.puntuacioJocSeleccionat.Location = new System.Drawing.Point(459, 118);
            this.puntuacioJocSeleccionat.Name = "puntuacioJocSeleccionat";
            this.puntuacioJocSeleccionat.Size = new System.Drawing.Size(70, 23);
            this.puntuacioJocSeleccionat.TabIndex = 3;
            this.puntuacioJocSeleccionat.Text = "4,50 / 5";
            this.puntuacioJocSeleccionat.Click += new System.EventHandler(this.PuntuacioJocSeleccionat_Click);
            // 
            // genreJocSeleccionat
            // 
            this.genreJocSeleccionat.AutoSize = true;
            this.genreJocSeleccionat.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreJocSeleccionat.Location = new System.Drawing.Point(460, 100);
            this.genreJocSeleccionat.Name = "genreJocSeleccionat";
            this.genreJocSeleccionat.Size = new System.Drawing.Size(57, 18);
            this.genreJocSeleccionat.TabIndex = 4;
            this.genreJocSeleccionat.Text = "Shooter";
            // 
            // descripcioJocSeleccionat
            // 
            this.descripcioJocSeleccionat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcioJocSeleccionat.Location = new System.Drawing.Point(460, 164);
            this.descripcioJocSeleccionat.Name = "descripcioJocSeleccionat";
            this.descripcioJocSeleccionat.ReadOnly = true;
            this.descripcioJocSeleccionat.Size = new System.Drawing.Size(578, 398);
            this.descripcioJocSeleccionat.TabIndex = 5;
            this.descripcioJocSeleccionat.Text = "";
            this.descripcioJocSeleccionat.TextChanged += new System.EventHandler(this.DescripcioJocSeleccionat_TextChanged);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.line.Location = new System.Drawing.Point(463, 143);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(577, 3);
            this.line.TabIndex = 6;
            // 
            // videoLogo
            // 
            this.videoLogo.Image = global::GamesAPiClient.Properties.Resources.video_camera_icon;
            this.videoLogo.InitialImage = global::GamesAPiClient.Properties.Resources._1024px_Reddit_logo_orange_svg;
            this.videoLogo.Location = new System.Drawing.Point(966, 103);
            this.videoLogo.Name = "videoLogo";
            this.videoLogo.Size = new System.Drawing.Size(34, 34);
            this.videoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.videoLogo.TabIndex = 8;
            this.videoLogo.TabStop = false;
            this.videoLogo.Click += new System.EventHandler(this.VideoLogo_Click);
            // 
            // redditLogo
            // 
            this.redditLogo.Image = global::GamesAPiClient.Properties.Resources._1024px_Reddit_logo_orange_svg;
            this.redditLogo.InitialImage = global::GamesAPiClient.Properties.Resources._1024px_Reddit_logo_orange_svg;
            this.redditLogo.Location = new System.Drawing.Point(1006, 103);
            this.redditLogo.Name = "redditLogo";
            this.redditLogo.Size = new System.Drawing.Size(34, 34);
            this.redditLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redditLogo.TabIndex = 7;
            this.redditLogo.TabStop = false;
            this.redditLogo.Click += new System.EventHandler(this.RedditLogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 574);
            this.Controls.Add(this.videoLogo);
            this.Controls.Add(this.redditLogo);
            this.Controls.Add(this.line);
            this.Controls.Add(this.descripcioJocSeleccionat);
            this.Controls.Add(this.genreJocSeleccionat);
            this.Controls.Add(this.puntuacioJocSeleccionat);
            this.Controls.Add(this.jocSeleccionatLabel);
            this.Controls.Add(this.gamesList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.videoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redditLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TableLayoutPanel gamesList;
        public System.Windows.Forms.Label genreJocSeleccionat;
        public System.Windows.Forms.Label jocSeleccionatLabel;
        public System.Windows.Forms.Label puntuacioJocSeleccionat;
        private System.Windows.Forms.Panel line;
        public System.Windows.Forms.RichTextBox descripcioJocSeleccionat;
        public System.Windows.Forms.PictureBox redditLogo;
        public System.Windows.Forms.PictureBox videoLogo;
    }
}

