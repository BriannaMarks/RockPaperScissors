using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Human : Player
    {
        

        public override void GetPlayerName()
        {
            Console.WriteLine("Enter your name, Player.");
            name = Console.ReadLine();
        }

        public override int ChoiceInquiry()
        {
            Console.WriteLine("What is your play choice, {0}?", name);

            switch (Console.ReadLine().ToLower())
            {
                case "rock":
                    choice = 1;
                    return choice;

                case "paper":
                    choice = 2;
                    return choice;

                case "scissors":
                    choice = 3;
                    return choice;

                case "lizard":
                    choice = 4;
                    return choice;

                case "spock":
                    choice = 5;
                    return choice;

                default:
                    Console.WriteLine("Error. Please enter a valid choice:");
                    Console.WriteLine("Rock, Paper, Scissors, Lizard, or Spock.");
                    ChoiceInquiry();
                    return choice;
            }
        }
    }
}
