using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class PC
    {
     //   protected int _strength;
      //  protected int _health;
      //  protected int _armor;
     //   protected int _attack;

        public PC(int s, int h, int a, int at)
        {
            Strength = s;
            Health = h;
            Armor = a;
            Attack = at;
        }

        public int Strength { set; get; }
        public int Health { set; get; }
        public int Armor { set;get; }
        public int Attack { set; get; }

        public virtual string MakeSound()
        {
            return "TO BATTLE";
        }
    }
}
