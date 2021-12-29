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
        private static int scorePlayer = 0;
        private static int scoreDealer = 0;
        private Deck deck;
        private static bool gameOver = false ;
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
            player.DisplayPointage();
            dealer.DisplayPointage();
        }
        // Fonction qui permet de jouer le blackjack
        public void Jouer()
        {
            
            while (scorePlayer < 4 || scoreDealer < 4)
            {

            }
            
           
            
        }
        // Fonction qui affiche le nombre de point de chaque Joueur
        public void VoirScore()
        {
            Console.WriteLine($"Score of Player: {scorePlayer}");
            Console.WriteLine($"Score of Dealer: {scorePlayer}");           
        }
        // Fonction qui permet de demander une nouvelle carte ou de conserver  sa mise
        public void HitHand()
        {
            Console.WriteLine("o Une autre carte ?");
            Console.WriteLine("o Conserver sa mise ?");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    player.AddCard(deck.GetRandomCard());
                    break;
                case "2":
                    player.StandHand();
                    break ;

                    
            }

        }
    }
}
