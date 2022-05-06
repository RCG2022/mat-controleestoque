using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.Interfaces;
using MAT.ControleEstoque.Business.ValueObjects.User;
using MAT.ControleEstoque.Data.Builder;
using MAT.ControleEstoque.Data.Configurations;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.Repositories;
namespace MAT.ControleEstoque.App
{
    public partial class frmUser : Form
    {
        IUserRepository _userRepository;
        private const string INVALID_ENABLE  = "Selecione Habilitar ou Desabilitar para realizar o cadastro";
        public frmUser()
        {
            var dbConfig = new DbConfig
            {
                ConnectionString = "Server=localhost;Database=Mat_ControleEstoque;User Id=sa;Password=paula@123",
                Schema = "dbo"
            };

            var dbService = new DbService(dbConfig);
            var userBuilder = new SystemUserBuilder(dbService);

            _userRepository = new UserRepository(dbService, userBuilder);
            
            InitializeComponent();
        }

        private void ClearSpans()
        {
             spanLogin.Text = string.Empty;
             spanPassword.Text = string.Empty;
             spanEnable.Text = string.Empty;
        }


        private Login GetLogin()
        {
            try
            {
                return new Login(txtLogin.Text);
            }
            catch (ArgumentException ex)
            {
                    spanLogin.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        private Password GetPassword()
        {
            try
            {
                return new Password(txtPassword.Text);
            }
            catch (ArgumentException ex)
            {
                spanPassword.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        private bool GetEnable()
        {
            try
            {
                if (chkBoxHabilitado.Checked)
                {
                    return true;
                }
                if (chkBoxDesabilitado.Checked)
                {
                    return false;
                }
                else
                {
                    throw new ArgumentException(INVALID_ENABLE);
                    
                }

            }
            catch (ArgumentException ex)
            {
                spanEnable.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
           ClearSpans();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var form = FormUtils.GetForm<frmUserSearch>();
            form.FormClosed += (s, args) => LoadUser(form.SelectedUser);
            form.ShowDialog();
        }
        private void LoadUser(User? user)
        {
            if (user is not null)
            {
                ClearSpans();
                txtId.Text = user.Id.ToString();
                txtLogin.Text = user.Login.Value;
                btnSave.Enabled = true;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            var userOption = MessageBox.Show("Deseja adicionar um novo Usuário? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (userOption == DialogResult.No)
                return;

            ClearSpans();
            if (GetEnable() == false && chkBoxDesabilitado.Checked == false)
                return;

            var  login = GetLogin();
            var  password = GetPassword();
            bool enable = GetEnable();

            if (login is null || password is null)
                return;

            var user = new User(
                Guid.NewGuid(),
                login,
                password,
                enable
                );

            _userRepository.Insert(user);

            MessageBox.Show("Usuário adicionado com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void chkBoxHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxHabilitado.Checked)
                chkBoxDesabilitado.Checked = false;
        }

        private void chkBoxDesabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxDesabilitado.Checked)
                chkBoxHabilitado.Checked = false;
        }
    }
}
