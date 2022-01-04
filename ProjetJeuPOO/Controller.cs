using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;
using System.Collections.Generic;

namespace ProjetJeuPOO
{
    class Controller
    {
        static void Main()
        {
            ListeDeMots liste = new ListeDeMots()
            {
                ListeDeMot = new List<string> { "Orange", "Mangue", "developpement", "Recommandation", "Banana", "Poire", "Deroulement", "Pomme", "Limon", "Cerise", "Ordinateur" }
            };
            StartApplication app =  new StartApplication();
            app.MenuPrincipal();
            Pendu pendu = new Pendu(liste);
            //pendu.Jouer();         
            BlackJackController blackJackController = new BlackJackController();
            //blackJackController.DealCard();
            //blackJackController.Jouer();
            Boulier boulier = new Boulier();
            /* boulier.Initialisation();
             boulier.Visualiser();
             boulier.VisualiserCarteAnnonceur();
             boulier.getRanbomBall();
             boulier.VisualiserCarteAnnonceur();
             boulier.Visualiser();
             boulier.Visualiser();
             boulier.Visualiser(); 
            
            while (!boulier.isEmpty())
            {
                boulier.StartBingoApp();
            } */


        }

    }
}
