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

        public override void GetPlayerName()
        {
            name = "Computer";
        }
        
        public override int ChoiceInquiry()
        {
            int computerChoice = computerRNG.Next(1, 6);

            switch (computerChoice)
            {
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

                case 5:
                    choice = 5;
                    return choice;

                default:
                    Console.WriteLine("Error.");
                    return choice;
            }
        }
    }
}
        
