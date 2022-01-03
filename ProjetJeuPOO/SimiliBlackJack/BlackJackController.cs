using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    // classe qui gere la logique du jeu BlackJack
    class BlackJackController : IBlackJack
    {
        private  Joueur player;
        private Croupier dealer ;       
        private Deck deck;
       
        // Le constructeur
        public BlackJackController()
        {
            player = new Joueur();
            dealer = new Croupier();
            deck = new Deck();
        }
        public void DealCard()
        {
            player.HandPlayer.AddCard(deck.GetRandomCard());
            dealer.HandDealer.AddCard(deck.GetRandomCard());
            player.HandPlayer.AddCard(deck.GetRandomCard());
            dealer.HandDealer.AddCard(deck.GetRandomCard());
            player.HandPlayer.DisplayCards();
            player.HandPlayer.DisplayPointage();
            Console.WriteLine("------------------------------------------------");
            dealer.HandDealer.DisplayCards();
            dealer.HandDealer.DisplayPointage();
        }
        // Fonction qui permet de jouer le blackjack
        public void Jouer()
        {
            DealCard();
            //while (player.NombreDePoints < 4 || dealer.NombrePoints < 4)
            //{              
                HitHand();
                if (player.HandPlayer.hasBlackJack())
                {
                    Joueur.NombreDePoints += 2;
                }
                else if (dealer.HandDealer.hasBlackJack())
                {
                    Croupier.NombrePoints += 2;
                }
                else if(player.HandPlayer.StandHand()> 21)
                {
                    ++Croupier.NombrePoints;
                }
                else if(dealer.HandDealer.StandHand()> 21)
                {
                    ++Joueur.NombreDePoints ;
                }
                else if (player.HandPlayer.StandHand() > dealer.HandDealer.StandHand())
                {
                    ++Joueur.NombreDePoints ;
                }
                else if(dealer.HandDealer.StandHand()> player.HandPlayer.StandHand())   
                {
                    ++Croupier.NombrePoints;
                }
                else if(dealer.HandDealer.StandHand() == player.HandPlayer.StandHand())
                {
                    Console.WriteLine("Egalité aucune ne gagne la partie");
                }
               //VoirScore();
           
                player.HandPlayer.ListeOfCard.Clear();
                dealer.HandDealer.ListeOfCard.Clear();

            //}
            
           //VoirScore();
            
        }
        // Fonction qui affiche le nombre de point de chaque Joueur
        public void VoirScore()
        {
            Console.WriteLine($"Score of Player: {Joueur.NombreDePoints}");
            Console.WriteLine($"Score of Dealer: {Croupier.NombrePoints}");           
        }
        // Fonction qui permet de demander une nouvelle carte ou de conserver  sa mise
        public void HitHand()
        {
            Console.WriteLine("Voulez-vous avoir une autre carte ou conserver votre mise?");
            Console.WriteLine("1-  Une autre carte ?");
            Console.WriteLine("2-  Conserver sa mise ?");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    player.HandPlayer.AddCard(deck.GetRandomCard());
                    player.HandPlayer.DisplayPointage();
                    dealer.HandDealer.DisplayPointage();                  
                    break;
                case "2":
                    VoirScore();
                    break ;                    
            }
           

        }
    }
}
