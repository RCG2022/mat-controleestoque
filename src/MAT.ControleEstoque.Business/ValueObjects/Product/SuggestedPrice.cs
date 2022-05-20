namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class SuggestedPrice
    {
        private const string INVALID_VALUE_NULL = "O valor de venda desse produto deve ser maio que R$ 0,00";
       
        public float Value { get; private set; }

        public SuggestedPrice(float value)
        {
            if (value < 1)
                throw new ArgumentException(INVALID_VALUE_NULL);

            Value = value;
        }
    }
}
