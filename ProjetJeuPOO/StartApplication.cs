using System;
using System.Collections.Generic;
using System.Text;
using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;

namespace ProjetJeuPOO
{
    public class StartApplication
    {
        private Boulier boulier;
        private BlackJackController blackJackController;
        private Pendu pendu;
        // Le constructeur
        public StartApplication()
        {
            boulier = new Boulier();
            blackJackController = new BlackJackController();
            //pendu = new Pendu();
        }
        // Fonction qui affiche le Menu principal
        public void MenuPrincipal()
        {
            Console.WriteLine("1- Jeu de Bingo");
            Console.WriteLine("2- Jeu du SIMILI Black Jack");
            Console.WriteLine("3- Jeu du SIMILI PENDU");
        }


    }
}
