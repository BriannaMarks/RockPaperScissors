﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Player
    {
        protected int choice;
        protected string name;
        protected int score;
        public virtual void SetPlayerName()
        {
            name = "None";
        }
        public int GetPlayerChoice()
        {
            return choice;
        }
        public string GetPlayerName()
        {
            return name;
        }
        public int GetPlayerScore()
        {
            return score;
        }
        public virtual int GetChoice()
        {
            return choice;
        }
        public int AddOneToPlayerScore()
        {
            return score++;
        }
    }
}
