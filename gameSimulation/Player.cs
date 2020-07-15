using System;
using System.Collections.Generic;
using System.Text;

namespace gameSimulation
{
    class Player
    {

        public string Name { get; set; }
        public string PlayerClass { get; set; }
        public int Life { get; set; }
        public int Dextery { get; set; }
        public int Strength { get; set; }
        public int Wisdom { get; set; }

        public Player(string name)
        {

            Name = name;
            
            
        }

        public void PClass(int classC)
        {
            if (classC == 1)
            {
                
                PlayerClass = "Ranger";
                Dextery = RollDice(1, 6) + 8; ;
                Strength = RollDice(1, 6) + 6;
                Wisdom = RollDice(1,6) + 6;

                
            }
            else if (classC == 2)
            {
                PlayerClass = "Warrior";
                Dextery = RollDice(1, 6) + 6;
                Strength = RollDice(1, 6 + 6);
                Wisdom = RollDice(1, 6) + 8;
                
            }
            else if (classC == 3)
            {
                PlayerClass = "Mage";
                Dextery = RollDice(1, 6) + 6;
                Strength = RollDice(1, 6) + 6;
                Wisdom = RollDice(1, 6)+ 8;
                
            }          

            


        }

        public void LifeCalc()
        {
            var rand = new Random();
            Life = 12 + rand.Next(1, 12);

        }

        public int RollDice(int rolls, int dice)
        {
            var rand = new Random();
            return rolls * rand.Next(1, dice);
        }

        public override string ToString()
        {
            return "Dados do Personagem criado: "
                    + "Nome: "
                    + Name
                    + " Classe: "
                    + PlayerClass
                    + " Vida: "
                    + Life
                    + " Dex: "
                    + Dextery
                    + " Str: "
                    + Strength
                    + " Wis: "
                    + Wisdom;
        }




    }
}
