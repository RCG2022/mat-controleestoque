using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.Interfaces;
using MAT.ControleEstoque.Business.ValueObjects.Client;
using MAT.ControleEstoque.Data.Builder;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.View;

namespace MAT.ControleEstoque.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        protected readonly IDbService _dbService;
        private readonly IClientBuilder _clientBuilder;

        public ClientRepository(IDbService dbService, IClientBuilder clientBuilder)
        {
            _dbService = dbService;
            _clientBuilder = clientBuilder;
        }

        public Client FindById(Guid id)
        {
            var request = _clientBuilder.FindByIdRequest(id);
            var clientView = _dbService.ExecuteQueryFirstOrDefault<ClientView>(request);

            if (clientView is null)
                return null;

            var client = new Client(
                clientView.Id,
                new FullName(clientView.FullName),
                new Email(clientView.Email),
                new Phone(clientView.Telephone),
                new Address(clientView.Address)
                );

            return client;
        }

        
        
        public void Insert(Client client)
        {
            var clientView = new ClientView();
            clientView.Id = client.Id;
            clientView.FullName = client.FullName.Value;
            clientView.Email = client.Email.Value;
            clientView.Telephone = client.Phone.Value;
            clientView.Address = client.Address.Value;

            var request = _clientBuilder.InsertRequest(clientView);

            _dbService.ExecuteCommandRequest(request);
        }

        public IEnumerable<Client> FindAll(string fullName)
        {
            var request = _clientBuilder.FindAllRequest(fullName);
            var clientViewList = _dbService.ExecuteQueryRequest<ClientView>(request);

            var clientList = new List<Client>();

            foreach(var clientView in clientViewList)
            {
                var client = new Client(
                clientView.Id,
                new FullName(clientView.FullName),
                new Email(clientView.Email),
                new Phone(clientView.Telephone),
                new Address(clientView.Address)
                );

                clientList.Add(client);
            }

            return clientList;
        }

        public void Update (Client client)
        {
            var clientview = new ClientView();
            clientview.Id = client.Id;
            clientview.FullName = client.FullName.Value;
            clientview.Email = client.Email.Value;
            clientview.Telephone = client.Phone.Value;
            clientview.Address = client.Address.Value;

            var request = _clientBuilder.UpdateRequest(clientview);

            _dbService.ExecuteCommandRequest(request);
            
        }
    }
}
