namespace Class_Round
{
    class Program
    {
        static void Main()
        {
            var round = RoundProvider.LoadFromFile();
            new RoundProvider(round).SaveToFile();
        }
    }
}