using System;
using System.Collections.Generic;
using System.Text;
using LV_3;

namespace LV_4
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(LV_3.Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
    class Adapter
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            int rowCount = dataset.GetData().Count;
            double[][] data = new double[rowCount][];
            int rowCounter = 0, colCounter = 0;
            foreach (List<string> sublist in dataset.GetData())
            {
                data[rowCounter] = new double[sublist.Count];
                foreach (string s in sublist)
                {
                    colCounter = 0;
                    data[rowCounter][colCounter] = Convert.ToDouble(s);
                    colCounter++;
                }
                rowCounter++;
            }
            return data;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }

    }
}
