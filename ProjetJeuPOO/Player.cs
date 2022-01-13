namespace ProjetJeuPOO
{
    public class Player
    {
        public static string Name { get; set; }
        public static int NombrePartiesJouees { get; set; } = 0;
        public static int NombreVictoires { get; set; } = 0;
        public Player()
        {

        }
        public string GetName()
        {
            return Name;
        }
        public int GetNombrePartiesJouees()
        {
            return NombrePartiesJouees;
        }
        public int GetNombresVictoires()
        {
            return NombreVictoires;
        }

    }
}
