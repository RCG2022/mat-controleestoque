namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class DiscountPrice
    {
        private const string INVALID_VALUE_NULL = "É necessario informar o valor do produto com o maximo de desconto possivel";

        public float Value { get; private set; }

        public DiscountPrice(float value)
        {
            if (value < 1)
                throw new ArgumentException(INVALID_VALUE_NULL);

            Value = value;
        }
    }
}
