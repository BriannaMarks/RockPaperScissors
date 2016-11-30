using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Human : Player
    {
        string name;

        public override void GetPlayerName()
        {
            Console.WriteLine("What is your Name?");
            name = Console.ReadLine();
        }
        public string ChoiceInquiry()
        {
            Console.WriteLine("What is your play choice?");
            choice = Console.ReadLine();
            return choice;

        }

    }
}
