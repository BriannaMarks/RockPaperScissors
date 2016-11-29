using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Computer : Player
    {
        public Computer(string Name, string Choice) : base(Name, Choice)
        {
            name = Name;
            choice = Choice;
        }
        public override string PlayerGameName()
        {
            name = "computer";
            return name;
        }
        public override string PlayerGameChoice()
        {
            RandomNumberGenerator PickANumber = new RandomNumberGenerator();
            choice = PickANumber.ComputerRNG();
            return choice;
        }

    }
}
