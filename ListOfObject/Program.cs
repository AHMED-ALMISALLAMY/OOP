using System;
using System.Collections.Generic;

namespace ListOfObject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Ahmed");
            Player player2 = new Player("Salah"); 

            players.Add(player1);
            players.Add(player2);
            players.Add(new Player("Ozil")); 

            foreach (Player player in players)
            {
                Console.WriteLine(player); 
            }
        }
    }

    class Player 
    {
        public String userName;

        public Player(String userName)
        {
            this.userName = userName; 
        }

        public override String ToString()
        {
            return userName;
        }
    }
}
