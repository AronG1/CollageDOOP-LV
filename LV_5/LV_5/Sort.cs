using LV_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace LV_5
{
    class SequantialSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            int arraySize = array.Length;
            for (int i = 0; i < arraySize - 1; i++)
            {
                for (int j = i + 1; j < arraySize; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

    }
    class CombSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            int arraySize = array.Length;
            int gap = arraySize;
            const double shrink = 1.3;
            bool sorted;
            do
            {
                sorted = true;
                gap = (int)(gap / shrink);
                if (gap > 1)
                {
                    sorted = false;
                }
                for (int i = 0; i + gap < arraySize; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        Swap(ref array[i], ref array[i + gap]);
                        sorted = false;
                    }
                }
            } while (!sorted);
        }
    }
    class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            Array.Sort(array);
        }
    }
}
