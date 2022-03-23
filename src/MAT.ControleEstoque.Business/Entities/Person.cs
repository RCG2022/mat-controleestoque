namespace MAT.ControleEstoque.Business.Entities
{
    public class Person
    {
        public Guid Id { get; private set; }

        public string FullName { get; private set; }

        public string Email { get; private set; }

        public string Phone { get; private set; }

        public string Address { get; private set; }

        public Person(
            Guid id, 
            string fullName, 
            string email, 
            string phone, 
            string address
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
