using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Player
    {
        protected string choice;
        string name;
        protected int score;

        public virtual void GetPlayerName()
        {
            name = "None";
        }
        public string GetPlayerChoice()
        {
            return choice;

        }
        public int GetPlayerScore()
        {
            return score;
        }
    }
}
