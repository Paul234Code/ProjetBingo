using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.Bingo
{
    public class Player
    {
        private Dictionary<int, BingoCard[,]> dictionnary;
        public int MyProperty { get; set; }
        // Le constructeur
        public Player()
        {
            dictionnary = new Dictionary<int, BingoCard[,]>();
        }
        
        
    }
}
