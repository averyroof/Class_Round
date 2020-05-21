using System;
using System.IO;

namespace Class_Round
{
    public class RoundProvider
    {
        private Round _round;

        public RoundProvider(Round round)
        {
            _round = round;
        }

        public static Round LoadFromFile()
        {
            using StreamReader sr = new StreamReader("input.txt");
            string[] mas = sr.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (mas != null && mas.Length == 3)
            {
                if (!int.TryParse(mas[0], out var x))
                {
                    throw new ArgumentException($@"Неккоректно введена кордината x: {mas[0]}");
                }

                if (!int.TryParse(mas[1], out var y))
                {
                    throw new ArgumentException($@"Неккоректно введена кордината y: {mas[1]}");
                }

                if (!int.TryParse(mas[2], out var r))
                {
                    throw new ArgumentException($@"Неккоректно введен радиус: {mas[2]}");

                }
                Round round = new Round(x, y, r);
                return round;
            }

            return null;
        }

        public void SaveToFile()
        {
            using StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(_round.ToString());
        }
    }
}