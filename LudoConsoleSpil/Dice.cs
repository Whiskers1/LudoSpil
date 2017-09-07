using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoConsoleSpil
{
    class Dice
    {
        private int diceValue;

        // A constructor method
        public Dice()
        {
            this.ThrowDice();
        }

        // A method to throw dice
        public int ThrowDice()
        {
            Random rnd = new Random();
            this.diceValue = rnd.Next(1, 7);
            return this.diceValue;
        }

        // A property to get value
        public int GetValue
        {
            get { return this.diceValue; }
        }
    }
}
