using System;
using Xunit;

namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class DiscountPriceTest
    {
        private const string INVALID_VALUE_NULL = "É necessario informar o valor do produto com o maximo de desconto possivel";

       
        [Fact]

        public void ValidateTrue()
        {
            float discountPrice = 20;

            var result = new DiscountPrice(discountPrice);

            Assert.True(result.Value == discountPrice);
        }

        [Fact]

        public void ValidateNull()
        {
            float discountPrice = 0;

            var message = Assert.Throws<ArgumentException>(() => new DiscountPrice(discountPrice)).Message;

            Assert.True(message == INVALID_VALUE_NULL);
        }
    }
}
