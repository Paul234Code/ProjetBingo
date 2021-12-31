using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.Bingo
{
    public class Player
    {
        private Dictionary<int, BingoCard> dictionnary;
        public Dictionary<int,BingoCard> Dictionnary {
            get =>dictionnary; 
            set => dictionnary = value;
        }
        // Le constructeur
        public Player()
        {
            dictionnary = new Dictionary<int, BingoCard>();
        } 
        // Fonction qui va ajouter une carte dans le dictionnaire
        public void AddBingoCard(BingoCard bingoCard,int numero)
        {
            dictionnary[numero] = bingoCard;
        }
        
        
    }
}
