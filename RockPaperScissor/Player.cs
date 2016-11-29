using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Player
    {
        public string name;
        public string choice;

        public Player(string Name, string Choice)
        {
            name = Name;
            choice = Choice;
        }
        public virtual string PlayerGameName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            return name;
        }
        public virtual string PlayerGameChoice()
        {
            Console.WriteLine("What is your choice? (rock, paper, scissors, lizard, spock)");
            choice = Console.ReadLine();
            return choice;
            
        }
        
    }
}
