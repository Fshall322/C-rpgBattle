using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class NPC
    {
    
        public NPC(int s, int h, int a, int at)
        {
            Strength = s;
            Health = h;
            Armor = a;
            Attack = at;  
        }

        public int Strength { set; get; }
        public int Health { set; get; }
        public int Armor { set; get; }
        public int Attack { set; get; }

        public virtual string MakeSound()
        {
            return "To War";
        }
    } 
}
