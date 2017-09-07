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

        // A constructor method
        public Token(GameColor clr, int id)
        {
            this.color = clr;
            this.idNumber = id;
        }
        // A property to get token location
        public int TokenLocation
        {
            set { this.location = value; }
            get { return this.location; }
        }
        // A property to get color
        public GameColor GetColor
        {
            get { return this.color; }
        }
        // A property to get id
        public int GetId
        {
            get { return this.idNumber; }
        }
    }
}
