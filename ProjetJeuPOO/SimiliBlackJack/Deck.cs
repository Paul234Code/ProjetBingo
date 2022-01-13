using System;
using System.Collections.Generic;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class Deck
    {
        private List<Card> stackOfCards;

        public List<Card> StackOfCards
        {
            get => stackOfCards;
            set => stackOfCards = value;
        }
        // Le constructeur
        public Deck()
        {
            stackOfCards = new List<Card>();

            Initialize();
        }
        public void Initialize()
        {
           
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    stackOfCards.Add(new Card((Figure)i, (Face)j, Math.Min(j + 1, 10)));
                }
            }
            ShuffleDeckCards();
        }
        // Fonction qui permet de verifier la carte si c'est un AS
        public bool Verifier(Card card)
        {
            return card.CardFace == Face.AS;
        }
        // Fonction qui permet de tirer une carte au hasard
        public Card GetRandomCard()
        {

            Card card = stackOfCards[stackOfCards.Count - 1];
            stackOfCards.RemoveAt(stackOfCards.Count - 1);
            return card;
        }
        // Fonction qui permet de melanger  les cartes
        public void ShuffleDeckCards()
        {
            Random random = new Random();
            int n = stackOfCards.Count;
            while (n > 0)
            {
               
                int k = random.Next(0,n);
                Card card = stackOfCards[k];
                stackOfCards[k] = stackOfCards[n-1];
                stackOfCards[n-1] = card;
                n--;
            }
            stackOfCards.Reverse();


        }

    }
}
