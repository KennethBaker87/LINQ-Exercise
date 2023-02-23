namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create a list of video game names
            //order the list by legnth of game name using lambda method syntax
            List<string> videoGames = new List<string> { "Ninja Gaiden", "Golden Eye", "Castlevania", "PilotWings 64"};
            videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
