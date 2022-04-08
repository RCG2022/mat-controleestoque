using MAT.ControleEstoque.Business.ValueObjects.Client;

namespace MAT.ControleEstoque.Business.Entities
{
    public class Client
    {
        private string name;
        private string v1;
        private string v2;
        private string v3;

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

        public Client(Guid id, string name, string v1, string v2, string v3)
        {
            Id = id;
            this.name = name;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}
