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
            Initialize();
        }
        public void Initialize()
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
            Random random = new Random();
            int indice = random.Next(0, stackOfCards.Count);
            Card card = stackOfCards[indice];
            stackOfCards.RemoveAt(indice);
            return card;
        }
        // Fonction qui permet de melanger  les cartes
        public void ShuffleDeckCards()
        {
            stackOfCards.Reverse();


        }

    }
}
