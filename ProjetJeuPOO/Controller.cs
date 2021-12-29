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
            BlackJackController blackJackController = new BlackJackController();                     
            blackJackController.DealCard();
            blackJackController.Jouer();
        }
    }
}
