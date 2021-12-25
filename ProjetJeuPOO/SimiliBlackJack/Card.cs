using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class Card
    {
        private string cardName;
        private int cardValue;
        // Les proprietées
        public string CardName {
            get => cardName; 
            set => cardName = value; 
        }
        public int CardValue {
            get => cardValue;
            set => cardValue = value;
        }
        // Le constructeur de la classe
        public Card(string cardName,int cardValue)
        {
            this.cardName = cardName;
            this.cardValue = cardValue;
        }
        
    }
}
