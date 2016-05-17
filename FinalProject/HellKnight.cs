using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class HellKnight: NPC
    {
        //protected string _dice;

        public HellKnight(int strength, int health, int armor, int attack) :
            base(strength, health, armor, attack)
        {
           Dice = "d10";
        }

        public string Dice { set; get; }

        public override string MakeSound()
        {
            return "You'll Fear My Name";
        }
    }
}
