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
using System.Reflection;
using static GamesAPiClient.game;

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

            gameFill();

        }

        public void gameFill() {

            // EVITA RESET DEL SCROLL DE LA LLISTA (A DALT DEL TOT) QUAN ES FA CLICK EN QUALSEVOL DELS ELEMENTS
            form1.gamesList.Focus();

            form1.jocSeleccionatLabel.Text = gameresult.name.ToString();
            form1.genreJocSeleccionat.Text = gameresult.genres.First().name.ToString();

            Console.WriteLine("JUEGO SELECCIONADO ID: " + this.idJuego);

            IRestResponse response = Requester.requestMe("https://rawg-video-games-database.p.rapidapi.com/games/" + idJuego);
            Basegame = JsonConvert.DeserializeObject<game.RootObject>(response.Content);
            //Console.WriteLine(response.Content);

            redditLink();
            videoLink();

            form1.descripcioJocSeleccionat.Text = filtrarHtml(WebUtility.HtmlDecode(Basegame.description));
            form1.puntuacioJocSeleccionat.Text = gameresult.rating.ToString() + " / 5";

            string plataformes = "";

            int num = 0;

            foreach (Platform p in gameresult.platforms)
            {
                if (num <= 6)
                {
                    plataformes += " | " + p.platform.name;
                }
                num++;
            }

            num = 0;

            form1.plataformesInput.Text = plataformes;

        }

        private void videoLink() {

            removeEvents(form1.videoLogo);

            if (!gameresult.clip.clip.Equals(""))
            {
                form1.videoLogo.Visible = true;
                form1.videoLogo.Enabled = true;
                form1.videoLogo.Image = GamesAPiClient.Properties.Resources.video_camera_icon;
                form1.videoLogo.Click += videoClick;
            }
            else {
                form1.videoLogo.Image = GamesAPiClient.Properties.Resources.video_camera_icon_bw;
                form1.videoLogo.Enabled = false;
            }

        }

        private void videoClick(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(gameresult.clip.clip);

        }

        private void redditLink() {

            //Console.WriteLine("REDDIT URL: " + Basegame.reddit_url);

            // REMOVE ALL EVENTS FIRST
            removeEvents(form1.redditLogo);

            if (!Basegame.reddit_url.Equals(""))
            {
                form1.redditLogo.Visible = true;
                form1.redditLogo.Enabled = true;
                form1.redditLogo.Image = GamesAPiClient.Properties.Resources._1024px_Reddit_logo_orange_svg;
                form1.redditLogo.Click += redditClick;
            }
            else {
                form1.redditLogo.Image = GamesAPiClient.Properties.Resources._1024px_Reddit_logo_orange_bw;
                form1.redditLogo.Enabled = false;
            }

        }

        private void removeEvents(Object o) {

            FieldInfo f1 = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(o);
            PropertyInfo pi = o.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(o, null);
            list.RemoveHandler(obj, list[obj]);

        }

        private void redditClick(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(Basegame.reddit_url);

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
            this.BackColor = Color.FromArgb(64,64,64);
            this.Cursor = Cursors.Hand;
        }

        private void mouseleave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(35, 35, 35);
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
