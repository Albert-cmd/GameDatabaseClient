using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesAPiClient
{
    class PruebaRAWG
    {

        public void pruebaservidor() {



            var client = new RestClient("https://rawg-video-games-database.p.rapidapi.com/games");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "rawg-video-games-database.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "8ada5299e5mshe204215dbe95de9p184833jsn0876404865e4");
            IRestResponse response = client.Execute(request);



        }


    }
}
