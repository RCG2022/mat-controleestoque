using MAT.ControleEstoque.Business.ValueObjects.Person;

namespace MAT.ControleEstoque.Business.Entities
{
    public class Person
    {
        public Guid Id { get; private set; }

        public FullName FullName { get; private set; }

        public Email Email { get; private set; }

        public Phone Phone { get; private set; }

        public Address Address { get; private set; }

        public Person(
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
