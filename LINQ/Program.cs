namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>
            { "Elden Ring", "Elder Scrolls", "Ancient Domains Of Mystery",
                "The Doors of Trithius", "Soulash 2",
                "Stoneshard", "Path of Achra",
                 "Tales of Maj'Eyal"
            };

            IEnumerable<string> longGameNames = games.OrderByDescending(x => x.Length);

            foreach (var game in longGameNames)
            {
                Console.WriteLine(game);
            }

        }
    }
}
