namespace GamesAPiClient
{
    public class critic
    {

        public int id { get; set; }
        public string title { get; set; }
        public int count { get; set; }
        public double percent { get; set; }

        public critic(int id, string title, int count, double percent)
        {
            this.id = id;
            this.title = title;
            this.count = count;
            this.percent = percent;
        }
    }
}