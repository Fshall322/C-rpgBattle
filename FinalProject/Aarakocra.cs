using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Aarakocra: NPC
    {
       // protected string _dice;

        public Aarakocra(int strength, int health, int armor, int attack):
            base(strength, health, armor, attack)
        {
            Dice = "d8";
        }

        string Dice { set; get; }

        public override string MakeSound()
        {
            return "Death From The Sky";
        }
    }
}
