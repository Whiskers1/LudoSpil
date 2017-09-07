using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoConsoleSpil
{
    class Player
    {
        private readonly string name;
        private readonly GameColor color;
        private Token[] tokens;

        // A constructor method
        public Player(string playerName, GameColor playerColor)
        {
            this.name = playerName;
            this.color = playerColor;
            CreateTokens();
        }

        // A method to create tokens
        private void CreateTokens()
        {
            this.tokens = new Token[4];
            for (int i = 0; i < tokens.Length; i++)
            {
                tokens[i] = new Token(this.color, (i+1));
                Token token = this.tokens[i];
                switch (color)
                {
                    case GameColor.Red:
                        token.TokenLocation = (76 + i);
                        break;
                    case GameColor.Blue:
                        token.TokenLocation = (80 + i);
                        break;
                    case GameColor.Yollow:
                        token.TokenLocation = (84 + i);
                        break;
                    case GameColor.Green:
                        token.TokenLocation = (88 + i);
                        break;
                }
            }
        }

        // A property to get name
        public string GetName
        {
            get { return this.name; }
        }
        // A property to get color
        public GameColor GetColor
        {
            get { return this.color; }
        }
    }
}
