namespace MAT.ControleEstoque.Business.Entities
{
    public class User
    {
        public Guid Id { get; private set; }

        public Guid IdPerson { get; private set; }

        public string Login { get; private set; }

        public string Password { get; private set; }

        public bool Enabled { get; private set; }

        public User(
            Guid id, 
            Guid idPerson, 
            string login, 
            string password, 
            bool enabled
            )
        {
            Id = id;
            IdPerson = idPerson;
            Login = login;
            Password = password;
            Enabled = enabled;
        }
    }
}
