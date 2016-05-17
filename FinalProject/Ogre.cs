using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Ogre: NPC
    {
        //protected string _dice;

        public Ogre(int strength, int health, int armor, int attack) :
            base(strength, health, armor, attack)
        {
           Dice = "d12";
        }

        public string Dice { set; get; }

        public override string MakeSound()
        {
            return "I'll Bash You To A Pulp";
        }
    }
}
