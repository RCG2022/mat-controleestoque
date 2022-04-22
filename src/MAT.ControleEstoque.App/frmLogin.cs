using MAT.ControleEstoque.App.Extensions;
using MAT.ControleEstoque.Business.Interfaces;
using MAT.ControleEstoque.Business.ValueObjects.User;

namespace MAT.ControleEstoque.App
{
    public partial class frmLogin : Form
    {
        IUserRepository _userRepository;
        IAppService _appService;

        public frmLogin(IUserRepository userRepository, IAppService appService)
        {
            _appService = appService;
            _userRepository = userRepository;
            InitializeComponent();
        }

        private void clearSpan() 
        {
            spanPassword.Text = string.Empty;
            spanLogin.Text = string.Empty;
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
                FormUtils.AlertError(ex.Message, "Erro não identificado");
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
                FormUtils.AlertError(ex.Message, "Erro não identificado");
            }
            return null;
        }

        private void btnEnter_MouseHover(object sender, EventArgs e)
        {
            btnEnter.BackColor = Color.SteelBlue;
        }

        private void btnEnter_MouseLeave(object sender, EventArgs e)
        {
            btnEnter.BackColor = Color.White;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                clearSpan();
                var login = GetLogin();
                var password = GetPassword();

                if (login is null || password is null)
                    return;

                var user = _userRepository.Login(login, password);

                if (user is null)
                {
                    FormUtils.AlertWarning("Login ou senha invalidos", "Autenticação invalida");
                    return;
                }

                if (!user.Enabled)
                {
                    FormUtils.AlertWarning($"O usuario {user.Login.Value} está desabilitado", "Usuario desabilitado");
                    return;
                }

                _appService.SetLoggedUser(user);

                this.Hide();
                var form = FormUtils.GetForm<frmMain>();
                form.FormClosed += (s, args) => this.Show();
                form.Show();
            }
            catch (Exception ex)
            {
                FormUtils.AlertError(ex.Message, "Erro inesperado");
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            clearSpan();
        }
    }
}
