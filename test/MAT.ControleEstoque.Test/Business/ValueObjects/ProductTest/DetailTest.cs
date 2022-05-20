using Xunit;

namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class DetailTest
    {
        [Fact]

        public void ValidateTrue()
        {
            var detail = " Detalhes do produto - Detalhes do produto - Detalhes do produto - Detalhes do produto ";

            var result = new Detail(detail);

            Assert.True(result.Value == detail);
        }

    }
}
