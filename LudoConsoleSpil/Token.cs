using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoConsoleSpil
{
    class Token
    {
        private readonly GameColor color;
        private readonly int idNumber;
        private int location;

        public Token(GameColor clr, int id)
        {
            this.color = clr;
            this.idNumber = id;
        }

        public int Tokenlocation
        {
            set { this.location = value; }
            get { return this.location; }
        }

        public GameColor GetColor
        {
            get { return this.color; }
        }

        public int GetId
        {
            get { return this.idNumber; }
        }
    }
}
