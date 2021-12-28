using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class Card
    {
        private Couleur cardColor;
        private Face cardFace;
        private int cardValue;
        // Les proprietées      
        public int CardValue {
            get => cardValue;
            set => cardValue = value;
        }
        public Couleur CardColor {
            get => cardColor; 
            set => cardColor = value;
        }
        public Face CardFace {
            get => cardFace; 
            set => cardFace = value;
        }
        // Le constructeur de la classe
        public Card(Couleur cardColor,Face cardFace,int cardValue)
        { 
            this.cardColor = cardColor;
            this.cardFace = cardFace;
            this.cardValue = cardValue;
        }
        
    }
}
