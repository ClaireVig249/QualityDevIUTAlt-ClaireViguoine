using System.ComponentModel;

namespace TD1
{
    public class Livre : Media
    {
        public string titre;
        public string auteur;
        public int nbPages;
        public string editeur;
        
        public void afficherInfos()
        {
            System.Console.WriteLine($"Titre : {titre}");
            System.Console.WriteLine($"Auteur : {auteur}");
            System.Console.WriteLine($"Nombre de pages : {nbPages}");
            System.Console.WriteLine($"Editeur : {editeur}");
        }
    }
}
