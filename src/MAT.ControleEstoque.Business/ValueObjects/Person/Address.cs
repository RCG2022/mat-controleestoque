namespace MAT.ControleEstoque.Business.ValueObjects.Person
{
    public class Address
    {
        public string Value { get; private set; }

        public Address(string value)
        {
            Value = value;
        }
    }
}
