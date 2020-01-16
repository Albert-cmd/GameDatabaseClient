using GamesAPiClient.Controller;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Net;

namespace GamesAPiClient.View
{
    public partial class GameRow : Form
    {

        Form1 form1 = null;
        game.Result gameresult = null;
        int idJuego = 0;
        public game.RootObject Basegame;

        public object Basegames { get; private set; }

        public GameRow(Form1 form1, game.Result gameresult, int idJuego)
        {
            this.form1 = form1;
            this.gameresult = gameresult;
            this.idJuego = idJuego;
            InitializeComponent();
            tituloJuego.BackColor = Color.Transparent;
            genreJuego.BackColor = Color.Transparent;
            triggers();

        }

        private void triggers() {

            this.MouseEnter += mouseenter;
            this.MouseLeave += mouseleave;
            this.Click += gameclick;

            tituloJuego.MouseEnter += mouseenter;
            tituloJuego.MouseLeave += mouseleave;
            tituloJuego.Click += gameclick;

            genreJuego.MouseEnter += mouseenter;
            genreJuego.MouseLeave += mouseleave;
            genreJuego.Click += gameclick;

            imagenJuego.MouseEnter += mouseenter;
            imagenJuego.MouseLeave += mouseleave;
            imagenJuego.Click += gameclick;

        }

        private void gameclick(object sender, EventArgs e)
        {

            form1.jocSeleccionatLabel.Text = gameresult.name.ToString();
            form1.genreJocSeleccionat.Text = gameresult.genres.First().name.ToString();

            Console.WriteLine("JUEGO SELECCIONADO ID: " + this.idJuego);

            IRestResponse response = Requester.requestMe("https://rawg-video-games-database.p.rapidapi.com/games/" + idJuego);
            Basegame = JsonConvert.DeserializeObject<game.RootObject>(response.Content);
            Console.WriteLine(response.Content);

            form1.descripcioJocSeleccionat.Text = filtrarHtml(WebUtility.HtmlDecode(Basegame.description));
            form1.puntuacioJocSeleccionat.Text = gameresult.rating.ToString() + " / 5";

        }

        private string filtrarHtml(string html) {

            var charsToRemove = new string[] { "<p>", "<br />", "</p>" };
            foreach (var c in charsToRemove)
            {
                html = html.Replace(c, "\n");
            }

            return html;

        }

        private void mouseenter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(192, 192, 192);
            this.Cursor = Cursors.Hand;
        }

        private void mouseleave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            this.Cursor = Cursors.Default;
        }

        private void TituloJuego_Click(object sender, EventArgs e)
        {

        }

        private void PuntuacioLabel_Click(object sender, EventArgs e)
        {

        }

        private void GameRow_Load(object sender, EventArgs e)
        {

        }
    }
}
