namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class MinimumStock
    {
        private const string INVALID_VALUE_NULL = "É necessario informar a quantidade minima que este produto deve ter no estoque";

        public int Value { get; private set; }

        public MinimumStock(int value)
        {
            if(value == null)
                throw new ArgumentException(INVALID_VALUE_NULL);

            Value = value;
        }
    }
}
