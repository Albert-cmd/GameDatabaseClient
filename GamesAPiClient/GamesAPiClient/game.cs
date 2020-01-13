using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesAPiClient
{
    class game
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public DateTime released { get; set; }
        public string background_image { get; set; }
        public double rating { get; set; }
        public double rating_top { get; set; }
        public List<critic> critics {
            get {
                return this.critics;
            }
            set {
                critics = value;
            }
        }
        public int ratings_count { get; set; }
        public double metacritic { get; set; }
        public List<plattform> platforms {
            get {
                return this.platforms;
            }
            set {
                platforms = value;
            }
        }
        public List<genre> genres
        {
            get
            {
                return this.genres;
            }
            set
            {
                genres = value;
            }
        }
        public List<clip> clip
        {
            get
            {
                return this.clip;
            }
            set
            {
                clip = value;
            }
        }

        public game(int id, string slug, string name, DateTime released, string background_image, double rating, double rating_top, List<critic> critics, int ratings_count, double metacritic, List<plattform> platforms, List<genre> genres, List<clip> clip)
        {
            this.id = id;
            this.slug = slug;
            this.name = name;
            this.released = released;
            this.background_image = background_image;
            this.rating = rating;
            this.rating_top = rating_top;
            this.critics = critics;
            this.ratings_count = ratings_count;
            this.metacritic = metacritic;
            this.platforms = platforms;
            this.genres = genres;
            this.clip = clip;
        }



    }
}
