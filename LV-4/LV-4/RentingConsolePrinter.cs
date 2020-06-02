using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LV_4
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
    class RentingConsolePrinter
    {
        public void PrintTotalPrice(List<IRentable> items)
        {
            Console.WriteLine(items.Sum(r => r.CalculatePrice()));
        }
        public void DisplayItems(List<IRentable> items)
        {
            items.ForEach(r => Console.WriteLine(r.Description));
        }

    }
}
