using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class Hand
    {
        private List<Card> listeOfCard;
        private bool hitCard;
        public bool HitCard {
            get => hitCard;
            set => hitCard =  value;
        }
        public List<Card> ListeOfCard {
            get => listeOfCard; 
            set => listeOfCard = value; 
        }
        // constructeur
        public Hand()
        {
            listeOfCard = new List<Card>();
        }
        //fonction qui ajoute une carte dans la main
        public void DealCard(Card card)
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
        // Fonction qui demande si un ajoute une  autre carte
        public void HitHand()
        {

        }
    }
}
