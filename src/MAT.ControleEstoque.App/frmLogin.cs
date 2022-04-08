using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAT.ControleEstoque.App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }      

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clearSpan();
        }

        private void clearSpan() 
        {
            spanPassword.Text = string.Empty;
            spanLogin.Text = string.Empty;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_MouseDown(object sender, MouseEventArgs e)
        {
            btnEnter.BackColor = Color.SteelBlue;
        }
    }
}
