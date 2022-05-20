namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class MinimumStock
    {
        private const string INVALID_VALUE_MIN = "A quantidade minima que esse produto deverá ter no estoque é 1";

        public int Value { get; private set; }

        public MinimumStock(int value)
        {
            if(value < 1)
                throw new ArgumentException(INVALID_VALUE_MIN);
            Value = value;
        }
    }
}
