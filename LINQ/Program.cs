namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> vGames = new List<string>

            {
                "Elden Ring",
                "League of Legends",
                "Overwatch",
                "CSGO",
                "Far Cry",
                "Assassins Creed",
                "Mario World",
                "Mario Kart",
                "Forza Motorsports"
            };
            var order = vGames.OrderBy(x => x.Length).ToList();


            foreach(var game in order) 
            {
                Console.WriteLine(game);

            }
        }
    }
}
