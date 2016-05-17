using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class YaunTi: NPC
    {
        //protected string _dice;

        public YaunTi(int strength, int health, int armor, int attack) :
            base(strength, health, armor, attack)
        {
            Dice = "d10";
        }

        public string Dice { set; get; }

        public override string MakeSound()
        {
            return "I'll Dice You Into Little Pieces";
        }
    } 
}
