using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Cavalier: PC
    {
       // protected string _dice;

        public Cavalier(int strength, int health, int armor, int attack) :
            base(strength, health, armor, attack)
        {
            Dice = "d8";
        }

        public string Dice { set; get; }

        public override string MakeSound()
        {
            return "For Duty";
        }
    }
}
