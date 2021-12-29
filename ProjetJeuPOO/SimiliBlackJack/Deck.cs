using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class Deck 
    {       
        private Stack<Card> stackOfCards;
        
        public Stack<Card> StackOfCards {
            get => stackOfCards; 
            set => stackOfCards = value;
        }
        // Le constructeur
        public Deck()
        {          
            Initialize();
        }
        public void Initialize()
        {
            stackOfCards = new Stack<Card>();
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    stackOfCards.Push(new Card((Figure)i, (Face)j, Math.Min(j + 1, 10)));
                }
            }          
        }
        // Fonction qui permet de verifier la carte si c'est un AS
        public bool Verifier(Card card)
        {
            return card.CardFace == Face.AS;
        }
        // Fonction qui permet de tirer une carte au hasard
        public Card GetRandomCard()
        {          
            return stackOfCards.Pop();
        }
        // Fonction qui permet de melanger  les cartes
        public void ShuffleDeckCards()
        {
            Card[] cardArray = stackOfCards.ToArray();
            for (int i = 0;i < cardArray.Length -1; i++)
            {
                Card temp = cardArray[i];
                cardArray[i] = cardArray[i+1];
                cardArray[i + 1] = temp;
            }
           stackOfCards.Clear();
            foreach (Card card in cardArray)
            {
                stackOfCards.Push(card);
            }
                  
        }
        
    }
}
