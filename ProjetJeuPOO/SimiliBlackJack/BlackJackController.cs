using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    // classe qui gere la logique du jeu BlackJack
    class BlackJackController : IBlackJack
    {
        private  Hand player;
        private Hand dealer ;
        private Deck deck;
        private static bool gameOver ;
        // Le constructeur
        public BlackJackController()
        {
            player = new Hand("Player");
            dealer = new Hand("Dealer");
            deck = new Deck();
        }
        public void DealCard()
        {
            player.AddCard(deck.GetRandomCard());
            dealer.AddCard(deck.GetRandomCard());
            player.AddCard(deck.GetRandomCard());
            dealer.AddCard(deck.GetRandomCard());
        }
        // Fonction qui permet de jouer le blackjack
        public void Jouer()
        {
            
            throw new NotImplementedException();
            
        }
        //

        public void VoirScore()
        {
            player.StandHand();
            dealer.DisplayCards();
        }
        // Fonction qui permet de demander une nouvelle carte ou de conserver  sa mise
        public void HitHand()
        {
            Console.WriteLine("");
        }
    }
}
