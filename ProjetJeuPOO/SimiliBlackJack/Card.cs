using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class Card
    {      
        private int cardValue;
        // Les proprietées      
        public int CardValue {
            get => cardValue;
            set => cardValue = value;
        }
        // Le constructeur de la classe
        public Card(int cardValue)
        {          
            this.cardValue = cardValue;
        }
        
    }
}
