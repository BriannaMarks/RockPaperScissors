using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class NumberOfPlayers
    {
        public void PlayerNumber()
        {
            Player NewPlayerOne;
            Player NewPlayerTwo;
            string name;
            string choice;


            string numberOfPlayers = Console.ReadLine();
            switch (numberOfPlayers)
            {
                case "one":

                    NewPlayerOne = new Human(name, choice);
                    NewPlayerTwo = new Computer("Computer", choice);
                    break;

                case "two":
                    NewPlayerOne = new Human(name, choice);
                    NewPlayerTwo = new Human(name, choice);
                    break;

                default:
                    Console.WriteLine("Please choose 'one' or 'two' players.");
                    PlayerNumber();
                    break;
            }
         }
     }
 }
