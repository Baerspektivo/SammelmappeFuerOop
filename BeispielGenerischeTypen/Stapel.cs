using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielGenerischeTypen
{

    public class Stapel<T> where T : IKarte
    {
        private List<T> karten;

        public Stapel()
        {
            karten = new List<T>();
        }

        public void Push(T karte)
        {
            karten.Add(karte);
        }
         
        public T Pop()
        {
            if (karten.Count == 0)
            {
                throw new InvalidOperationException("Der Stapel ist leer.");
            }

            int lastIndex = karten.Count - 1;
            T karte = karten[lastIndex];
            karten.RemoveAt(lastIndex);
            return karte;
        }

        public bool IsEmpty()
        {
            return karten.Count == 0;
        }
    }

}
