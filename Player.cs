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

        public Player(string playerName, GameColor playerColor)
        {
            this.name = playerName;
            this.color = playerColor;
            CreateTokens();
        }

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
                        token.Tokenlocation = (76 + i);
                        break;
                    case GameColor.Blue:
                        token.Tokenlocation = (80 + i);
                        break;
                    case GameColor.Yollow:
                        token.Tokenlocation = (84 + i);
                        break;
                    case GameColor.Green:
                        token.Tokenlocation = (88 + i);
                        break;
                }
            }
        }

        public string GetName
        {
            get { return this.name; }
        }

        public GameColor GetColor
        {
            get { return this.color; }
        }

        public void Vis()
        {
            foreach (Token token in this.tokens)
            {
                Console.WriteLine(token.GetColor + " " + token.GetId + " " + token.Tokenlocation);
            }

        }
    }
}
