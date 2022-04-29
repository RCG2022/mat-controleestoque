using MAT.ControleEstoque.App.ViewModel;
using MAT.ControleEstoque.Business.Entities;
using MAT.ControleEstoque.Business.Interfaces;

namespace MAT.ControleEstoque.App
{
    public partial class frmUserSearch : Form
    {
        private IUserRepository _userRepository;
        private IEnumerable<User> _users;

        public User? SelectedUser { get; set; }

        public frmUserSearch(IUserRepository _SystemUserRepository)
        {
            _userRepository = _SystemUserRepository;
            InitializeComponent();
        }

        private List<SystemUserViewModel> ConvertSystemUserViewModel(IEnumerable<User> users)
        {
            var userList = new List<SystemUserViewModel>();
            foreach (var systemUser in users)
            {
                var SystemUserViewModel = new SystemUserViewModel
                {
                    Id = systemUser.Id,
                    Login = systemUser.Login.Value,
                    Enabled = systemUser.Enabled,
                };

                userList.Add(SystemUserViewModel);
            }

            return userList;
        }
        private void findUser()
        {
            var fullname = txtFullName.Text;
            _users = _userRepository.FindAll(fullname);
            var data = ConvertSystemUserViewModel(_users);
            dgvUser.DataSource = data.ToList();
        }

        private void frmUserSearch_Load(object sender, EventArgs e)
        {
            findUser();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
