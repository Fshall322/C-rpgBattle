using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Gnoll: NPC
    {
        //protected string _dice;

        public Gnoll(int strength, int health, int armor, int attack):
            base(strength, health, armor, attack)
        {
            Dice = "d6";
        }

        string Dice { set; get; }

        public override string MakeSound()
        {
            return "I'll Bite Your Ankles Off";
        }
    }
}

