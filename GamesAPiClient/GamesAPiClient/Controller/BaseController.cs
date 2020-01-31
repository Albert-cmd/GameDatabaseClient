using GamesAPiClient.Model;
using GamesAPiClient.View;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GamesAPiClient.game;

namespace GamesAPiClient.Controller
{
    public class BaseController
    {

        public user usuari;
        public game.RootObject Basegames;
        public List<Genre> genres = new List<Genre>();
        public List<game.Result> gameList;
        public Form1 f1;
        public List<GameRow> gameRows = new List<GameRow>();

        public int numJocs = 0;

        public LoginController lc;

        public BaseController(user u, LoginController lc)
        {
            this.usuari = u;
            this.lc = lc;
            //getGames();
            runGui();
        }

        public void runGui()
        {

            f1 = new Form1();
            triggers();
            getGames();
            //gamesListDisplay(true);

            fillUser();

            f1.numJocsLabel.Text = numJocs.ToString();

            // Application.Run(f1);

        }

        private void orderGames(string type) {

            switch (type) {
                case "ASC":
                    Basegames.results = Basegames.results.OrderBy(x => x.name).ToList();
                    break;
                case "DESC":
                    Basegames.results = Basegames.results.OrderByDescending(x => x.name).ToList();
                    break;
            }

            gameList = Basegames.results;

        } 

        private void triggers() {

            f1.redditLogo.MouseEnter += redditMosueEnter;
            f1.redditLogo.MouseLeave += redditMosueLeave;

            f1.videoLogo.MouseEnter += videoMosueEnter;
            f1.videoLogo.MouseLeave += videoMouseLeave;

            f1.genreDropdown.SelectedIndexChanged += genreChanged;

            f1.tancarSessioLabel.ForeColor = Color.FromArgb(80, 80, 80);

            f1.tancarSessioLabel.MouseEnter += tsenter;
            f1.tancarSessioLabel.MouseLeave += tsleave;
            f1.tancarSessioLabel.Click += tancarSessioClicked;

        }

        private void tsleave(object sender, EventArgs e)
        {

            f1.tancarSessioLabel.ForeColor = Color.FromArgb(80, 80, 80);

        }

        private void tsenter(object sender, EventArgs e)
        {

            f1.tancarSessioLabel.ForeColor = Color.FromArgb(255, 255, 255);

        }

        private void tancarSessioClicked(object sender, EventArgs e)
        {

            f1.Hide();
            f1.Close();
            lc = new LoginController();
            lc.bc = null;

        }

        private void genreChanged(object sender, EventArgs e)
        {

            try
            {
                Genre g = (Genre)f1.genreDropdown.SelectedItem;

                if (g.name == "Tots")
                {
                    getGames();
                }
                else {
                    getGamesByGenre(g);
                    Console.WriteLine(g.name);
                }
            }
            catch (Exception ex) {
                //

                getGames();
            }

        }

        private void videoMosueEnter(object sender, EventArgs e)
        {
            f1.Cursor = Cursors.Hand;
            f1.videoLogo.Image = GamesAPiClient.Properties.Resources.video_camera_icon_bw;
        }

        private void videoMouseLeave(object sender, EventArgs e)
        {
            f1.Cursor = Cursors.Default;
            f1.videoLogo.Image = GamesAPiClient.Properties.Resources.video_camera_icon;
        }

        private void redditMosueEnter(object sender, EventArgs e)
        {

            f1.Cursor = Cursors.Hand;
            f1.redditLogo.Image = GamesAPiClient.Properties.Resources._1024px_Reddit_logo_orange_bw;

        }

        private void redditMosueLeave(object sender, EventArgs e)
        {
            f1.Cursor = Cursors.Default;
            f1.redditLogo.Image = GamesAPiClient.Properties.Resources._1024px_Reddit_logo_orange_svg;
        }

        private void getGamesByGenre(Genre g) {

            try
            {

                closegamesList();

                IRestResponse response = Requester.requestMe("https://rawg-video-games-database.p.rapidapi.com/games");
                Basegames = JsonConvert.DeserializeObject<game.RootObject>(response.Content);

                gameList = null;
                gameList = Basegames.results.Where(x => x.genres.Any(y => y.name == g.name)).ToList();

                Basegames.results = gameList;

                numJocs = Basegames.results.Count();

                orderGames("ASC");
                gamesListDisplay(false);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void closegamesList() {

            foreach (GameRow gr in gameRows) {
                gr.Hide();
                gr.Close();
            }

            try
            {
                gameRows = new List<GameRow>();
            }
            catch (Exception ex) {
                //
            }

        }

        private void getGames()
        {

            try
            {

                closegamesList();

                IRestResponse response = Requester.requestMe("https://rawg-video-games-database.p.rapidapi.com/games");
                Basegames = JsonConvert.DeserializeObject<game.RootObject>(response.Content);

                gameList = Basegames.results;

                numJocs = Basegames.results.Count();

                orderGames("ASC");
                gamesListDisplay(true);
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }

        }

        private void fillUser() {

            try
            {
                f1.usuariLabel.Text = usuari.username;
            }
            catch (Exception ex) {
                //
            }

        }

        private void firstGameRow() {

            try
            {
                gameRows.First().gameFill();
            }
            catch (Exception ex) {
                //
            }

        }

        private void gamesListDisplay(bool updateGenres) {

            int tag = 0;

            //f1.gamesList.RowCount = gameList.Count();
            //f1.gamesList.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            try
            {

                f1.gamesList.AutoScroll = false;
                f1.numJocsLabel.Text = numJocs.ToString();
            }
            catch (Exception ex) {
                //f1 = new Form1();
                //runGui();
            }

            foreach (game.Result gameresult in gameList)
            {

                try
                {

                    addGameResult(gameresult, tag);

                }
                catch (Exception ex)
                {
                    //
                }

                tag++;
            }

            if (updateGenres) {
                addGenres();
                //f1.genreDropdown.SelectedIndex = 0;
            }

            tag = 0;

            RemoveEmptyRows();
            firstGameRow();
            f1.Show();

            TableLayoutRowStyleCollection styles =
            f1.gamesList.RowStyles;
            foreach (RowStyle style in styles)
            {
                // Set the row height to 20 pixels.
                style.SizeType = SizeType.Absolute;
                style.Height = 100;
            }

            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            f1.gamesList.Padding = new Padding(0, 0, vertScrollWidth, 0);

            f1.gamesList.AutoScroll = true;

        }

        private void addGenres() {

            try
            {

                f1.genreDropdown.Items.Clear();

                Genre all = new Genre();
                all.name = "Tots";
                all.id = 9999;

                f1.genreDropdown.Items.Add(all);

                foreach (game.Result gr in gameList)
                {
                    genres.Add(gr.genres.First());
                }

                //genres = genres.Distinct().ToList();
                genres = genres.GroupBy(x => x.name).Select(x => x.First()).ToList();
                foreach (Genre g in genres)
                {
                    f1.genreDropdown.Items.Add(g);
                }
            }
            catch (Exception ex) {
                //
            }

        }

        private void addGameResult(game.Result gameresult, int tag) {

            /*Console.WriteLine(gameresult.name + " IMAGEN: " + gameresult.background_image + " GENRE: " + gameresult.genres.First().name +
                    " \nPUNTUACIÓN: " + gameresult.rating + " / 5" + " TAG: " + tag + " ID: " + gameresult.id + "\nPlatforms: ");*/


            /*foreach (Platform p in gameresult.platforms) {
                Console.WriteLine(p.platform.name);
            }*/

            GameRow gr = new GameRow(this.f1, gameresult, gameresult.id);
            gr.TopLevel = false;
            gr.tituloJuego.Text = gameresult.name;
            gr.genreJuego.Text = gameresult.genres.First().name;
            gr.puntuacioLabel.Text = gameresult.rating.ToString() + " / 5";
            gr.imagenJuego.ImageLocation = gameresult.background_image;
            gr.imagenJuego.SizeMode = PictureBoxSizeMode.Zoom;
            gr.Tag = tag;

            gr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gr.Dock = DockStyle.Fill;
            //gr.AutoSize = true;

            gr.Show();
            gameRows.Add(gr);

            f1.gamesList.Controls.Add(gr);

        }

        private void RemoveEmptyRows()
        {
            try
            {
                for (int row = f1.gamesList.RowCount - 1; row >= 0; row--)
                {
                    bool hasControl = false;
                    for (int col = 0; col < f1.gamesList.ColumnCount; col++)
                    {
                        if (f1.gamesList.GetControlFromPosition(col, row) != null)
                        {
                            hasControl = true;
                            break;
                        }
                    }

                    if (!hasControl)
                    {
                        f1.gamesList.RowStyles.RemoveAt(row);
                        f1.gamesList.RowCount--;
                    }
                }
            }
            catch (Exception ex) {
                //
            }
        }

    }
}
