using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Human : Player
    {
        public Human(string Name, string Choice) : base(Name, Choice)
        {
            name = Name;
            choice = Choice;
        }

        public override string PlayerGameName()
        {
            return base.PlayerGameName();
        }
        public override string PlayerGameChoice()
        {
            return base.PlayerGameChoice();

        }
    }
}
