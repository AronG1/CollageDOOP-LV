using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LV_4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int rowCount = data.Length;
            int colCount = data[0].Length;
            double[] results = new double[colCount];
            double temp;
            for (int i = 0; i < rowCount; i++)
            {
                temp = 0;
                for (int j = 0; j < colCount; j++)
                {
                    temp = temp + data[i][j];
                }
                results[i] = temp / rowCount;
            }
            return results;
        }

    }
}
