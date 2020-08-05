using System;

namespace ConsoleApp3
{
    class Program
    {
        private const decimal UnitPrice = 8m;

        static void Main(string[] args)
        {
            const int numberOfBooks = 8;
            var book = new Book(UnitPrice, numberOfBooks);
            var discountedPrice = book.CalculateDiscountedPrice();
            var totalPrice = book.TotalPrice;
           

            Console.WriteLine($"Total Price: {totalPrice} & Discounted Price: {discountedPrice}");
        }
    }
}