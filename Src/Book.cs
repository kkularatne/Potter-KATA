using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Book
    {
        public int Count { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal TotalPrice
        {
            get => UnitPrice * Count; 
        }

        public Book(decimal unitPrice, int count)
        {
            Count = count;
            UnitPrice = unitPrice;
        }

        public decimal CalculateDiscountedPrice()
        {
            var fiveBooksDiscountCalculator = new FiveBooksDiscountCalculator(UnitPrice, Count);
            var fiveBooksDiscount = fiveBooksDiscountCalculator.CalculateOffer();
            var fiveModulus = fiveBooksDiscountCalculator.Modulus();

            var fourBooksDiscountCalculator = new FourBooksDiscountCalculator(UnitPrice, fiveModulus);
            var fourBooksDiscount = fourBooksDiscountCalculator.CalculateOffer();
            var fourModulus = fourBooksDiscountCalculator.Modulus();

            var threeBooksDiscountCalculator = new ThreeBooksDiscountCalculator(UnitPrice, fourModulus);
            var threeBooksDiscount = threeBooksDiscountCalculator.CalculateOffer();
            var threeModulus = threeBooksDiscountCalculator.Modulus();

            var twoBooksOfferCalculator = new TwoBooksOfferCalculator(UnitPrice, threeModulus);
            var twoBooksDiscount = twoBooksOfferCalculator.CalculateOffer();
            var twoModulus = twoBooksOfferCalculator.Modulus();

            var nonDiscountedBooks = twoModulus * UnitPrice;

            var total = fiveBooksDiscount + fourBooksDiscount + threeBooksDiscount + twoBooksDiscount +
                        nonDiscountedBooks;

            return total;
        }

    }
}
