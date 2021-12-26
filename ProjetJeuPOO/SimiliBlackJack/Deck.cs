using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class Deck : IBlackJack
    {
        private Hand computer;
        private Hand user;
        private List<Card> cards;
        // proprietes
        public Hand Computer {
            get => computer; 
            set => computer = value; 
        }
        
        public Hand User { 
            get => user; 
            set => user = value; 
        }
        public List<Card> Cards {
            get => cards; 
            set => cards = value;
        }
        // Le constructeur
        public Deck( Hand computer, Hand user)
        {
            this.computer = computer;
            this.user = user;
            cards = new List<Card>() ;
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
            Random random = new Random();
            int valeurCard = random.Next(0, cards.Count);
            return cards[valeurCard];
        }
        // Fonction qui remplit les cartes
        public void FullCards()
        {
            for(int number = 1; number <= 52; number++)
            {
                cards.Add( new Card(number));
            }
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
