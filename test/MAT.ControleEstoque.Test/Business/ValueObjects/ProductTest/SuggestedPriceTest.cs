using System;
using Xunit;

namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class SuggestedPriceTest
    {
        private const string INVALID_VALUE_NULL = "O valor de venda desse produto deve ser maio que R$ 0,00";
        
        [Fact]

        public void ValidateTrue()
        {
            float suggestedPrice = 20;

            var result = new SuggestedPrice(suggestedPrice);

            Assert.True(result.Value == suggestedPrice);

        }

        [Fact]

        public void ValidateNull()
        {
            float suggestedPrice = 0;

            var message = Assert.Throws<ArgumentException>(() => new SuggestedPrice(suggestedPrice)).Message;

            Assert.True(message == INVALID_VALUE_NULL);
        }
    }
}
