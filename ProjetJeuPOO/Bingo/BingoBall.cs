//Classe représentant un objet boule 

namespace ProjetJeuPOO.Bingo
{
    public class BingoBall
    {
        private int number;
        private char letter;
        // Les proprietes
        public int Number
        {
            get => number;
            set => number = value;
        }
        // Le constructeur
        public BingoBall(int number ,char letter)
        {
            this.number = number;
            this.letter = letter;
        }
    }
}
