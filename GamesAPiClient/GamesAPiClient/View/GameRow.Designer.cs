namespace GamesAPiClient.View
{
    partial class GameRow
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
            this.tituloJuego = new System.Windows.Forms.Label();
            this.genreJuego = new System.Windows.Forms.Label();
            this.puntuacioLabel = new System.Windows.Forms.Label();
            this.imagenJuego = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloJuego
            // 
            this.tituloJuego.AutoSize = true;
            this.tituloJuego.BackColor = System.Drawing.Color.Transparent;
            this.tituloJuego.Font = new System.Drawing.Font("Calibri Light", 20.25F);
            this.tituloJuego.Location = new System.Drawing.Point(83, 12);
            this.tituloJuego.Name = "tituloJuego";
            this.tituloJuego.Size = new System.Drawing.Size(99, 33);
            this.tituloJuego.TabIndex = 1;
            this.tituloJuego.Text = "Portal 2";
            // 
            // genreJuego
            // 
            this.genreJuego.AutoSize = true;
            this.genreJuego.BackColor = System.Drawing.Color.Transparent;
            this.genreJuego.Font = new System.Drawing.Font("Calibri Light", 16.25F);
            this.genreJuego.Location = new System.Drawing.Point(84, 54);
            this.genreJuego.Name = "genreJuego";
            this.genreJuego.Size = new System.Drawing.Size(81, 27);
            this.genreJuego.TabIndex = 2;
            this.genreJuego.Text = "Shooter";
            // 
            // puntuacioLabel
            // 
            this.puntuacioLabel.AutoSize = true;
            this.puntuacioLabel.BackColor = System.Drawing.Color.Transparent;
            this.puntuacioLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacioLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.puntuacioLabel.Location = new System.Drawing.Point(264, 54);
            this.puntuacioLabel.Name = "puntuacioLabel";
            this.puntuacioLabel.Size = new System.Drawing.Size(86, 29);
            this.puntuacioLabel.TabIndex = 3;
            this.puntuacioLabel.Text = "5.00 / 5";
            this.puntuacioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.puntuacioLabel.Click += new System.EventHandler(this.PuntuacioLabel_Click);
            // 
            // imagenJuego
            // 
            this.imagenJuego.Location = new System.Drawing.Point(0, -4);
            this.imagenJuego.Name = "imagenJuego";
            this.imagenJuego.Size = new System.Drawing.Size(78, 108);
            this.imagenJuego.TabIndex = 0;
            this.imagenJuego.TabStop = false;
            // 
            // GameRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 102);
            this.Controls.Add(this.puntuacioLabel);
            this.Controls.Add(this.genreJuego);
            this.Controls.Add(this.tituloJuego);
            this.Controls.Add(this.imagenJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameRow";
            this.Text = "GameRow";
            this.Load += new System.EventHandler(this.GameRow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenJuego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label puntuacioLabel;
        public System.Windows.Forms.Label tituloJuego;
        public System.Windows.Forms.Label genreJuego;
        public System.Windows.Forms.PictureBox imagenJuego;
    }
}