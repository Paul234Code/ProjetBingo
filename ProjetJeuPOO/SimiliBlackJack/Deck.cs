using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class Deck : IBlackJack
    {
        private Hand computer;
        private Hand user;
        private Stack<Card> stackOfCards;
        // proprietes
        public Hand Computer {
            get => computer; 
            set => computer = value; 
        }
        
        public Hand User { 
            get => user; 
            set => user = value; 
        }
        public Stack<Card> StackOfCards {
            get => stackOfCards; 
            set => stackOfCards = value;
        }
        // Le constructeur
        public Deck( Hand computer, Hand user)
        {
            this.computer = computer;
            this.user = user;
            Initialize();
        }
        public void Initialize()
        {
            stackOfCards = new Stack<Card>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    stackOfCards.Push(new Card((Couleur)i, (Face)j, Math.Min(j + 1, 10)));
                }
            }
           
        }
        // Fonction qui permet de verifier la carte si c'est un AS
        public bool Verifier(Card card)
        {
            return card.CardFace == Face.AS;
        }
        // Fonction qui distribue des cartes
        public void DealCard()
        {
            user.ListeOfCard.Add(GetRandomCard());
            computer.ListeOfCard.Add(GetRandomCard());
            user.ListeOfCard.Add(GetRandomCard());
            computer.ListeOfCard.Add(GetRandomCard());           
        }
        // Fonction qui permet de tirer une carte au hasard
        public Card GetRandomCard()
        {
           
            return stackOfCards.Pop();
        }
        // Fonction qui permet de melanger  les cartes
        public void ShuffleFullCards()
        {
            
           
            
        }
        // Fonction qui permet de permutter deux cartes
        public void Permutter( Card card1,  Card card2)
        {


            
        }
        // Fonction qui permet commencer le jeu
        public void Jouer()
        {
            throw new NotImplementedException();
        }

        public void VoirScore()
        {
            Console.WriteLine($"Computeur : {computer.StandHand()}");
            Console.WriteLine($"Utilisateur : {user.StandHand()}");
        }
    }
}
