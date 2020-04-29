using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_2
{
    class DiceRoller
    {
        private List<Dice> dice;
        private List<int> resultFromEachRoll;
        private Logger logger;

        public DiceRoller()
        {
            this.dice = new List<Dice>();
            this.resultFromEachRoll = new List<int>();
            logger = new Logger("Console", null);
        }

        public void InsertDice(Dice dice)
        {
            this.dice.Add(dice);
        }

        public void RollAllDice()
        {
            this.resultFromEachRoll.Clear();
            string resultPrint = "Results: ";
            foreach (Dice dice in dice)
            {
                int number = dice.Roll();
                this.resultFromEachRoll.Add(number);
                resultPrint += number.ToString() + " ";
            }
            logger.Log(resultPrint);
        }

        public void LogRollingResult()
        {
            foreach (int result in resultFromEachRoll)
            {
                logger.Log(result.ToString());
            }
        }

        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(this.resultFromEachRoll);
        }

        public int DiceCount { get { return dice.Count; } }

    }
}
