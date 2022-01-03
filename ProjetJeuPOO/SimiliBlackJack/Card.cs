namespace ProjetJeuPOO.SimiliBlackJack
{
    public class Card
    {
        private Figure cardFigure;
        private Face cardFace;
        private int cardValue;
        // Les proprietées      
        public int CardValue
        {
            get => cardValue;
            set => cardValue = value;
        }
        public Figure CardFigure
        {
            get => cardFigure;
            set => cardFigure = value;
        }
        public Face CardFace
        {
            get => cardFace;
            set => cardFace = value;
        }
        // Le constructeur de la classe
        public Card(Figure cardFigure, Face cardFace, int cardValue)
        {
            this.cardFigure = cardFigure;
            this.cardFace = cardFace;
            this.cardValue = cardValue;
        }
        // fonction qui affiche une carte
        public override string ToString()
        {
            return $"{cardFace}\t\t {cardFigure}\t\t{cardValue}";
        }

    }
}
