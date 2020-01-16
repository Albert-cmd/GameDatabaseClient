using GamesAPiClient.View;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesAPiClient.Controller
{
    public class BaseController
    {

        public game.RootObject Basegames;
        public List<game.Result> gameList;
        public Form1 f1;
        public List<GameRow> gameRows = new List<GameRow>();

        public BaseController()
        {
            getGames();
            runGui();
        }

        private void triggers() {

            f1.redditLogo.MouseEnter += redditMosueEnter;
            f1.redditLogo.MouseLeave += redditMosueLeave;

            f1.videoLogo.MouseEnter += videoMosueEnter;
            f1.videoLogo.MouseLeave += videoMouseLeave;

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

        private void getGames()
        {

            IRestResponse response = Requester.requestMe("https://rawg-video-games-database.p.rapidapi.com/games");
            Basegames = JsonConvert.DeserializeObject<game.RootObject>(response.Content);

            gameList = Basegames.results;

        }

        public void runGui()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            f1 = new Form1();
            triggers();
            gamesListDisplay();

            Application.Run(f1);

        }

        private void gamesListDisplay() {

            int tag = 0;

            //f1.gamesList.RowCount = gameList.Count();
            //f1.gamesList.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            f1.gamesList.AutoScroll = false;

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

            tag = 0;
            RemoveEmptyRows();
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

        private void addGameResult(game.Result gameresult, int tag) {

            Console.WriteLine(gameresult.name + " IMAGEN: " + gameresult.background_image + " GENRE: " + gameresult.genres.First().name +
                    " \nPUNTUACIÓN: " + gameresult.rating + " / 5" + " TAG: " + tag + " ID: " + gameresult.id);

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

    }
}
