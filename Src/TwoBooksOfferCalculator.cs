using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class TwoBooksOfferCalculator : OfferCalculator
    {
        public TwoBooksOfferCalculator(decimal unitPrice, int numberOfBooks) : base(unitPrice, numberOfBooks)
        {
            Threshold = 2;
            DiscountPercentage = 5m;
        }
    }
}
