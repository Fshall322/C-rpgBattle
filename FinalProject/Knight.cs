namespace FinalProject
{
    class Knight: PC
    {
        //protected string _dice;
        public Knight(int strength, int health, int armor, int attack) :
            base(strength, health, armor, attack)
        {
            Dice = "d10";
        }

        public string Dice { set; get; }

        public override string MakeSound()
        {
            return "For My King";
        }
    }
}
