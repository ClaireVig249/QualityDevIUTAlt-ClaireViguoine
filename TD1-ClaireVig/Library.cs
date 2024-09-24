using System.Collections.Generic;

namespace TD1
{
    public class Library
    {
        private List<Media> medias = new List<Media>();
        
        //permet l'accès aux médias grace a numRef
        public Media this[int numRef]
        {
            get
            {
                foreach (Media media in medias)
                {
                    if (media.numRef == numRef)
                    {
                        return media;
                    }
                }
                return null;
            }
        }
        
        public void ajouter(Media media)
        {
            medias.Add(media);
        }
        
        public void retirer(Media media)
        {
            medias.Remove(media);
        }
    }
}
