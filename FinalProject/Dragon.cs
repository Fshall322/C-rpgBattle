using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Dragon: NPC
    {
        //protected string _dice;

        public Dragon(int strength, int health, int armor, int attack):
            base(strength, health, armor, attack)
        {
           Dice = "d12";
        }

        string Dice { set; get; }

        public override string MakeSound()
        {
            return "You'll Never Reach My Horde Alive";
        }
    }
}
