using MAT.ControleEstoque.Business.ValueObjects.Client;

namespace MAT.ControleEstoque.Business.Entities
{
    public class Client
    {
        public Guid Id { get; private set; }

        public FullName FullName { get; protected set; }

        public Email Email { get; set; }

        public Phone Phone { get; private set; }

        public Address Address { get; private set; }

        public Client(
            Guid id, 
            FullName fullName, 
            Email email, 
            Phone phone, 
            Address address
            )
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Phone = phone;
            Address = address;
        }
    }
}
