using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller roller = new DiceRoller();

            for (int i = 0; i < 20; i++)
            {
                Dice dice = new Dice(6);
                roller.InsertDice(dice);
            }
            roller.RollAllDice();
            IList<int> results = roller.GetRollingResults();
            foreach (int result in results)
            {
                Console.Write(result + " ");
            }

            Console.WriteLine();

            Random rand = new Random();
            DiceRoller roller2 = new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                Dice dice = new Dice(6, rand);
                roller2.InsertDice(dice);
            }
            roller2.RollAllDice();
            results = roller2.GetRollingResults();
            foreach (int result in results)
            {
                Console.Write(result + " ");
            }



            Console.ReadKey();

        }
    }
}
