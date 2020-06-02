using System;
using System.Collections.Generic;
using System.Text;

namespace LV_4
{
    class DiscountedItem : RentableDecorator
    {
        private readonly double DiscountItemCoeficient = 0.85;
        public DiscountedItem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() * this.DiscountItemCoeficient;
        }
        public override String Description
        {
            get
            {
                return "Discount: " + base.Description;
            }
        }
    }
}
