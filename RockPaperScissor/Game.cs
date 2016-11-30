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
            IntroToTheGame();
            SelectNumberOfPlayers();
            StartGameLoop();
        }
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
            NewPlayerOne.GetPlayerName();
            NewPlayerTwo.GetPlayerName();

            while (NewPlayerOne.GetPlayerScore() < 2 && NewPlayerTwo.GetPlayerScore() < 2)
            {
                NewPlayerOne.ChoiceInquiry();
                NewPlayerTwo.ChoiceInquiry();
                ComparingPlayerChoices();
            }
            ReplayGameChoice();
        }

        public void ComparingPlayerChoices()
        {
            int i;

            i = (numberOfChoiceOptions + NewPlayerOne.GetPlayerChoice() - NewPlayerTwo.GetPlayerChoice()) % numberOfChoiceOptions;

            if (i == 0)
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("{0}: {1}     {2}: {3}", NewPlayerOne.RecallPlayerName(), NewPlayerOne.GetPlayerScore(), NewPlayerTwo.RecallPlayerName(), NewPlayerTwo.GetPlayerScore());
            }
            else if (i % 2 == 1)
            {
                Console.WriteLine("{0} wins!", NewPlayerOne.RecallPlayerName());
                NewPlayerOne.AddOneToPlayerScore();
                Console.WriteLine("{0}: {1}     {2}: {3}", NewPlayerOne.RecallPlayerName(), NewPlayerOne.GetPlayerScore(), NewPlayerTwo.RecallPlayerName(), NewPlayerTwo.GetPlayerScore());
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine("{0} wins!", NewPlayerTwo.RecallPlayerName());
                NewPlayerTwo.AddOneToPlayerScore();
                Console.WriteLine("{0}: {1}     {2}: {3}", NewPlayerOne.RecallPlayerName(), NewPlayerOne.GetPlayerScore(), NewPlayerTwo.RecallPlayerName(), NewPlayerTwo.GetPlayerScore());
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
