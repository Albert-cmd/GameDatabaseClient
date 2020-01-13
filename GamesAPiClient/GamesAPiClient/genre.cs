namespace GamesAPiClient
{
    public class genre
    {
        public int id { get; set; }
        public string name { get; set; }

        public genre(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}