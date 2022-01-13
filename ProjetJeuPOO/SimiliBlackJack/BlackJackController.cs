using System;
using System.Threading;

namespace ProjetJeuPOO.SimiliBlackJack
{
    // classe qui gere la logique du jeu BlackJack
    class BlackJackController : IBlackJack
    {
        private Joueur player;
        private Croupier dealer;
        private Deck deck;
        //Les proprietes
        public Joueur Joueur {
            get =>player; 
            set =>player = value;
        }
        public Croupier Dealer {
            get => dealer; 
            set => dealer = value;
        }
        // Le constructeur
        public BlackJackController()
        {
            player = new Joueur();
            dealer = new Croupier();
            deck = new Deck();          
        }
        public void DealCard()
        {
            Console.WriteLine($"Demarrage de la partie {++Joueur.NombreDeParties} en cours.......");
            Thread.Sleep(3000);
            player.HandPlayer.AddCard(deck.GetRandomCard());
            dealer.HandDealer.AddCard(deck.GetRandomCard());
            player.HandPlayer.AddCard(deck.GetRandomCard());
            dealer.HandDealer.AddCard(deck.GetRandomCard());            
            Display();
            HitHand();
            Validation();
            VoirScore();
            //Joueur.NombreDeParties++;
        }
        // Fonction qui permet de jouer le blackjack
        public void Jouer()
        {
            Console.WriteLine("Bienvenue dans le Jeu Blacjack");
            Console.WriteLine("Demarrage du tournoi.......");
            Thread.Sleep(3000);
            while (Joueur.NombreDePoints < 4 && Croupier.NombrePoints < 4)
            {
                DealCard();               
                player.HandPlayer.ListeOfCard.Clear();
                dealer.HandDealer.ListeOfCard.Clear();
                Console.WriteLine("Voulez-vous lancer une nouvelle partie?");
                Console.WriteLine("Taper[ENTER] pour continuer or CTRL+C pour quitter");
                Console.ReadLine();
            }
            LancerNouveauTournoi();
            Console.WriteLine($"Nombres parties: {Joueur.NombreDeParties}");
        }
        // Fonction qui permet de lancer un nouveau tournoi
        public void LancerNouveauTournoi()
        {
            Console.WriteLine("Voullez-vous lancer un nouveau Tournoi?");
            Console.WriteLine("taper [ENTER] pour continuer");
            Console.WriteLine("1- Lancer nouveau Tournoi");
            Console.WriteLine("2- Retourner au Menu principal");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Jouer();
                    break;
                    
                case "2":
                    
                    break;

            }
        }
        // Fonction qui affiche le nombre de point de chaque Joueur
        public void VoirScore()
        {
            Console.WriteLine($"Score du Joueur : {Joueur.NombreDePoints}");
            Console.WriteLine($"Score du Croupier : {Croupier.NombrePoints}");
        }
        // Fonction qui permet de demander une nouvelle carte ou de conserver  sa mise
        public void HitHand()
        {
            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("Voulez-vous avoir une autre Carte ou conserver votre Mise?");
                Console.WriteLine("1- Une autre carte ?");
                Console.WriteLine("2- Conserver sa mise ?");
                string choice = Console.ReadLine();
                if (choice.Equals("1"))
                {
                    if (player.HandPlayer.StandHand() < 21)
                    {
                        player.HandPlayer.AddCard(deck.GetRandomCard());
                    }
                    else
                    {

                    }                  
                    Display();
                }
                else if (choice.Equals("2"))
                {
                    if(dealer.HandDealer.StandHand() < 21)
                    {
                        dealer.HandDealer.AddCard(deck.GetRandomCard());
                        Display();
                    }
                    else
                    {

                    }                   
                    stop = true;                   
                }
            }           
        }
        // Fonction qui affiche le pointage du Joueur et du Croupier
         public void Display()
         {
            player.HandPlayer.DisplayPointage("Joueur");
            dealer.HandDealer.DisplayPointage("Croupier");
         }
        // Fonction qui attribut le  point au joeur ou croupier qui a gagné la partie
        public void Validation()
        {
            if (player.HandPlayer.hasBlackJack())
            {
                Joueur.NombreDePoints += 2;
            }
            else if (dealer.HandDealer.hasBlackJack())
            {
                Croupier.NombrePoints += 2;
            }
            else if (player.HandPlayer.StandHand() > 21)
            {
                ++Croupier.NombrePoints;
            }
            else if (dealer.HandDealer.StandHand() > 21)
            {
                ++Joueur.NombreDePoints;
            }
            else if (player.HandPlayer.StandHand() > dealer.HandDealer.StandHand())
            {
                ++Joueur.NombreDePoints;
            }
            else if (dealer.HandDealer.StandHand() > player.HandPlayer.StandHand())
            {
                ++Croupier.NombrePoints;
            }
            else if (dealer.HandDealer.StandHand() == player.HandPlayer.StandHand())
            {
                Console.WriteLine("Egalité aucune ne gagne la partie");
            }            
        }
    }
}
