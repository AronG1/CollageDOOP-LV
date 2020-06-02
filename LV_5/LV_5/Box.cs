using System;
using System.Collections.Generic;
using System.Text;

namespace LV_5
{
    class Box : IBillable
    {
        private List<IBillable> items;
        private string name;
        public Box(string name)
        {
            this.items = new List<IBillable>();
            this.name = name;
        }
        public void Add(IBillable item)
        {
            this.items.Add(item);
        }
        public void Remove(IBillable item)
        {
            this.items.Remove(item);
        }
        public double Price
        {
            get
            {
                double totalPrice = 0;
                foreach (IBillable item in items)
                {
                    totalPrice += item.Price;
                }
                return totalPrice;
            }
        }
        public string Description(int depth = 0)
        {
            StringBuilder builder =
           new StringBuilder(new string(' ', depth) + this.name + "\n");
            foreach (IBillable item in items)
            {
                builder.Append(item.Description(depth + 2)).Append("\n");
            }
            return builder.ToString();
        }
        public string ShippingDescription(int depth = 0)
        {
            StringBuilder builder =
           new StringBuilder(new string(' ', depth) + this.name + "\n");
            foreach (IBillable item in items)
            {
                builder.Append(item.Description(depth + 2)).Append("\n");
            }
            return builder.ToString();
        }
        public double Weight
        {
            get
            {
                double totalWeight = 0;
                foreach (IShipable item in items)
                {
                    totalWeight += item.Weight;
                }
                return totalWeight;
            }
        }
    }
}
