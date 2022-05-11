using MAT.ControleEstoque.App.Extensions;
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
        User _userselect;

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
                _userselect = user;
                ClearSpans();
                txtId.Text = user.Id.ToString();
                txtLogin.Text = user.Login.Value;
                chkBoxHabilitado.Checked = user.Enabled;
                btnSave.Enabled = true;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            var userOption = MessageBox.Show("Deseja adicionar um novo Usuário? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (userOption == DialogResult.No)
                return;

            ClearSpans();
            var  login = GetLogin();
            var  password = GetPassword();

            if (login is null || password is null)
                return;

            var verifica = _userRepository.CheckLogin(login);

            if (verifica) 
            {
                MessageBox.Show("O login já está sendo utilizado");
                return;
            }

            var user = new User(
                Guid.NewGuid(),
                login,
                password,
                chkBoxHabilitado.Checked
                );

            _userRepository.Insert(user);

            MessageBox.Show("Usuário adicionado com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClearSpans();

            var userOption = MessageBox.Show("Deseja atualizar os dados do usuario? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (userOption == DialogResult.No)
                return;

            var id = new Guid(txtId.Text);
            var login = GetLogin();
            
            if (login is null)
                return;

            var verifica = _userRepository.CheckLogin(login);
            if (verifica && login.Value != _userselect.Login.Value )
            {
                MessageBox.Show("O login já está sendo utilizado");
                return;
            }

            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                var passwordOption = MessageBox.Show("Deseja atualizar a senha? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (passwordOption == DialogResult.Yes)
                {
                    var password = GetPassword();
                    if (password is null)
                        return ;

                    _userRepository.UpdatePassword(id, password); 
                }

            }


            var user = new User(
                id,
                login,
                chkBoxHabilitado.Checked
                );

            _userRepository.Update(user);

            MessageBox.Show("Usuario atualizado com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    
    }   
}