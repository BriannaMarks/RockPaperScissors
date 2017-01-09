using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Computer : Player
    {
        Random computerRNG = new Random();
        public override void SetPlayerName()
        {
            name = "Computer";
        }
        public override int GetChoice()
        {
            int computerChoice = computerRNG.Next(0, 5);
            switch (computerChoice)
            {
                case 0:
                    choice = 0;
                    return choice;
                case 1:
                    choice = 1;
                    return choice;
                case 2:
                    choice = 2;
                    return choice;
                case 3:
                    choice = 3;
                    return choice;
                case 4:
                    choice = 4;
                    return choice;
                default:
                    Console.WriteLine("Error.");
                    return choice;
            }
        }
    }
}
        
