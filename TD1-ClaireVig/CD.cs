namespace TD1
{
    public class CD : Media
    {
        public string Artiste;
        public int nbPistes;
        
        public void afficherInfos()
        {
            System.Console.WriteLine($"Artiste : {Artiste}");
            System.Console.WriteLine($"Nombre de pistes : {nbPistes}");
        }
    }
}