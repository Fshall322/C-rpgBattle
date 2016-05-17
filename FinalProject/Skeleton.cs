using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Skeleton: NPC
    {
        //protected string _dice;

        public Skeleton(int strength, int health, int armor, int attack) :
            base(strength, health, armor, attack)
        {
           Dice = "d8";
        }

        public string Dice { set; get; }

        public override string MakeSound()
        {
            return "I Got A Bone To Pick With You";
        }
    }
}
