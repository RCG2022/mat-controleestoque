using System;
using Xunit;

namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class MinimumStockTest
    {
        private const string INVALID_VALUE_NULL = "É necessario informar a quantidade minima que este produto deve ter no estoque";

        [Fact]
        public void ValidateNull()
        {
            var minimumStock = 5;

            var result = new MinimumStock(minimumStock);

            Assert.True(result.Value == null);
        }
    }
}
