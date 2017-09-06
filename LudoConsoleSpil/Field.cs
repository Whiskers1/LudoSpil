using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Linq;

namespace LudoConsoleSpil
{

    class Field
    {
        private readonly GameColor color;
        private readonly int fieldId;
        private readonly FieldType type;
        private Token[] tokens = new Token[2]; 

        public Field(int id, GameColor clr, FieldType typ)
        {
            this.fieldId = id;
            this.color = clr;
            this.type = typ;
        }

        public int GetFieldId
        {
            get { return fieldId; }
        }
        public GameColor GetColor
        {
            get { return color; }
        }
        public FieldType GetType
        {
            get { return type; }
        }


        //public bool PlaceToken(Token tkn)
        //{
        //    if (tokens.Any())
        //    {

        //    }
        //    else
        //    {
        //        tokens[0] = tkn;
        //    }
        //}

    }
}
