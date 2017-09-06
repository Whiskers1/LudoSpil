using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoConsoleSpil
{
    public enum GameColor { Red, Blue, Yollow, Green };

    class Game
    {
        private int numberOfPlayers;
        private Player[] players;

        //
        public Game()
        {
            SetNumberOfPlayers();
            CreatePlayers();
            ShowPlayers();
            Board Board = new Board();
        }

        // A method to set the number of player
        public void SetNumberOfPlayers()
        {
            Console.Write("Hvor mange spilere?: ");
            while(numberOfPlayers < 2 || numberOfPlayers > 4)
            {
                if (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out this.numberOfPlayers))
                    Console.WriteLine("\nVælg et tal mellem 2 og 4");
            }
        }

        // A method to create a player
        private void CreatePlayers()
        {
            Console.WriteLine();
            this.players = new Player[this.numberOfPlayers];
            for (int i = 0; i < this.numberOfPlayers; i++)
            {
                Console.Write("Hvad hedder {0} spiller: ", ((GameColor)i));
                string name = Console.ReadLine();
                players[i] = new Player(name, (GameColor)i);
            }
            Console.Clear();
        }

        //
        private void ShowPlayers()
        {
            Console.WriteLine("Okay, her er dine spillere:");
            foreach(Player pl in this.players)
            {
                Console.WriteLine(pl.GetName + " " + pl.GetColor);
                pl.Vis();
            }
        }
    }
}
