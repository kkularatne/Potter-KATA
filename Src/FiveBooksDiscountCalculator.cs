namespace ConsoleApp3
{
    class FiveBooksDiscountCalculator : OfferCalculator
    {
        public FiveBooksDiscountCalculator(decimal unitPrice, int numberOfBooks) : base(unitPrice, numberOfBooks)
        {
            Threshold = 5;
            DiscountPercentage = 25m;
        }
    }
}
