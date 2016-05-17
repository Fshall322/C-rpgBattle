using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Paladin: PC
    {
        //protected string _dice;

        public Paladin(int strength, int health, int armor, int attack) :
            base(strength, health, armor, attack)
        {
            Dice = "d10";
        }

        public string Dice { set; get; }

        public override string MakeSound()
        {
            return "My Hammer Of Justice Will Crush You";
        }
    }
}
