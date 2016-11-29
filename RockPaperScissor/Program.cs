using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play Rock, Paper, Scissor, Lizzard, Spock!");
            Console.WriteLine("How many players?");
            Console.WriteLine("-one or two-");
        int NumberOfGameRounds = 0;
            while (NumberOfGameRounds < 4)
            {
              NumberOfGameRounds++;
              NumberOfPlayers Start = new NumberOfPlayers();
              Start.PlayerNumber();
              
            }
              Console.ReadKey();
        }
    }
}
