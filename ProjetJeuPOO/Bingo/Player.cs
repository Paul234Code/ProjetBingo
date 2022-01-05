using System.Collections.Generic;

namespace ProjetJeuPOO.Bingo
{
    public class Player
    {
        private Dictionary<int, BingoCard> dictionnary;
        public Dictionary<int, BingoCard> Dictionnary
        {
            get => dictionnary;
            set => dictionnary = value;
        }
        private static int nombreParties;
        private static int nombreParts;
        private static int nombreVictoires;
        // Le constructeur
        public Player()
        {
            dictionnary = new Dictionary<int, BingoCard>();
        }
        // Fonction qui va ajouter une carte dans le dictionnaire
        public void AddBingoCard(BingoCard bingoCard, int numero)
        {
            dictionnary[numero] = bingoCard;
        }


    }
}
