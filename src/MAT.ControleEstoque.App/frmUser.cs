using MAT.ControleEstoque.App.Extensions;
using MAT.ControleEstoque.Business.Entities;

namespace MAT.ControleEstoque.App
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
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
                txtlogin.Text = user.Login.Value;
                btnSave.Enabled = true;
            }
        }
        private void ClearSpans()
        {
            
        }

    }
}