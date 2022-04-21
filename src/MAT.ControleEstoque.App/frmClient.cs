using MAT.ControleEstoque.App.Extensions;
using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.Interfaces;
using MAT.ControleEstoque.Business.ValueObjects.Client;
using MAT.ControleEstoque.Data.Builder;
using MAT.ControleEstoque.Data.Configurations;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.Repositories;

namespace MAT.ControleEstoque.App
{
    public partial class frmClient : Form
    {
        IClientRepository _clientRepository;

        public frmClient()
        {
            var dbConfig = new DbConfig
            {
                ConnectionString = "Server=localhost;Database=Mat_ControleEstoque;User Id=sa;Password=paula@123",
                Schema = "dbo"
            };

            var dbService = new DbService(dbConfig);
            var clientBuilder = new ClientBuilder(dbService);

            _clientRepository = new ClientRepository(dbService, clientBuilder);

            InitializeComponent();
        }

        private void ClearSpans()
        {
            spanFullName.Text = string.Empty;
            spanEmail.Text = string.Empty;
            spanPhone.Text = string.Empty;
            spanAddress.Text = string.Empty;
        }

        private FullName GetFullName()
        {
            try
            {
                return new FullName(txtFullName.Text);
            }
            catch (ArgumentException ex)
            {
                spanFullName.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        private Email GetEmail()
        {
            try
            {
                return new Email(txtEmail.Text);
            }
            catch (ArgumentException ex)
            {
                spanEmail.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        private Phone GetPhone()
        {
            try
            {
                return new Phone(txtPhone.Text);
            }
            catch (ArgumentException ex)
            {
                spanPhone.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        private Address GetAddress()
        {
            try
            {
                return new Address(txtAddress.Text);
            }
            catch (ArgumentException ex)
            {
                spanAddress.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        private void LoadClient(Client? client)
        {
            if (client is not null)
            {
                ClearSpans();
                txtId.Text = client.Id.ToString();
                txtFullName.Text = client.FullName.Value;
                txtEmail.Text = client.Email.Value;
                txtPhone.Text = client.Phone.Value;
                txtAddress.Text = client.Address.Value;
                btnSave.Enabled = true;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            ClearSpans();
        }

        private  void btnAdd_Click(object sender, EventArgs e)
        {
            ClearSpans();

            var fullname = GetFullName();
            var email = GetEmail();
            var phone = GetPhone();
            var address = GetAddress();

            if (fullname is null || email is null || phone is null || address is null)
                return;

            var client = new Client(
                Guid.NewGuid(),
                fullname,
                email,
                phone,
                address
                );

            _clientRepository.Insert(client);

            MessageBox.Show("O cliente foi adicionado com sucesso.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var form = FormUtils.GetForm<frmClientSearch>();
            form.FormClosed += (s, args) => LoadClient(form.SelectedClient);
            form.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            ClearSpans();

            var id = new Guid(txtId.Text);
            var fullname = GetFullName();
            var email = GetEmail();
            var phone = GetPhone();
            var address = GetAddress();

            if (fullname is null || email is null || phone is null || address is null)
                return;

            var client = new Client(
                id,
                fullname,
                email,
                phone,
                address
                );

            _clientRepository.Update(client);

            MessageBox.Show("O cliente foi atualizado com sucesso.");
            this.Close();
        }
    }
}