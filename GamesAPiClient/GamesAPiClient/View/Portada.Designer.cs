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
            this.titleLabel = new System.Windows.Forms.Label();
            this.gamesList = new System.Windows.Forms.TableLayoutPanel();
            this.jocSeleccionatLabel = new System.Windows.Forms.Label();
            this.puntuacioJocSeleccionat = new System.Windows.Forms.Label();
            this.genreJocSeleccionat = new System.Windows.Forms.Label();
            this.descripcioJocSeleccionat = new System.Windows.Forms.RichTextBox();
            this.line = new System.Windows.Forms.Panel();
            this.backgroundHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.detallsLabel = new System.Windows.Forms.Label();
            this.plataformaLabel = new System.Windows.Forms.Label();
            this.plataformesInput = new System.Windows.Forms.Label();
            this.usuariImg = new System.Windows.Forms.PictureBox();
            this.logoDiv = new System.Windows.Forms.PictureBox();
            this.videoLogo = new System.Windows.Forms.PictureBox();
            this.redditLogo = new System.Windows.Forms.PictureBox();
            this.usuariLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redditLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(147, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(203, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Game Database Client";
            // 
            // gamesList
            // 
            this.gamesList.AutoScroll = true;
            this.gamesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamesList.ColumnCount = 1;
            this.gamesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamesList.ForeColor = System.Drawing.Color.White;
            this.gamesList.Location = new System.Drawing.Point(12, 46);
            this.gamesList.Name = "gamesList";
            this.gamesList.RowCount = 1;
            this.gamesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamesList.Size = new System.Drawing.Size(418, 516);
            this.gamesList.TabIndex = 1;
            // 
            // jocSeleccionatLabel
            // 
            this.jocSeleccionatLabel.AutoSize = true;
            this.jocSeleccionatLabel.BackColor = System.Drawing.Color.Black;
            this.jocSeleccionatLabel.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jocSeleccionatLabel.ForeColor = System.Drawing.Color.White;
            this.jocSeleccionatLabel.Location = new System.Drawing.Point(455, 53);
            this.jocSeleccionatLabel.Name = "jocSeleccionatLabel";
            this.jocSeleccionatLabel.Size = new System.Drawing.Size(280, 26);
            this.jocSeleccionatLabel.TabIndex = 2;
            this.jocSeleccionatLabel.Text = "NOM VIDEOJOC SEL.LECCIONAT";
            this.jocSeleccionatLabel.Click += new System.EventHandler(this.JocSeleccionatLabel_Click);
            // 
            // puntuacioJocSeleccionat
            // 
            this.puntuacioJocSeleccionat.AutoSize = true;
            this.puntuacioJocSeleccionat.BackColor = System.Drawing.Color.Black;
            this.puntuacioJocSeleccionat.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacioJocSeleccionat.ForeColor = System.Drawing.Color.Lime;
            this.puntuacioJocSeleccionat.Location = new System.Drawing.Point(459, 101);
            this.puntuacioJocSeleccionat.Name = "puntuacioJocSeleccionat";
            this.puntuacioJocSeleccionat.Size = new System.Drawing.Size(70, 23);
            this.puntuacioJocSeleccionat.TabIndex = 3;
            this.puntuacioJocSeleccionat.Text = "4,50 / 5";
            this.puntuacioJocSeleccionat.Click += new System.EventHandler(this.PuntuacioJocSeleccionat_Click);
            // 
            // genreJocSeleccionat
            // 
            this.genreJocSeleccionat.AutoSize = true;
            this.genreJocSeleccionat.BackColor = System.Drawing.Color.Black;
            this.genreJocSeleccionat.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreJocSeleccionat.ForeColor = System.Drawing.Color.White;
            this.genreJocSeleccionat.Location = new System.Drawing.Point(460, 83);
            this.genreJocSeleccionat.Name = "genreJocSeleccionat";
            this.genreJocSeleccionat.Size = new System.Drawing.Size(57, 18);
            this.genreJocSeleccionat.TabIndex = 4;
            this.genreJocSeleccionat.Text = "Shooter";
            // 
            // descripcioJocSeleccionat
            // 
            this.descripcioJocSeleccionat.BackColor = System.Drawing.Color.Black;
            this.descripcioJocSeleccionat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcioJocSeleccionat.ForeColor = System.Drawing.Color.White;
            this.descripcioJocSeleccionat.Location = new System.Drawing.Point(450, 143);
            this.descripcioJocSeleccionat.Name = "descripcioJocSeleccionat";
            this.descripcioJocSeleccionat.ReadOnly = true;
            this.descripcioJocSeleccionat.Size = new System.Drawing.Size(606, 239);
            this.descripcioJocSeleccionat.TabIndex = 5;
            this.descripcioJocSeleccionat.Text = "";
            this.descripcioJocSeleccionat.TextChanged += new System.EventHandler(this.DescripcioJocSeleccionat_TextChanged);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.line.Location = new System.Drawing.Point(450, 127);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(607, 2);
            this.line.TabIndex = 6;
            // 
            // backgroundHeader
            // 
            this.backgroundHeader.BackColor = System.Drawing.Color.Black;
            this.backgroundHeader.Location = new System.Drawing.Point(450, 47);
            this.backgroundHeader.Name = "backgroundHeader";
            this.backgroundHeader.Size = new System.Drawing.Size(606, 79);
            this.backgroundHeader.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(450, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 2);
            this.panel1.TabIndex = 7;
            // 
            // detallsLabel
            // 
            this.detallsLabel.AutoSize = true;
            this.detallsLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detallsLabel.ForeColor = System.Drawing.Color.White;
            this.detallsLabel.Location = new System.Drawing.Point(450, 397);
            this.detallsLabel.Name = "detallsLabel";
            this.detallsLabel.Size = new System.Drawing.Size(188, 26);
            this.detallsLabel.TabIndex = 11;
            this.detallsLabel.Text = "Detalls del videojoc: ";
            // 
            // plataformaLabel
            // 
            this.plataformaLabel.AutoSize = true;
            this.plataformaLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plataformaLabel.ForeColor = System.Drawing.Color.White;
            this.plataformaLabel.Location = new System.Drawing.Point(451, 434);
            this.plataformaLabel.Name = "plataformaLabel";
            this.plataformaLabel.Size = new System.Drawing.Size(95, 19);
            this.plataformaLabel.TabIndex = 12;
            this.plataformaLabel.Text = "Plataformes:";
            // 
            // plataformesInput
            // 
            this.plataformesInput.AutoSize = true;
            this.plataformesInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plataformesInput.ForeColor = System.Drawing.Color.White;
            this.plataformesInput.Location = new System.Drawing.Point(552, 434);
            this.plataformesInput.Name = "plataformesInput";
            this.plataformesInput.Size = new System.Drawing.Size(415, 19);
            this.plataformesInput.TabIndex = 13;
            this.plataformesInput.Text = "STEAM, PC, PLAYSTATION 4, PLAYSTATION 3, PLAYSTATION 2";
            // 
            // usuariImg
            // 
            this.usuariImg.Image = global::GamesAPiClient.Properties.Resources.usuari;
            this.usuariImg.Location = new System.Drawing.Point(1027, 12);
            this.usuariImg.Name = "usuariImg";
            this.usuariImg.Size = new System.Drawing.Size(29, 28);
            this.usuariImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usuariImg.TabIndex = 14;
            this.usuariImg.TabStop = false;
            // 
            // logoDiv
            // 
            this.logoDiv.Image = global::GamesAPiClient.Properties.Resources.logorawg;
            this.logoDiv.Location = new System.Drawing.Point(12, 3);
            this.logoDiv.Name = "logoDiv";
            this.logoDiv.Size = new System.Drawing.Size(129, 37);
            this.logoDiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDiv.TabIndex = 10;
            this.logoDiv.TabStop = false;
            // 
            // videoLogo
            // 
            this.videoLogo.BackColor = System.Drawing.Color.Black;
            this.videoLogo.Image = global::GamesAPiClient.Properties.Resources.video_camera_icon;
            this.videoLogo.InitialImage = global::GamesAPiClient.Properties.Resources._1024px_Reddit_logo_orange_svg;
            this.videoLogo.Location = new System.Drawing.Point(966, 86);
            this.videoLogo.Name = "videoLogo";
            this.videoLogo.Size = new System.Drawing.Size(34, 34);
            this.videoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.videoLogo.TabIndex = 8;
            this.videoLogo.TabStop = false;
            this.videoLogo.Click += new System.EventHandler(this.VideoLogo_Click);
            // 
            // redditLogo
            // 
            this.redditLogo.BackColor = System.Drawing.Color.Black;
            this.redditLogo.Image = global::GamesAPiClient.Properties.Resources._1024px_Reddit_logo_orange_svg;
            this.redditLogo.InitialImage = global::GamesAPiClient.Properties.Resources._1024px_Reddit_logo_orange_svg;
            this.redditLogo.Location = new System.Drawing.Point(1006, 86);
            this.redditLogo.Name = "redditLogo";
            this.redditLogo.Size = new System.Drawing.Size(34, 34);
            this.redditLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redditLogo.TabIndex = 7;
            this.redditLogo.TabStop = false;
            this.redditLogo.Click += new System.EventHandler(this.RedditLogo_Click);
            // 
            // usuariLabel
            // 
            this.usuariLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usuariLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.usuariLabel.ForeColor = System.Drawing.Color.White;
            this.usuariLabel.Location = new System.Drawing.Point(894, 17);
            this.usuariLabel.Name = "usuariLabel";
            this.usuariLabel.Size = new System.Drawing.Size(136, 23);
            this.usuariLabel.TabIndex = 15;
            this.usuariLabel.Text = "USUARI";
            this.usuariLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1068, 574);
            this.Controls.Add(this.usuariLabel);
            this.Controls.Add(this.usuariImg);
            this.Controls.Add(this.plataformesInput);
            this.Controls.Add(this.plataformaLabel);
            this.Controls.Add(this.detallsLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoDiv);
            this.Controls.Add(this.line);
            this.Controls.Add(this.videoLogo);
            this.Controls.Add(this.redditLogo);
            this.Controls.Add(this.descripcioJocSeleccionat);
            this.Controls.Add(this.genreJocSeleccionat);
            this.Controls.Add(this.puntuacioJocSeleccionat);
            this.Controls.Add(this.jocSeleccionatLabel);
            this.Controls.Add(this.gamesList);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.backgroundHeader);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.usuariImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redditLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.TableLayoutPanel gamesList;
        public System.Windows.Forms.Label genreJocSeleccionat;
        public System.Windows.Forms.Label jocSeleccionatLabel;
        public System.Windows.Forms.Label puntuacioJocSeleccionat;
        private System.Windows.Forms.Panel line;
        public System.Windows.Forms.RichTextBox descripcioJocSeleccionat;
        public System.Windows.Forms.PictureBox redditLogo;
        public System.Windows.Forms.PictureBox videoLogo;
        private System.Windows.Forms.FlowLayoutPanel backgroundHeader;
        private System.Windows.Forms.PictureBox logoDiv;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label detallsLabel;
        private System.Windows.Forms.Label plataformaLabel;
        public System.Windows.Forms.Label plataformesInput;
        private System.Windows.Forms.PictureBox usuariImg;
        public System.Windows.Forms.Label usuariLabel;
    }
}

