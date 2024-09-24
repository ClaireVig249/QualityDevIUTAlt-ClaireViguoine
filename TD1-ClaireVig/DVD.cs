namespace TD1
{
    public class DVD : Media
    {
        public int duree;
        public string nom;
        
        public void afficherInfos()
        {
            System.Console.WriteLine($"Durée : {duree}");
            System.Console.WriteLine($"Nom : {nom}");
        }
    }
}
