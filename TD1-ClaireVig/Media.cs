using System;

namespace TD1
{
    public class Media
    {
        public string title;
        public int numRef;
        public int nbExempDispos;
        
        public static Media operator +(Media m1, Media m2)
        {
            Media m = new Media();
            m.title = m1.title + " " + m2.title;
            m.numRef = m1.numRef + m2.numRef;
            m.nbExempDispos = m1.nbExempDispos + m2.nbExempDispos;
            return m;
        }
        
        public static Media operator -(Media m1, Media m2)
        {
            Media m = new Media();
            m.title = m1.title + " " + m2.title;
            m.numRef = m1.numRef - m2.numRef;
            m.nbExempDispos = m1.nbExempDispos - m2.nbExempDispos;
            return m;
        }
    }
}
