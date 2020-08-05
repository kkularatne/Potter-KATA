namespace ConsoleApp3
{
    public abstract class OfferCalculator
    {
        private readonly decimal _unitPrice;
        private readonly int _numberOfBooks;
        public int Threshold { get; set; }
        public decimal DiscountPercentage { get; set; }

        protected OfferCalculator(decimal unitPrice, int numberOfBooks)
        {
            _unitPrice = unitPrice;
            _numberOfBooks = numberOfBooks;
        }

        public decimal CalculateOffer()
        {
            var books = _numberOfBooks / Threshold;
            var originalPrice = _unitPrice * books * Threshold;
            var markdown = originalPrice * (DiscountPercentage / 100);
            return originalPrice - markdown;
        }

        public int Modulus()
        {
            return _numberOfBooks % Threshold;
        }
    }
}
