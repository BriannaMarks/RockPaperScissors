using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Computer : Player
    {
        string name;
        Random computerRNG = new Random();

        public override void GetPlayerName()
        {
            name = "Computer";
        }





    }
}
