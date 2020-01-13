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

        public game.RootObject games;

        public BaseController()
        {
            getGames();
            //runGui();
        }

        private void getGames()
        {

            IRestResponse response = requestMe("https://rawg-video-games-database.p.rapidapi.com/games");
            games = JsonConvert.DeserializeObject<game.RootObject>(response.Content);

            foreach (game.Result gr in games.results) {
                Console.WriteLine(gr.name);
            }

        }

        public void runGui()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

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
