namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class DiscountPrice
    {
        private const string INVALID_VALUE_NULL = "Informe o valor com o maximo de desconto desse produto";

        public float Value { get; private set; }

        public DiscountPrice(float value)
        {
            if (value == null)
                throw new ArgumentException(INVALID_VALUE_NULL);

            Value = value;
        }
    }
}
