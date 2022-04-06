namespace MAT.ControleEstoque.Data.View
{
    public class SystemUserView
    {
        public Guid Id { get; set; }

        public Guid IdPerson { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public bool Enabled { get; set; }
    }
}
