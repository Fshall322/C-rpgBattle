using FinalProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Combat_form : Form
    {
        int creatureNumber=0;
        string choice = "";

        public Combat_form(string userChoice)
        {
            InitializeComponent();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();

            Random rand = new Random();
           
          //  creatureNumber = rand.Next(1, 8);
            creatureNumber = 1;
            string[] creature = new string[8] { "Aarakocra", "Dragon", "Gnoll", "Goblin", "HellKnight", "Ogre", "Skeleton", "Yaun-Ti" };
            string creatureName;
            choice = userChoice;

            if (userChoice == "Barbarian")
            {
                pictureBox1.Show();
                HeroLabel.Text = "Barbarian";
            }
            else if (userChoice == "Cavalier")
            {
                pictureBox2.Show();
                HeroLabel.Text = "Cavalier";
            }
            else if (userChoice == "Knight")
            {
                pictureBox3.Show();
                HeroLabel.Text = "Knight";
            }
            else if (userChoice == "MageKiller")
            {
                pictureBox4.Show();
                HeroLabel.Text = "MageKiller";
            }
            else if (userChoice == "Paladin")
            {
                pictureBox5.Show();
                HeroLabel.Text = "Paladin";
            }
            else if (userChoice == "Rogue")
            {
                pictureBox6.Show();
                HeroLabel.Text = "Rogue";
            }
            else if (userChoice == "Warrior")
            {
                pictureBox7.Show();
                HeroLabel.Text = "Warrior";
            }
            else if (userChoice == "Wizard")
            {
                pictureBox8.Show();
                HeroLabel.Text = "Wizard";
            }

           switch (creatureNumber)    
            {
                case 1:
                    pictureBox9.Show();
                    creatureName = creature[0];
                    MonsterLabel.Text = creatureName;
                               

                    break;
                case 2:
                    pictureBox10.Show();
                    creatureName = creature[1];
                    MonsterLabel.Text = creatureName;
                    break;
                case 3:
                    pictureBox11.Show();
                    creatureName = creature[2];
                    MonsterLabel.Text = creatureName;
                    break;
                case 4:
                    pictureBox12.Show();
                    creatureName = creature[3];
                    MonsterLabel.Text = creatureName;
                    break;
                case 5:
                    pictureBox13.Show();
                    creatureName = creature[4];
                    MonsterLabel.Text = creatureName;
                    break;
                case 6:
                    pictureBox14.Show();
                    creatureName = creature[5];
                    MonsterLabel.Text = creatureName;
                    break;
                case 7:
                    pictureBox15.Show();
                    creatureName = creature[6];
                    MonsterLabel.Text = creatureName;
                    break;
                case 8:
                    pictureBox16.Show();
                    creatureName = creature[7];
                    MonsterLabel.Text = creatureName;
                    break;
            }

         
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            Attacking(choice, creatureNumber);
        }


        public int Attacking(string choice, int creatureNumber)
        {
            int healthPoints1 = 0;
            int healthPoints2 = 0;
            int attackSwing1;
            int attackSwing2;
           
         //   MessageBox.Show(choice + creatureNumber);
            int armorClass1 = 0;
            int armorClass2 = 0;
            if(choice == "Barbarian" && creatureNumber == 1)
            {
                Barbarian barbarian = new Barbarian(18, 20, 15, 6);
                Aarakocra aarakocra = new Aarakocra(17, 21, 16, 5);
                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = barbarian.Health;
                healthPoints2 = aarakocra.Health;
                armorClass1 = barbarian.Armor;
                armorClass2 = aarakocra.Armor;
                attackSwing1 = attack.Next(1, 20) + barbarian.Attack;
                attackSwing2 = attack.Next(1, 20) + aarakocra.Attack;

                if(attackSwing1 >= armorClass1) 
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if(attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if(barbarian.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if(aarakocra.Health <= 0)
                {
                    MessageBox.Show("You win");
                }

            }
            else if(choice == "Barbarian" && creatureNumber == 2)
            {
                Barbarian barbarian = new Barbarian(18, 20, 15, 6);
                Dragon dragon = new Dragon(18, 22, 15, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = barbarian.Health;
                healthPoints2 = dragon.Health;
                armorClass1 = barbarian.Armor;
                armorClass2 = dragon.Armor;
                attackSwing1 = attack.Next(1, 20) + barbarian.Attack;
                attackSwing2 = attack.Next(1, 20) + dragon.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (barbarian.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (dragon.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Barbarian" && creatureNumber == 3)
            {
                Barbarian barbarian = new Barbarian(18, 20, 15, 6);
                Gnoll gnoll = new Gnoll(17, 20, 14, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = barbarian.Health;
                healthPoints2 = gnoll.Health;
                armorClass1 = barbarian.Armor;
                armorClass2 = gnoll.Armor;
                attackSwing1 = attack.Next(1, 20) + barbarian.Attack;
                attackSwing2 = attack.Next(1, 20) + gnoll.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (barbarian.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (gnoll.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Barbarian" && creatureNumber == 4)
            {
                Barbarian barbarian = new Barbarian(18, 20, 15, 6);
                Goblin goblin = new Goblin(17, 19, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = barbarian.Health;
                healthPoints2 = goblin.Health;
                armorClass1 = barbarian.Armor;
                armorClass2 = goblin.Armor;
                attackSwing1 = attack.Next(1, 20) + barbarian.Attack;
                attackSwing2 = attack.Next(1, 20) + goblin.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();

                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (barbarian.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (goblin.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Barbarian" && creatureNumber == 5)
            {
                Barbarian barbarian = new Barbarian(18, 20, 15, 6);
                HellKnight hellknight = new HellKnight(18, 22, 14, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = barbarian.Health;
                healthPoints2 = hellknight.Health;
                armorClass1 = barbarian.Armor;
                armorClass2 = hellknight.Armor;
                attackSwing1 = attack.Next(1, 20) + barbarian.Attack;
                attackSwing2 = attack.Next(1, 20) + hellknight.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (barbarian.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (hellknight.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Barbarian" && creatureNumber == 6)
            {
                Barbarian barbarian = new Barbarian(18, 20, 15, 6);
                Ogre ogre = new Ogre(19, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = barbarian.Health;
                healthPoints2 = ogre.Health;
                armorClass1 = barbarian.Armor;
                armorClass2 = ogre.Armor;
                attackSwing1 = attack.Next(1, 20) + barbarian.Attack;
                attackSwing2 = attack.Next(1, 20) + ogre.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (barbarian.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (ogre.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Barbarian" && creatureNumber == 7)
            {
                Barbarian barbarian = new Barbarian(18, 20, 15, 6);
                Skeleton skeleton = new Skeleton(17, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = barbarian.Health;
                healthPoints2 = skeleton.Health;
                armorClass1 = barbarian.Armor;
                armorClass2 = skeleton.Armor;
                attackSwing1 = attack.Next(1, 20) + barbarian.Attack;
                attackSwing2 = attack.Next(1, 20) + skeleton.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (barbarian.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (skeleton.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Barbarian" && creatureNumber == 8)
            {
                Barbarian barbarian = new Barbarian(18, 20, 15, 6);
                YaunTi yaunti = new YaunTi(18, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = barbarian.Health;
                healthPoints2 = yaunti.Health;
                armorClass1 = barbarian.Armor;
                armorClass2 = yaunti.Armor;
                attackSwing1 = attack.Next(1, 20) + barbarian.Attack;
                attackSwing2 = attack.Next(1, 20) + yaunti.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }
                

                if (barbarian.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (yaunti.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Cavalier" && creatureNumber == 1)
            {
                Cavalier cavalier = new Cavalier(18, 20, 15, 6);
                Aarakocra aarakocra = new Aarakocra(17, 21, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = cavalier.Health;
                healthPoints2 = aarakocra.Health;
                armorClass1 = cavalier.Armor;
                armorClass2 = aarakocra.Armor;
                attackSwing1 = attack.Next(1, 20) + cavalier.Attack;
                attackSwing2 = attack.Next(1, 20) + aarakocra.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (cavalier.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (aarakocra.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Cavalier" && creatureNumber == 2)
            {
                Cavalier cavalier = new Cavalier(18, 20, 15, 6);
                Dragon dragon = new Dragon(18, 22, 15, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = cavalier.Health;
                healthPoints2 = dragon.Health;
                armorClass1 = cavalier.Armor;
                armorClass2 = dragon.Armor;
                attackSwing1 = attack.Next(1, 20) + cavalier.Attack;
                attackSwing2 = attack.Next(1, 20) + dragon.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (cavalier.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (dragon.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Cavalier" && creatureNumber == 3)
            {
                Cavalier cavalier = new Cavalier(18, 20, 15, 6);
                Gnoll gnoll = new Gnoll(17, 20, 14, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = cavalier.Health;
                healthPoints2 = gnoll.Health;
                armorClass1 = cavalier.Armor;
                armorClass2 = gnoll.Armor;
                attackSwing1 = attack.Next(1, 20) + cavalier.Attack;
                attackSwing2 = attack.Next(1, 20) + gnoll.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (cavalier.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (gnoll.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Cavalier" && creatureNumber == 4)
            {
                Cavalier cavalier = new Cavalier(18, 20, 15, 6);
                Goblin goblin = new Goblin(17, 19, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = cavalier.Health;
                healthPoints2 = goblin.Health;
                armorClass1 = cavalier.Armor;
                armorClass2 = goblin.Armor;
                attackSwing1 = attack.Next(1, 20) + cavalier.Attack;
                attackSwing2 = attack.Next(1, 20) + goblin.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                 else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }
                

                if (cavalier.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (goblin.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Cavalier" && creatureNumber == 5)
            {
                Cavalier cavalier = new Cavalier(18, 20, 15, 6);
                HellKnight hellknight = new HellKnight(18, 22, 14, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = cavalier.Health;
                healthPoints2 = hellknight.Health;
                armorClass1 = cavalier.Armor;
                armorClass2 = hellknight.Armor;
                attackSwing1 = attack.Next(1, 20) + cavalier.Attack;
                attackSwing2 = attack.Next(1, 20) + hellknight.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (cavalier.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (hellknight.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Cavalier" && creatureNumber == 6)
            {
                Cavalier cavalier = new Cavalier(18, 20, 15, 6);
                Ogre ogre = new Ogre(19, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = cavalier.Health;
                healthPoints2 = ogre.Health;
                armorClass1 = cavalier.Armor;
                armorClass2 = ogre.Armor;
                attackSwing1 = attack.Next(1, 20) + cavalier.Attack;
                attackSwing2 = attack.Next(1, 20) + ogre.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (cavalier.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (ogre.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Cavalier" && creatureNumber == 7)
            {
                Cavalier cavalier = new Cavalier(18, 20, 15, 6);
                Skeleton skeleton = new Skeleton(17, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = cavalier.Health;
                healthPoints2 = skeleton.Health;
                armorClass1 = cavalier.Armor;
                armorClass2 = skeleton.Armor;
                attackSwing1 = attack.Next(1, 20) + cavalier.Attack;
                attackSwing2 = attack.Next(1, 20) + skeleton.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (cavalier.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (skeleton.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if(choice == "Cavalier" && creatureNumber == 8)
            {
                Cavalier cavalier = new Cavalier(18, 20, 15, 6);
                YaunTi yaunti = new YaunTi(18, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = cavalier.Health;
                healthPoints2 = yaunti.Health;
                armorClass1 = cavalier.Armor;
                armorClass2 = yaunti.Armor;
                attackSwing1 = attack.Next(1, 20) + cavalier.Attack;
                attackSwing2 = attack.Next(1, 20) + yaunti.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (cavalier.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (yaunti.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Knight" && creatureNumber == 1)
            {
                Knight knight = new Knight(18, 20, 15, 6);
                Aarakocra aarakocra = new Aarakocra(17, 21, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = knight.Health;
                healthPoints2 = aarakocra.Health;
                armorClass1 = knight.Armor;
                armorClass2 = aarakocra.Armor;
                attackSwing1 = attack.Next(1, 20) + knight.Attack;
                attackSwing2 = attack.Next(1, 20) + aarakocra.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (knight.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (aarakocra.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Knight" && creatureNumber == 2)
            {
                Knight knight = new Knight(18, 20, 15, 6);
                Dragon dragon = new Dragon(18, 22, 15, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = knight.Health;
                healthPoints2 = dragon.Health;
                armorClass1 = knight.Armor;
                armorClass2 = dragon.Armor;
                attackSwing1 = attack.Next(1, 20) + knight.Attack;
                attackSwing2 = attack.Next(1, 20) + dragon.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (knight.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (dragon.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Knight" && creatureNumber == 3)
            {
                Knight knight = new Knight(18, 20, 15, 6);
                Gnoll gnoll = new Gnoll(17, 20, 14, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = knight.Health;
                healthPoints2 = gnoll.Health;
                armorClass1 = knight.Armor;
                armorClass2 = gnoll.Armor;
                attackSwing1 = attack.Next(1, 20) + knight.Attack;
                attackSwing2 = attack.Next(1, 20) + gnoll.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }
                

                if (knight.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (gnoll.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Knight" && creatureNumber == 4)
            {
                Knight knight = new Knight(18, 20, 15, 6);
                Goblin goblin = new Goblin(17, 19, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = knight.Health;
                healthPoints2 = goblin.Health;
                armorClass1 = knight.Armor;
                armorClass2 = goblin.Armor;
                attackSwing1 = attack.Next(1, 20) + knight.Attack;
                attackSwing2 = attack.Next(1, 20) + goblin.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (knight.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (goblin.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Knight" && creatureNumber == 5)
            {
                Knight knight = new Knight(18, 20, 15, 6);
                HellKnight hellknight = new HellKnight(18, 22, 14, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = knight.Health;
                healthPoints2 = hellknight.Health;
                armorClass1 = knight.Armor;
                armorClass2 = hellknight.Armor;
                attackSwing1 = attack.Next(1, 20) + knight.Attack;
                attackSwing2 = attack.Next(1, 20) + hellknight.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (knight.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (hellknight.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Knight" && creatureNumber == 6)
            {
                Knight knight = new Knight(18, 20, 15, 6);
                Ogre ogre = new Ogre(19, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = knight.Health;
                healthPoints2 = ogre.Health;
                armorClass1 = knight.Armor;
                armorClass2 = ogre.Armor;
                attackSwing1 = attack.Next(1, 20) + knight.Attack;
                attackSwing2 = attack.Next(1, 20) + ogre.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (knight.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (ogre.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Knight" && creatureNumber == 7)
            {
                Knight knight = new Knight(18, 20, 15, 6);
                Skeleton skeleton = new Skeleton(17, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = knight.Health;
                healthPoints2 = skeleton.Health;
                armorClass1 = knight.Armor;
                armorClass2 = skeleton.Armor;
                attackSwing1 = attack.Next(1, 20) + knight.Attack;
                attackSwing2 = attack.Next(1, 20) + skeleton.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();

                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (knight.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (skeleton.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Knight" && creatureNumber == 8)
            {
                Knight knight = new Knight(18, 20, 15, 6);
                YaunTi yaunti = new YaunTi(18, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = knight.Health;
                healthPoints2 = yaunti.Health;
                armorClass1 = knight.Armor;
                armorClass2 = yaunti.Armor;
                attackSwing1 = attack.Next(1, 20) + knight.Attack;
                attackSwing2 = attack.Next(1, 20) + yaunti.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();

                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (knight.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (yaunti.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "MageKiller" && creatureNumber == 1)
            {
                MageKiller magekiller = new MageKiller(18, 20, 15, 6);
                Aarakocra aarakocra = new Aarakocra(17, 21, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = magekiller.Health;
                healthPoints2 = aarakocra.Health;
                armorClass1 = magekiller.Armor;
                armorClass2 = aarakocra.Armor;
                attackSwing1 = attack.Next(1, 20) + magekiller.Attack;
                attackSwing2 = attack.Next(1, 20) + aarakocra.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (magekiller.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (aarakocra.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "MageKiller" && creatureNumber == 2)
            {
                MageKiller magekiller = new MageKiller(18, 20, 15, 6);
                Dragon dragon = new Dragon(18, 22, 15, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = magekiller.Health;
                healthPoints2 = dragon.Health;
                armorClass1 = magekiller.Armor;
                armorClass2 = dragon.Armor;
                attackSwing1 = attack.Next(1, 20) + magekiller.Attack;
                attackSwing2 = attack.Next(1, 20) + dragon.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();

                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (magekiller.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (dragon.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "MageKiller" && creatureNumber == 3)
            {
                MageKiller magekiller = new MageKiller(18, 20, 15, 6);
                Gnoll gnoll = new Gnoll(17, 20, 14, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = magekiller.Health;
                healthPoints2 = gnoll.Health;
                armorClass1 = magekiller.Armor;
                armorClass2 = gnoll.Armor;
                attackSwing1 = attack.Next(1, 20) + magekiller.Attack;
                attackSwing2 = attack.Next(1, 20) + gnoll.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }

                if (magekiller.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (gnoll.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }
            }
            else if (choice == "MageKiller" && creatureNumber == 4)
            {
                MageKiller magekiller = new MageKiller(18, 20, 15, 6);
                Goblin goblin = new Goblin(17, 19, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = magekiller.Health;
                healthPoints2 = goblin.Health;
                armorClass1 = magekiller.Armor;
                armorClass2 = goblin.Armor;
                attackSwing1 = attack.Next(1, 20) + magekiller.Attack;
                attackSwing2 = attack.Next(1, 20) + goblin.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (magekiller.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (goblin.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "MageKiller" && creatureNumber == 5)
            {
                MageKiller magekiller = new MageKiller(18, 20, 15, 6);
                HellKnight hellknight = new HellKnight(18, 22, 14, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = magekiller.Health;
                healthPoints2 = hellknight.Health;
                armorClass1 = magekiller.Armor;
                armorClass2 = hellknight.Armor;
                attackSwing1 = attack.Next(1, 20) + magekiller.Attack;
                attackSwing2 = attack.Next(1, 20) + hellknight.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (magekiller.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (hellknight.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "MageKiller" && creatureNumber == 6)
            {
                MageKiller magekiller = new MageKiller(18, 20, 15, 6);
                Ogre ogre = new Ogre(19, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = magekiller.Health;
                healthPoints2 = ogre.Health;
                armorClass1 = magekiller.Armor;
                armorClass2 = ogre.Armor;
                attackSwing1 = attack.Next(1, 20) + magekiller.Attack;
                attackSwing2 = attack.Next(1, 20) + ogre.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (magekiller.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (ogre.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "MageKiller" && creatureNumber == 7)
            {
                MageKiller magekiller = new MageKiller(18, 20, 15, 6);
                Skeleton skeleton = new Skeleton(17, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = magekiller.Health;
                healthPoints2 = skeleton.Health;
                armorClass1 = magekiller.Armor;
                armorClass2 = skeleton.Armor;
                attackSwing1 = attack.Next(1, 20) + magekiller.Attack;
                attackSwing2 = attack.Next(1, 20) + skeleton.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (magekiller.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (skeleton.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "MageKiller" && creatureNumber == 8)
            {
                MageKiller magekiller = new MageKiller(18, 20, 15, 6);
                YaunTi yaunti = new YaunTi(18, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = magekiller.Health;
                healthPoints2 = yaunti.Health;
                armorClass1 = magekiller.Armor;
                armorClass2 = yaunti.Armor;
                attackSwing1 = attack.Next(1, 20) + magekiller.Attack;
                attackSwing2 = attack.Next(1, 20) + yaunti.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (magekiller.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (yaunti.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Paladin" && creatureNumber == 1)
            {
                Paladin paladin = new Paladin(18, 20, 15, 6);
                Aarakocra aarakocra = new Aarakocra(17, 21, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = paladin.Health;
                healthPoints2 = aarakocra.Health;
                armorClass1 = paladin.Armor;
                armorClass2 = aarakocra.Armor;
                attackSwing1 = attack.Next(1, 20) + paladin.Attack;
                attackSwing2 = attack.Next(1, 20) + aarakocra.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (paladin.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (aarakocra.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Paladin" && creatureNumber == 2)
            {
                Paladin paladin = new Paladin(18, 20, 15, 6);
                Dragon dragon = new Dragon(18, 22, 15, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = paladin.Health;
                healthPoints2 = dragon.Health;
                armorClass1 = paladin.Armor;
                armorClass2 = dragon.Armor;
                attackSwing1 = attack.Next(1, 20) + paladin.Attack;
                attackSwing2 = attack.Next(1, 20) + dragon.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (paladin.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (dragon.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Paladin" && creatureNumber == 3)
            {
                Paladin paladin = new Paladin(18, 20, 15, 6);
                Gnoll gnoll = new Gnoll(17, 20, 14, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = paladin.Health;
                healthPoints2 = gnoll.Health;
                armorClass1 = paladin.Armor;
                armorClass2 = gnoll.Armor;
                attackSwing1 = attack.Next(1, 20) + paladin.Attack;
                attackSwing2 = attack.Next(1, 20) + gnoll.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (paladin.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (gnoll.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Paladin" && creatureNumber == 4)
            {
                Paladin paladin = new Paladin(18, 20, 15, 6);
                Goblin goblin = new Goblin(17, 19, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = paladin.Health;
                healthPoints2 = goblin.Health;
                armorClass1 = paladin.Armor;
                armorClass2 = goblin.Armor;
                attackSwing1 = attack.Next(1, 20) + paladin.Attack;
                attackSwing2 = attack.Next(1, 20) + goblin.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (paladin.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (goblin.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Paladin" && creatureNumber == 5)
            {
                Paladin paladin = new Paladin(18, 20, 15, 6);
                HellKnight hellknight = new HellKnight(18, 22, 14, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = paladin.Health;
                healthPoints2 = hellknight.Health;
                armorClass1 = paladin.Armor;
                armorClass2 = hellknight.Armor;
                attackSwing1 = attack.Next(1, 20) + paladin.Attack;
                attackSwing2 = attack.Next(1, 20) + hellknight.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (paladin.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (hellknight.Health <= 0)
                {
                    MessageBox.Show("You win");
                }

            }
            else if (choice == "Paladin" && creatureNumber == 6)
            {
                Paladin paladin = new Paladin(18, 20, 15, 6);
                Ogre ogre = new Ogre(19, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = paladin.Health;
                healthPoints2 = ogre.Health;
                armorClass1 = paladin.Armor;
                armorClass2 = ogre.Armor;
                attackSwing1 = attack.Next(1, 20) + paladin.Attack;
                attackSwing2 = attack.Next(1, 20) + ogre.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (paladin.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (ogre.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Paladin" && creatureNumber == 7)
            {
                Paladin paladin = new Paladin(18, 20, 15, 6);
                Skeleton skeleton = new Skeleton(17, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = paladin.Health;
                healthPoints2 = skeleton.Health;
                armorClass1 = paladin.Armor;
                armorClass2 = skeleton.Armor;
                attackSwing1 = attack.Next(1, 20) + paladin.Attack;
                attackSwing2 = attack.Next(1, 20) + skeleton.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (paladin.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (skeleton.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Paladin" && creatureNumber == 8)
            {
                Paladin paladin = new Paladin(18, 20, 15, 6);
                YaunTi yaunti = new YaunTi(18, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = paladin.Health;
                healthPoints2 = yaunti.Health;
                armorClass1 = paladin.Armor;
                armorClass2 = yaunti.Armor;
                attackSwing1 = attack.Next(1, 20) + paladin.Attack;
                attackSwing2 = attack.Next(1, 20) + yaunti.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (paladin.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (yaunti.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Rogue" && creatureNumber == 1)
            {
                Rogue rogue = new Rogue(18, 20, 15, 6);
                Aarakocra aarakocra = new Aarakocra(17, 21, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = rogue.Health;
                healthPoints2 = aarakocra.Health;
                armorClass1 = rogue.Armor;
                armorClass2 = aarakocra.Armor;
                attackSwing1 = attack.Next(1, 20) + rogue.Attack;
                attackSwing2 = attack.Next(1, 20) + aarakocra.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (rogue.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (aarakocra.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Rogue" && creatureNumber == 2)
            {
                Rogue rogue = new Rogue(18, 20, 15, 6);
                Dragon dragon = new Dragon(18, 22, 15, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = rogue.Health;
                healthPoints2 = dragon.Health;
                armorClass1 = rogue.Armor;
                armorClass2 = dragon.Armor;
                attackSwing1 = attack.Next(1, 20) + rogue.Attack;
                attackSwing2 = attack.Next(1, 20) + dragon.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (rogue.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (dragon.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Rogue" && creatureNumber == 3)
            {
                Rogue rogue = new Rogue(18, 20, 15, 6);
                Gnoll gnoll = new Gnoll(17, 20, 14, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = rogue.Health;
                healthPoints2 = gnoll.Health;
                armorClass1 = rogue.Armor;
                armorClass2 = gnoll.Armor;
                attackSwing1 = attack.Next(1, 20) + rogue.Attack;
                attackSwing2 = attack.Next(1, 20) + gnoll.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (rogue.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (gnoll.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Rogue" && creatureNumber == 4)
            {
                Rogue rogue = new Rogue(18, 20, 15, 6);
                Goblin goblin = new Goblin(17, 19, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = rogue.Health;
                healthPoints2 = goblin.Health;
                armorClass1 = rogue.Armor;
                armorClass2 = goblin.Armor;
                attackSwing1 = attack.Next(1, 20) + rogue.Attack;
                attackSwing2 = attack.Next(1, 20) + goblin.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (rogue.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (goblin.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Rogue" && creatureNumber == 5)
            {
                Rogue rogue = new Rogue(18, 20, 15, 6);
                HellKnight hellknight = new HellKnight(18, 22, 14, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = rogue.Health;
                healthPoints2 = hellknight.Health;
                armorClass1 = rogue.Armor;
                armorClass2 = hellknight.Armor;
                attackSwing1 = attack.Next(1, 20) + rogue.Attack;
                attackSwing2 = attack.Next(1, 20) + hellknight.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (rogue.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (hellknight.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Rogue" && creatureNumber == 6)
            {
                Rogue rogue = new Rogue(18, 20, 15, 6);
                Ogre ogre = new Ogre(19, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = rogue.Health;
                healthPoints2 = ogre.Health;
                armorClass1 = rogue.Armor;
                armorClass2 = ogre.Armor;
                attackSwing1 = attack.Next(1, 20) + rogue.Attack;
                attackSwing2 = attack.Next(1, 20) + ogre.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (rogue.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (ogre.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Rogue" && creatureNumber == 7)
            {
                Rogue rogue = new Rogue(18, 20, 15, 6);
                Skeleton skeleton = new Skeleton(17, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = rogue.Health;
                healthPoints2 = skeleton.Health;
                armorClass1 = rogue.Armor;
                armorClass2 = skeleton.Armor;
                attackSwing1 = attack.Next(1, 20) + rogue.Attack;
                attackSwing2 = attack.Next(1, 20) + skeleton.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (rogue.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (skeleton.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Rogue" && creatureNumber == 8)
            {
                Rogue rogue = new Rogue(18, 20, 15, 6);
                YaunTi yaunti = new YaunTi(18, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = rogue.Health;
                healthPoints2 = yaunti.Health;
                armorClass1 = rogue.Armor;
                armorClass2 = yaunti.Armor;
                attackSwing1 = attack.Next(1, 20) + rogue.Attack;
                attackSwing2 = attack.Next(1, 20) + yaunti.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (rogue.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                if (yaunti.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Warrior" && creatureNumber == 1)
            {
                Warrior warrior = new Warrior(18, 20, 15, 6);
                Aarakocra aarakocra = new Aarakocra(17, 21, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = warrior.Health;
                healthPoints2 = aarakocra.Health;
                armorClass1 = warrior.Armor;
                armorClass2 = aarakocra.Armor;
                attackSwing1 = attack.Next(1, 20) + warrior.Attack;
                attackSwing2 = attack.Next(1, 20) + aarakocra.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (warrior.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (aarakocra.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Warrior" && creatureNumber == 2)
            {
                Warrior warrior = new Warrior(18, 20, 15, 6);
                Dragon dragon = new Dragon(18, 22, 15, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = warrior.Health;
                healthPoints2 = dragon.Health;
                armorClass1 = warrior.Armor;
                armorClass2 = dragon.Armor;
                attackSwing1 = attack.Next(1, 20) + warrior.Attack;
                attackSwing2 = attack.Next(1, 20) + dragon.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (warrior.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (dragon.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Warrior" && creatureNumber == 3)
            {
                Warrior warrior = new Warrior(18, 20, 15, 6);
                Gnoll gnoll = new Gnoll(17, 20, 14, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = warrior.Health;
                healthPoints2 = gnoll.Health;
                armorClass1 = warrior.Armor;
                armorClass2 = gnoll.Armor;
                attackSwing1 = attack.Next(1, 20) + warrior.Attack;
                attackSwing2 = attack.Next(1, 20) + gnoll.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (warrior.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (gnoll.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Warrior" && creatureNumber == 4)
            {
                Warrior warrior = new Warrior(18, 20, 15, 6);
                Goblin goblin = new Goblin(17, 19, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = warrior.Health;
                healthPoints2 = goblin.Health;
                armorClass1 = warrior.Armor;
                armorClass2 = goblin.Armor;
                attackSwing1 = attack.Next(1, 20) + warrior.Attack;
                attackSwing2 = attack.Next(1, 20) + goblin.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (warrior.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (goblin.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Warrior" && creatureNumber == 5)
            {
                Warrior warrior = new Warrior(18, 20, 15, 6);
                HellKnight hellknight = new HellKnight(18, 22, 14, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = warrior.Health;
                healthPoints2 = hellknight.Health;
                armorClass1 = warrior.Armor;
                armorClass2 = hellknight.Armor;
                attackSwing1 = attack.Next(1, 20) + warrior.Attack;
                attackSwing2 = attack.Next(1, 20) + hellknight.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (warrior.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (hellknight.Health <= 0)
                {
                    MessageBox.Show("You win");
                }

            }
            else if (choice == "Warrior" && creatureNumber == 6)
            {
                Warrior warrior = new Warrior(18, 20, 15, 6);
                Ogre ogre = new Ogre(19, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = warrior.Health;
                healthPoints2 = ogre.Health;
                armorClass1 = warrior.Armor;
                armorClass2 = ogre.Armor;
                attackSwing1 = attack.Next(1, 20) + warrior.Attack;
                attackSwing2 = attack.Next(1, 20) + ogre.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (warrior.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (ogre.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Warrior" && creatureNumber == 7)
            {
                Warrior warrior = new Warrior(18, 20, 15, 6);
                Skeleton skeleton = new Skeleton(17, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = warrior.Health;
                healthPoints2 = skeleton.Health;
                armorClass1 = warrior.Armor;
                armorClass2 = skeleton.Armor;
                attackSwing1 = attack.Next(1, 20) + warrior.Attack;
                attackSwing2 = attack.Next(1, 20) + skeleton.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (warrior.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (skeleton.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Warrior" && creatureNumber == 8)
            {
                Warrior warrior = new Warrior(18, 20, 15, 6);
                YaunTi yaunti = new YaunTi(18, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = warrior.Health;
                healthPoints2 = yaunti.Health;
                armorClass1 = warrior.Armor;
                armorClass2 = yaunti.Armor;
                attackSwing1 = attack.Next(1, 20) + warrior.Attack;
                attackSwing2 = attack.Next(1, 20) + yaunti.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (warrior.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (yaunti.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Wizard" && creatureNumber == 1)
            {
                Wizard wizard = new Wizard(18, 20, 15, 6);
                Aarakocra aarakocra = new Aarakocra(17, 21, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = wizard.Health;
                healthPoints2 = aarakocra .Health;
                armorClass1 = wizard.Armor;
                armorClass2 = aarakocra .Armor;
                attackSwing1 = attack.Next(1, 20) + wizard.Attack;
                attackSwing2 = attack.Next(1, 20) + aarakocra .Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (wizard.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (aarakocra .Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Wizard" && creatureNumber == 2)
            {
                Wizard wizard = new Wizard(18, 20, 15, 6);
                Dragon dragon = new Dragon(18, 22, 15, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = wizard.Health;
                healthPoints2 = dragon .Health;
                armorClass1 = wizard.Armor;
                armorClass2 = dragon .Armor;
                attackSwing1 = attack.Next(1, 20) + wizard.Attack;
                attackSwing2 = attack.Next(1, 20) + dragon.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (wizard.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (dragon.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Wizard" && creatureNumber == 3)
            {
                Wizard wizard = new Wizard(18, 20, 15, 6);
                Gnoll gnoll = new Gnoll(17, 20, 14, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = wizard.Health;
                healthPoints2 = gnoll.Health;
                armorClass1 = wizard.Armor;
                armorClass2 = gnoll .Armor;
                attackSwing1 = attack.Next(1, 20) + wizard.Attack;
                attackSwing2 = attack.Next(1, 20) + gnoll.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (wizard.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (gnoll.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Wizard" && creatureNumber == 4)
            {
                Wizard wizard = new Wizard(18, 20, 15, 6);
                Goblin goblin = new Goblin(17, 19, 16, 5);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = wizard.Health;
                healthPoints2 = goblin.Health;
                armorClass1 = wizard.Armor;
                armorClass2 = goblin.Armor;
                attackSwing1 = attack.Next(1, 20) + wizard.Attack;
                attackSwing2 = attack.Next(1, 20) + goblin.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (wizard.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (goblin.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Wizard" && creatureNumber == 5)
            {
                Wizard wizard = new Wizard(18, 20, 15, 6);
                HellKnight hellknight = new HellKnight(18, 22, 14, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = wizard.Health;
                healthPoints2 = hellknight.Health;
                armorClass1 = wizard.Armor;
                armorClass2 = hellknight.Armor;
                attackSwing1 = attack.Next(1, 20) + wizard.Attack;
                attackSwing2 = attack.Next(1, 20) + hellknight.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (wizard.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (hellknight.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Wizard" && creatureNumber == 6)
            {
                Wizard wizard = new Wizard(18, 20, 15, 6);
                Ogre ogre = new Ogre(19, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = wizard.Health;
                healthPoints2 = ogre.Health;
                armorClass1 = wizard.Armor;
                armorClass2 = ogre.Armor;
                attackSwing1 = attack.Next(1, 20) + wizard.Attack;
                attackSwing2 = attack.Next(1, 20) + ogre.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label5.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label4.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (wizard.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (ogre.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Wizard" && creatureNumber == 7)
            {
                Wizard wizard = new Wizard(18, 20, 15, 6);
                Skeleton skeleton = new Skeleton(17, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = wizard.Health;
                healthPoints2 = skeleton.Health;
                armorClass1 = wizard.Armor;
                armorClass2 = skeleton.Armor;
                attackSwing1 = attack.Next(1, 20) + wizard.Attack;
                attackSwing2 = attack.Next(1, 20) + skeleton.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (wizard.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (skeleton.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            else if (choice == "Wizard" && creatureNumber == 8)
            {
                Wizard wizard = new Wizard(18, 20, 15, 6);
                YaunTi yaunti = new YaunTi(18, 20, 15, 6);

                Random attack = new Random();
                Random dmg = new Random();
                int damage1;
                int damage2;
                healthPoints1 = wizard.Health;
                healthPoints2 = yaunti.Health;
                armorClass1 = wizard.Armor;
                armorClass2 = yaunti.Armor;
                attackSwing1 = attack.Next(1, 20) + wizard.Attack;
                attackSwing2 = attack.Next(1, 20) + yaunti.Attack;

                if (attackSwing1 >= armorClass1)
                {
                    label4.Text = "Hit";
                    damage1 = dmg.Next(1, 12);
                    healthPoints1 -= damage1;
                    label2.Text = healthPoints1.ToString();
                }
                else if (attackSwing2 >= armorClass2)
                {
                    label5.Text = "Hit";
                    damage2 = dmg.Next(1, 8);
                    healthPoints2 -= damage2;
                    label1.Text = healthPoints2.ToString();
                }
                else
                {
                    label4.Text = "Miss";
                    label5.Text = "Miss";
                }

                if (wizard.Health <= 0)
                {
                    MessageBox.Show("You have died. Better luck next time");
                }
                else if (yaunti.Health <= 0)
                {
                    MessageBox.Show("You win");
                }
            }
            return healthPoints1;
                
        }

    }
}
