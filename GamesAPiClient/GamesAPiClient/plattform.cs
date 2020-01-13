namespace GamesAPiClient
{
    public class plattform
    {
        public int id { get; set; }
        public string name { get; set; }

        public plattform(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}