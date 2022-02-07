using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    internal class Player
    {
        Random Random = new Random();
        public string Name;
        public int Poeng;

        public Player(string name, int poeng)
        {
            Name = name;
            Poeng = poeng;
        }

        public void Play(Player player2)
        {
            var winnerIndex = Random.Next(0, 1);

            if (winnerIndex == 0)
            {
                Poeng++;
                player2.Poeng--;
                Console.WriteLine(Name + " vant runden over " + player2.Name);
            }
            else
            {
                player2.Poeng++;
                Poeng--;
                Console.WriteLine(player2.Name + " vant runden over " + Name);
            }

        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine(Name + " Har " + Poeng + " poeng");

        }
    }
}
