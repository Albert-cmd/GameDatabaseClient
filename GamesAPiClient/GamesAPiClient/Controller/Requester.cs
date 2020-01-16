using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesAPiClient.Controller
{
    public class Requester
    {

        public static IRestResponse requestMe(String url)
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
