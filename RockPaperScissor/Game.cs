using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Game
    {
        Player NewPlayerOne;
        Player NewPlayerTwo;
        
        public void IntroToTheGame()
        {
            Console.WriteLine("Lets play Rock, Paper, Scissor, Lizzard, Spock!");
            Console.WriteLine("How many players?");
            Console.WriteLine("1 or 2");
            
        }
        public void SelectNumberOfPlayers()
        {
            string numberOfPlayers = Console.ReadLine();
            switch (numberOfPlayers)
            {
                case "1":

                    NewPlayerOne = new Human();
                    NewPlayerTwo = new Computer();
                    break;

                case "2":
                    NewPlayerOne = new Human();
                    NewPlayerTwo = new Human();
                    break;

                default:
                    Console.WriteLine("Please choose '1' or '2' players.");
                    SelectNumberOfPlayers();
                    break;
            }
        }
        public void StartGameLoop()
        {
            NewPlayerOne.GetPlayerName();
            NewPlayerTwo.GetPlayerName();

            while (NewPlayerOne.GetPlayerScore() < 2 && NewPlayerTwo.GetPlayerScore() < 2)
            {

            }
        }

     }
 }
