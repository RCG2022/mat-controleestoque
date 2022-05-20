using System;
using Xunit;

namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class MinimumStockTest
    {
        private const string INVALID_VALUE_MIN = "A quantidade minima que esse produto deverá ter no estoque é 1";

        [Fact]
        public void ValidateTrue()
        {
            var minimumStock = 4;

            var result = new MinimumStock(minimumStock);

            Assert.True(result.Value == minimumStock);
        }

        [Fact]

        public void ValidateValueMin()
        {
            var minimumStock = -5;

            var message = Assert.Throws<ArgumentException>(() => new MinimumStock(minimumStock)).Message;

            Assert.True(message == INVALID_VALUE_MIN);
            
        }
    }
}
