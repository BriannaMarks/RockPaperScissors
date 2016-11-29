using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class RandomNumberGenerator
    {
        public string ComputerRNG()
        {
            Random computerRNG = new Random();
            int computerChoice = computerRNG.Next(1, 6);
     
            if (computerChoice == 1)//Rock
            {
                string choice = "rock";
                return choice;
            }
            else if (computerChoice == 2)//Paper
            {
                string choice = "paper";
                return choice;
            } 
            else if (computerChoice == 3)//Scissors
            {
                string choice = "scissors";
                return choice;
            }
            else if (computerChoice == 4)//Lizard
            {
                string choice = "lizard";
                return choice;
            }
            else//only option is 5 Spock
            {
                string choice = "spock";
                return choice;
            }
           
        }

    }
}
