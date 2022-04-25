using MAT.ControleEstoque.App.Extensions;
using MAT.ControleEstoque.Business.Interfaces;

namespace MAT.ControleEstoque.App
{
    public partial class frmMain : Form
    {
        private readonly IAppService _appService;
        public frmMain(IAppService appService)
        {
            _appService = appService;
            InitializeComponent();
        }

        private void AddTabPage<F>(string title) where F : Form
        {
            var form = FormUtils.GetForm<F>();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            var tabPage = new TabPage(title);
            tabControlMain.TabPages.Add(tabPage);
            tabPage.Controls.Add(form);
            tabControlMain.SelectedTab = tabPage;

            form.FormClosed += (s, args) => RemoveTabPage(tabPage);
            form.Show();
        }

        private void RemoveTabPage(TabPage tabPage)
        {
            tabControlMain.Controls.Remove(tabPage);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void menuItemClient_Click(object sender, EventArgs e)
        {
            AddTabPage<frmClient>("Cliente");
        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtUser.Text = _appService.GetLoggedUser().Login.Value;
        }

        private void menuItemUser_Click(object sender, EventArgs e)
        {
           AddTabPage<frmUser>("Usuario");
        }
    }
}
