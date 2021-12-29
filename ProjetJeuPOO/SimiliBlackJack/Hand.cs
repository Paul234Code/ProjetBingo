using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class Hand
    {
        private string name;
        private List<Card> listeOfCard;
        public string Name {
            get => name; 
            set => name = value;
        }
        public List<Card> ListeOfCard {
            get => listeOfCard; 
            set => listeOfCard = value; 
        }
        // constructeur
        public Hand(string name)
        {
            this.name = name;
            listeOfCard = new List<Card>();
        }
        //fonction qui ajoute une carte dans la main
        public void AddCard(Card card)
        {
            listeOfCard.Add(card);
        }
        // Fonction qui calcule le pointage d'une main de carte
        public int StandHand()
        {
            int total = 0;         
            foreach(var card in listeOfCard)
            {
                total += card.CardValue;
            }
            return total;
        }
        // Fonction qui teste si une main forme un blackJack
        public bool hasBlackJack()
        {
            return StandHand() == 21 && listeOfCard.Count == 2;
        }
        // Fonction qui permet d'afficher un main
        public void DisplayCards()
        {
            foreach(var card in listeOfCard)
            {
                Console.WriteLine(card.ToString());
            }
        }
        // Fonction qui demande si un ajoute une  autre carte
        public void HitHand()
        {

        }
    }
}
