using System;
using ConsoleApp3;
using Xunit;

namespace XUnitTestProject
{
    public class BookTest
    {
        [Theory]
        [InlineData(1, "8.00")]
        [InlineData(2, "15.20")]
        [InlineData(3, "21.60")]
        [InlineData(4, "25.60")]
        [InlineData(5, "30.00")]
        [InlineData(6, "38.00")]
        [InlineData(7, "45.20")]
        [InlineData(8, "51.60")]
        [InlineData(9, "55.60")]
        [InlineData(10, "60.00")]
        [InlineData(11, "68.00")]
        [InlineData(12, "75.20")]
        public void CalculateDiscountedPrice_Test(int bookCount, string expectedDiscountedPrice)
        {
            // Arrange
            var unitPrice = 8m;
            var book = new Book(unitPrice, bookCount);

            // Act
            var result = book.CalculateDiscountedPrice();

            // Assert
            Assert.Equal(Convert.ToDecimal(expectedDiscountedPrice), result);
        }
    }
}
