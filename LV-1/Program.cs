using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zabiljeska zabiljeska = new Zabiljeska("Nikolaj Tutumdum", "Nemoj to zaboravit, kuis e.", Helper.Vaznost.SuperVazno);
            Zabiljeska zabiljeska2 = new Zabiljeska("Kulukuk Nikuluk III", "Mala je sou.");
            Zabiljeska zabiljeska3 = new Zabiljeska("Dislav Noic");
            zabiljeska3.SetTekst("Bila jednom jedna breza. Bila visoka, bila i srusena. Hvala na pozornosti do slusanja.");
            Console.WriteLine("Zabiljeska 1: \nAutor: " + zabiljeska.autor + "\nTekst: " + zabiljeska.tekst);
            Console.WriteLine("Zabiljeska 2: \nAutor: " + zabiljeska2.autor + "\nTekst: " + zabiljeska2.tekst);
            Console.WriteLine("Zabiljeska 3: \nAutor: " + zabiljeska3.autor + "\nTekst: " + zabiljeska3.tekst);

            List<Zabiljeska> zabiljeske = new List<Zabiljeska>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\nUnesi autora: ");
                string autor = Console.ReadLine();
                Console.Write("\nUnesi tekst: ");
                string tekst = Console.ReadLine();
                Zabiljeska z = new Zabiljeska(autor, tekst);
                zabiljeske.Add(z);
            }
            ToDoLista ToDoLista = new ToDoLista();
            foreach (Zabiljeska z in zabiljeske)
            {
                ToDoLista.AddToList(z);
            }
            ToDoLista.PrintList();

            Console.ReadKey();


        }
    }
}
