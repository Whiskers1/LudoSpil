using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoConsoleSpil
{
    public enum FieldType { Home, Safe, InPlay, Finish }

    class Board
    {
        private Field[] fields;

        public Board()
        {
            CreateFields();
        }


        private void CreateFields()
        {
            this.fields = new Field[91];

            for (int i = 0; i < fields.Length; i++)
            {
                switch (i)
                {
                    case 0:     //SafeStartRed
                        fields[i] = new Field( i , GameColor.Red, FieldType.Safe);
                        break;
                    case 13:    //SafeStartBlue
                        fields[i] = new Field( i , GameColor.Blue, FieldType.Safe);
                        break;
                    case 26:    //SafeStartYollow
                        fields[i] = new Field( i , GameColor.Yollow, FieldType.Safe);
                        break;
                    case 39:    //SafeStartGreen
                        fields[i] = new Field( i , GameColor.Green, FieldType.Safe);
                        break;
                    case 57:    //FinishRed
                        fields[i] = new Field(i, GameColor.Red, FieldType.Finish);
                        break;
                    case 63:    //FinishBlue
                        fields[i] = new Field(i, GameColor.Blue, FieldType.Finish);
                        break;
                    case 69:    //FinishYollow
                        fields[i] = new Field(i, GameColor.Yollow, FieldType.Finish);
                        break;
                    case 75:    //FinishGreen
                        fields[i] = new Field(i, GameColor.Green, FieldType.Finish);
                        break;
                    default:
                        if (i >= 1 && i <= 12)          //InPlay
                        {
                            fields[i] = new Field(i, GameColor.Red, FieldType.InPlay);
                        }
                        else if (i >= 14 && i <= 25)    //InPlay
                        {
                            fields[i] = new Field(i, GameColor.Blue, FieldType.InPlay);
                        }
                        else if (i >= 27 && i <= 38)    //InPlay
                        {
                            fields[i] = new Field(i, GameColor.Yollow, FieldType.InPlay);
                        }
                        else if (i >= 40 && i <= 51)    //InPlay
                        {
                            fields[i] = new Field(i, GameColor.Green, FieldType.InPlay);
                        }
                        else if (i >= 52 && i <= 56)    //SafeRed
                        {
                            fields[i] = new Field(i, GameColor.Red, FieldType.Safe);
                        }
                        else if (i >= 58 && i <= 62)    //SafeBlue
                        {
                            fields[i] = new Field(i, GameColor.Blue, FieldType.Safe);
                        }
                        else if (i >= 64 && i <= 68)    //SafeYollow
                        {
                            fields[i] = new Field(i, GameColor.Yollow, FieldType.Safe);
                        }
                        else if (i >= 70 && i <= 74)    //SafeGreen
                        {
                            fields[i] = new Field(i, GameColor.Green, FieldType.Safe);
                        }
                        else if (i >= 76 && i <= 79)    //HomeRed
                        {
                            fields[i] = new Field(i, GameColor.Red, FieldType.Home);
                        }
                        else if (i >= 80 && i <= 83)    //HomeBlue
                        {
                            fields[i] = new Field(i, GameColor.Blue, FieldType.Home);
                        }
                        else if (i >= 84 && i <= 87)    //HomeYollow
                        {
                            fields[i] = new Field(i, GameColor.Yollow, FieldType.Home);
                        }
                        else if (i >= 88 && i <= 91)    //HomeGreen
                        {
                            fields[i] = new Field(i, GameColor.Green, FieldType.Home);
                        }
                        else
                        {
                            fields[i] = new Field(i, GameColor.Red, FieldType.InPlay);
                        }
                        break;
                }
            }
        }
    }
}
