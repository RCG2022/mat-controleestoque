using MAT.ControleEstoque.App.ViewModel;
using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.Interfaces;

namespace MAT.ControleEstoque.App
{
    public partial class frmClientSearch : Form
    {
        private IClientRepository _clientRepository;
        private IEnumerable<Client> _clients;

        public Client? SelectedClient { get; set; }

        public frmClientSearch(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
            InitializeComponent();
        }
        
        private List<ClientViewModel> ConvertClientViewModel(IEnumerable<Client> clients)
        {
            var clientList = new List<ClientViewModel>();
            foreach (Client client in clients)
            {
                var clientViewModel = new ClientViewModel { 
                    Id = client.Id,
                    FullName = client.FullName.Value,
                    Email = client.Email.Value,
                    Phone = client.Phone.Value,
                    Address = client.Address.Value,  
                };

                clientList.Add(clientViewModel);
            }

            return clientList; 
        }

        private void FindClients()
        {
            var fullname = txtFullName.Text;
            _clients = _clientRepository.FindAll(fullname);
            var data = ConvertClientViewModel(_clients);
            dgvClients.DataSource = data.ToList();
        }

        private void SelectUser()
        {

            if (dgvClients.SelectedCells.Count == 1)
            {
                var index = dgvClients.CurrentCell.RowIndex;
                var id = (Guid)dgvClients.Rows[index].Cells[0].Value;
                SelectedClient = _clients.FirstOrDefault(x => x.Id == id);
                this.Close();
            }
        }


        private void frmClientSearch_Load(object sender, EventArgs e)
        {
            FindClients();
        }

        
        private void btnFilter_Click(object sender, EventArgs e)
        {
            FindClients();
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {
            SelectUser();
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedCells.Count == 1)
            {
                btnSelected.Enabled = true;
            }
            else
            {
                btnSelected.Enabled = false;
            }
        }

        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectUser();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
