namespace ConsoleApp3
{
    public class FourBooksDiscountCalculator : OfferCalculator
    {
        public FourBooksDiscountCalculator(decimal unitPrice, int numberOfBooks) : base(unitPrice, numberOfBooks)
        {
            Threshold = 4;
            DiscountPercentage = 20m;
        }
    }
}
