using System;
using System.Collections.Generic;
using System.Text;

namespace LV_5
{
    class ShippingService
    {
        private double ShippingPriceperkg = 3.50;
        public double ShippingPrice(IShipable package)
        {
            return package.Weight * ShippingPriceperkg;
        }
    }
}
