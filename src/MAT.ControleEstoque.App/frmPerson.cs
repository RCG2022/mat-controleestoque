using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.Interfaces;
using MAT.ControleEstoque.Business.ValueObjects.Person;
using MAT.ControleEstoque.Data.Builder;
using MAT.ControleEstoque.Data.Configurations;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.Repositories;

namespace MAT.ControleEstoque.App
{
    public partial class frmPerson : Form
    {
        IPersonRepository _personRepository;

        public frmPerson()
        {
            var dbConfig = new DbConfig
            {
                ConnectionString = "Server=localhost;Database=Mat_ControleEstoque;User Id=sa;Password=paula@123",
                Schema = "dbo"
            };

            var dbService = new DbService(dbConfig);
            var personBuilder = new PersonBuilder(dbService);

            _personRepository = new PersonRepository(dbService, personBuilder);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            ClearSpans();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            ClearSpans();

            var fullname = GetFullName();
            var email = GetEmail();
            var phone = GetPhone();
            var address = GetAddress();

            if (fullname is null || email is null || phone is null || address is null)
                return;

            var person = new Person(
                Guid.NewGuid(),
                fullname,
                email,
                phone,
                address
                );

            await _personRepository.Add(person);

            MessageBox.Show("O cliente foi adicionado com sucesso.");
        }
    }
}