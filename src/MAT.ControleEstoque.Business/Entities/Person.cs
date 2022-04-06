using MAT.ControleEstoque.Business.ValueObjects.Person;

namespace MAT.ControleEstoque.Business.Entities
{
    public class Person
    {
        public Guid Id { get; private set; }

        public FullName FullName { get; protected set; }

        public Email Email { get; set; }

        public Phone Phone { get; private set; }

        public Address Address { get; private set; }

        public Person(
            Guid id,
            string fullName,
            string email,
            string phone,
            string address
        )
        {
            Id = id;
            FullName = new FullName(fullName);
            Email = new Email(email);
            Phone = new Phone(phone);
            Address = new Address(address);
        }
    }
}
