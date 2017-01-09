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
        int numberOfChoiceOptions = 5;
        public void StartFromTheBegining()
        {
            IntroduceTheGame();
            SelectNumberOfPlayers();
            StartGameLoop();
        }
        public void IntroduceTheGame()
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
                case "one":
                    NewPlayerOne = new Human();
                    NewPlayerTwo = new Computer();
                    break;
                case "2":
                case "two":
                    NewPlayerOne = new Human();
                    NewPlayerTwo = new Human();
                    break;
                default:
                    Console.WriteLine("Invalid entry. Please choose 1 or 2 players.");
                    SelectNumberOfPlayers();
                    break;
            }
        }
        public void StartGameLoop()
        {
            NewPlayerOne.SetPlayerName();
            NewPlayerTwo.SetPlayerName();
            while (NewPlayerOne.GetPlayerScore() < 2 && NewPlayerTwo.GetPlayerScore() < 2)
            {
                NewPlayerOne.GetChoice();
                NewPlayerTwo.GetChoice();
                ComparePlayerChoices();
            }
            ReplayGameChoice();
        }
        public void ComparePlayerChoices()
        {
            int playerChoices;

            playerChoices = (numberOfChoiceOptions + NewPlayerOne.GetPlayerChoice() - NewPlayerTwo.GetPlayerChoice()) % numberOfChoiceOptions;

            if (playerChoices == 0)
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("{0}: {1}     {2}: {3}", NewPlayerOne.GetPlayerName(), NewPlayerOne.GetPlayerScore(), NewPlayerTwo.GetPlayerName(), NewPlayerTwo.GetPlayerScore());
            }
            else if (playerChoices % 2 == 1)
            {
                Console.WriteLine("{0} wins!", NewPlayerOne.GetPlayerName());
                NewPlayerOne.AddOneToPlayerScore();
                Console.WriteLine("{0}: {1}     {2}: {3}", NewPlayerOne.GetPlayerName(), NewPlayerOne.GetPlayerScore(), NewPlayerTwo.GetPlayerName(), NewPlayerTwo.GetPlayerScore());
            }
            else if (playerChoices % 2 == 0)
            {
                Console.WriteLine("{0} wins!", NewPlayerTwo.GetPlayerName());
                NewPlayerTwo.AddOneToPlayerScore();
                Console.WriteLine("{0}: {1}     {2}: {3}", NewPlayerOne.GetPlayerName(), NewPlayerOne.GetPlayerScore(), NewPlayerTwo.GetPlayerName(), NewPlayerTwo.GetPlayerScore());
            }
            else
            {
                Console.WriteLine("Error in 'ComparingPlayerChoices'.");
            }            
        }
        public void ReplayGameChoice()
        {
            Console.WriteLine("Play Again?");
            
            switch (Console.ReadLine().ToLower())
            {
                case "yes":
                case "y":
                    StartFromTheBegining();
                    break;
                case "no":
                case "n":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid entry. Please enter yes or no.");
                    ReplayGameChoice();
                    break;
            }
        }
     }
 }
