using MAT.ControleEstoque.Business.ValueObjects.User;

namespace MAT.ControleEstoque.Business.Entities
{
    public class User
    {
        public Guid Id { get; private set; }

        public Guid IdClient { get; private set; }

        public Login Login { get; private set; }

        public Password Password { get; private set; }

        public bool Enabled { get; private set; }

        public User(
            Guid id, 
            Guid idClient, 
            string login, 
            string password, 
            bool enabled
            )
        {
            Id = id;
            IdClient = idClient;
            Login = new Login(login);
            Password = new Password(password);
            Enabled = enabled;
        }

        public User(
            Guid id,
            Guid idClient, 
            Login login, 
            Password password, 
            bool enabled
            )
        {
            Id = id;
            IdClient = idClient;
            Login = login;
            Password = password;
            Enabled = enabled;
        }
    }
}
