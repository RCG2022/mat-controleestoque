using MAT.ControleEstoque.Business.ValueObjects.Product;

namespace MAT.ControleEstoque.Business.Entities
{
    public class Product
    {

        public Guid Id { get; private set; }

        public Name Name { get; protected set; }

        public Indentifier Indentifier { get; set; }

        public Detail Detail { get; set; }

        public MinimumStock MinimumStock { get; private set; }
        
        public SuggestedPrice SuggestedPrice { get; private set; }
        
        public DiscountPrice Price { get; private set; }


        public Product(
            Guid id,
            Name name,
            Indentifier indentifier,
            Detail detail,
            MinimumStock minimumStock,
            DiscountPrice price,
            SuggestedPrice suggestedPrice
            )
        {
            Id = id;
            Name = name;
            Indentifier = indentifier;
            Detail = detail;
            MinimumStock = minimumStock;
            Price = price;
            SuggestedPrice = suggestedPrice;
        }





    }
}
