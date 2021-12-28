using System;
using System.Collections.Generic;
using System.Text;
using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;

namespace ProjetJeuPOO
{
    class Controller
    {
        static void Main()
        {
            ListeDeMots liste = new ListeDeMots()
            {
                 ListeDeMot = new List<string>{"Orange","Mangue", "developpement", "Recommandation", "Banana","Poire","Deroulement","Pomme","Limon","Cerise","Ordinateur"}
            };
            //Pendu pendu = new Pendu(liste);
           // pendu.Jouer();
           Hand computer = new Hand() {
               ListeOfCard = new List<Card>()
           };
            Hand user = new Hand()
            {
                ListeOfCard = new List<Card>()
            };
            Deck desktop = new Deck(computer, user);          
            desktop.ShuffleFullCards();
            //desktop.DealCard();
            foreach (Card card in desktop.StackOfCards)
            {
                Console.Write($"{card.CardValue} ");
            }
            Console.WriteLine();
            Console.WriteLine("=========================================================================");
            foreach(Card card in computer.ListeOfCard)
            {
                Console.Write($"{card.CardValue} ");
            }
            Console.WriteLine();
            Console.WriteLine("=========================================================================");
            foreach (Card card in user.ListeOfCard)
            {
                Console.Write($"{card.CardValue} ");
            }
            Console.WriteLine();
            Console.WriteLine("=========================================================================");
            desktop.VoirScore();
        }
    }
}
