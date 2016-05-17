using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Warrior: PC
    {
        //protected string _dice;

        public Warrior(int strength, int health, int armor, int attack) :
            base(strength, health, armor, attack)
        {
            Dice = "d12";
        }

        public string Dice { set; get; }

        public override string MakeSound()
        {
            return "Come Meet Your End";
        }
    }
}
