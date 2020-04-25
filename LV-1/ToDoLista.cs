using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_1
{
    class ToDoLista
    {
        private List<Zabiljeska> Zabiljeske = new List<Zabiljeska>();

        //public ToDoLista(List<object> l)
        //{
        //    Zabiljeske = l.Cast<List<Zabiljeska>>().Select(x => new Zabiljeska() { autor = (string)x[0], tekst = (string)x[1] }).ToList()
        //}

        public ToDoLista(Zabiljeska zabiljeska)
        {
            Zabiljeske.Add(zabiljeska);
        }

        public ToDoLista()
        {

        }

        public void AddToList(Zabiljeska zabiljeska)
        {
            Zabiljeske.Add(zabiljeska);
        }

        public void PrintList()
        {
            Console.WriteLine("ToDo lista:");
            foreach (Zabiljeska zabiljeska in Zabiljeske)
            {
                Console.WriteLine(zabiljeska.ToString());
            }
        }

        public void DeleteZabiljeska(Zabiljeska zab)
        {
            if (zab == null) return;
            foreach (Zabiljeska zabiljeska in Zabiljeske)
            {
                if(zabiljeska.CompareTo(zab) > 1)
                {
                    Zabiljeske.Remove(zabiljeska);
                    Console.WriteLine("Zabiljeska obrisana!");
                    return;
                }
            }
        }
    }
}
