using MAT.ControleEstoque.Business.Entities;

namespace MAT.ControleEstoque.Business.Interfaces
{
    public interface IClientRepository
    {
        public Client FindById(Guid id);

        public List<Client> FindAll(string fullName);

        public void Insert(Client client);

        public void Update(Client client);
    }
}
