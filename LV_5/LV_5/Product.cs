using System;
using System.Collections.Generic;
using System.Text;

namespace LV_5
{
    interface IBillable : IShipable
    {
        double Price { get; }
        string ShippingDescription(int depth = 0);
    }
    interface IShipable
    {
        double Price { get; }
        double Weight { get; }
        string Description(int depth = 0);
    }
    class Product : IBillable
    {
        private double price;
        private string description;
        public string shippingDescription = "";
        public double weight = 1.0;
        public Product(string description, double price)
        {
            this.description = description;
            this.price = price;
        }
        public double Price { get { return this.price; } }
        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }
        public string ShippingDescription(int depth = 0)
        {
            return new string(' ', depth) + this.shippingDescription;
        }
        public double Weight { get { return this.weight; } }
    }
}
