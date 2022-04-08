using MAT.ControleEstoque.Business.ValueObjects.User;

namespace MAT.ControleEstoque.Business.Entities
{
    public class User
    {
        public Guid Id { get; private set; }

        public Login Login { get; private set; }

        public Password Password { get; private set; }

        public bool Enabled { get; private set; }

        public User(
            Guid id,
            Login login, 
            Password password, 
            bool enabled
            )
        {
            Id = id;
            Login = login;
            Password = password;
            Enabled = enabled;
        }
    }
}
