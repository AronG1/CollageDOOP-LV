using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_2
{
    class Dice
    {
        private int numOfSides;
        private Random randGenerator;

        public Dice(int numOfSides)
        {
            this.numOfSides = numOfSides;
            this.randGenerator = new Random();
        }

        public Dice(int numOfSides, Random rand)
        {
            this.numOfSides = numOfSides;
            this.randGenerator = rand;
        }

        public int Roll()
        {
            return RandomGenerator.GetInstance().NextInt(1, 6);
            //return randGenerator.Next(1, numOfSides + 1);
        }
    }
}
