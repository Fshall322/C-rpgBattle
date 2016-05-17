using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Rogue: PC
    {
        //protected string _dice;

        public Rogue(int strength, int health, int armor, int attack) :
            base(strength, health, armor, attack)
        {
            Dice = "d8";
        }

        public string Dice { set; get; }

        public override string MakeSound()
        {
            return "You Won't Even See Me Coming";
        }
    }
}
