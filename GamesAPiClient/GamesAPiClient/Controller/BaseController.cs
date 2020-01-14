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

        public BaseController()
        {
            getGames();
            runGui();
        }

        private void getGames()
        {

            IRestResponse response = requestMe("https://rawg-video-games-database.p.rapidapi.com/games");
            Basegames = JsonConvert.DeserializeObject<game.RootObject>(response.Content);

            gameList = Basegames.results;

        }

        public void runGui()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            f1 = new Form1();

            GameRow gr;
            int tag = 0;

            foreach (game.Result gameresult in gameList) {

                try
                {

                    Console.WriteLine(gameresult.name + " IMAGEN: " + gameresult.background_image + " GENRE: " + gameresult.genres.First().name +
                    " \nPUNTUACIÓN: " + gameresult.rating + " / 5");

                    gr = new GameRow();
                    gr.TopLevel = false;
                    gr.tituloJuego.Text = gameresult.name;
                    gr.genreJuego.Text = gameresult.genres.First().name;
                    gr.puntuacioLabel.Text = gameresult.rating.ToString() + " / 5";
                    gr.Tag = tag;
                    gr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    gr.Dock = DockStyle.Fill;
                    gr.Show();

                    f1.gamesList.Controls.Add(gr);

                    tag++;

                }
                catch (Exception ex) {
                    //
                }
            }

            tag = 0;
            RemoveEmptyRows();
            f1.Show();

            Application.Run(f1);

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

        public IRestResponse requestMe(String url)
        {

            IRestResponse response;
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "rawg-video-games-database.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "7de8eca4d1msh159330a1f5925e2p1d38e5jsn879fa8a3c4ff");
            response = client.Execute(request);
            return response;
            

        }


    }
}
