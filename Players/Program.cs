using System;

namespace Players
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var players = new[]
            {
                new Player("Per", 10), 
                new Player("Pål", 10), 
                new Player("Espen", 10)
            };


            for (var round = 1; round <= 10; round++)
            {
                var playerIndex1 = random.Next(players.Length);
                var playerIndex2 = (playerIndex1 + 1 + random.Next(2)) % players.Length;
                var player1 = players[playerIndex1];
                var player2 = players[playerIndex2];
                player1.Play(player2);
            }
            Console.WriteLine();

            var i = 0;
            foreach (var player in players)
            {
                player.ShowNameAndPoints();
                if (i == 2)
                {
                    string winningPlayer;
                    if (players[0].Poeng > players[1].Poeng && players[0].Poeng > players[2].Poeng)
                    {
                        winningPlayer = players[0].Name;
                        PrintWinner(winningPlayer);
                    }
                    else if (players[1].Poeng > players[2].Poeng && players[1].Poeng > players[0].Poeng)
                    {
                        winningPlayer = players[1].Name;
                        PrintWinner(winningPlayer);
                    }
                    else
                    {
                        winningPlayer = players[2].Name;
                        PrintWinner(winningPlayer);
                    }
                }
                i++;
            }

        }

        private static void PrintWinner(string winningPlayer)
        {
            Console.WriteLine();
            Console.WriteLine("Vinneren er: " + winningPlayer);
        }
    }
}
