namespace ConsoleApp3
{
    public class ThreeBooksDiscountCalculator : OfferCalculator
    {
        public ThreeBooksDiscountCalculator(decimal unitPrice, int numberOfBooks) : base(unitPrice, numberOfBooks)
        {
            Threshold = 3;
            DiscountPercentage = 10m;
        }
    }
}
