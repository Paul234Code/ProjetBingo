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
            
            InitializeDeck();
        }
        public void InitializeDeck()
        {
            stackOfCards = new List<Card>();
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
            
            Card card = stackOfCards[stackOfCards.Count -1];
            stackOfCards.RemoveAt(stackOfCards.Count -1);
            return card;
        }
        // Fonction qui permet de melanger  les cartes
        public void ShuffleDeckCards()
        {
            
            Random rng = new Random();
            int n = stackOfCards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card card = stackOfCards[k];
                stackOfCards[k] = stackOfCards[n];
                stackOfCards[n] = card;
            }
            stackOfCards.Reverse();


        }

    }
}
