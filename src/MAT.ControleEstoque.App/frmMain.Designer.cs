namespace MAT.ControleEstoque.App
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSell = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSystem,
            this.menuItemAdministration});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuItemSystem
            // 
            this.menuItemSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUser,
            this.menuItemClient,
            this.menuItemChangePassword,
            this.menuItemClose});
            this.menuItemSystem.Name = "menuItemSystem";
            this.menuItemSystem.Size = new System.Drawing.Size(60, 20);
            this.menuItemSystem.Text = "Sistema";
            // 
            // menuItemUser
            // 
            this.menuItemUser.Name = "menuItemUser";
            this.menuItemUser.Size = new System.Drawing.Size(143, 22);
            this.menuItemUser.Text = "Usuários";
            // 
            // menuItemClient
            // 
            this.menuItemClient.Name = "menuItemClient";
            this.menuItemClient.Size = new System.Drawing.Size(143, 22);
            this.menuItemClient.Text = "Clientes";
            this.menuItemClient.Click += new System.EventHandler(this.menuItemClient_Click);
            // 
            // menuItemChangePassword
            // 
            this.menuItemChangePassword.Name = "menuItemChangePassword";
            this.menuItemChangePassword.Size = new System.Drawing.Size(143, 22);
            this.menuItemChangePassword.Text = "Alterar senha";
            // 
            // menuItemClose
            // 
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.Size = new System.Drawing.Size(143, 22);
            this.menuItemClose.Text = "Sair";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // menuItemAdministration
            // 
            this.menuItemAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemProduct,
            this.menuItemStock,
            this.menuItemSell});
            this.menuItemAdministration.Name = "menuItemAdministration";
            this.menuItemAdministration.Size = new System.Drawing.Size(97, 20);
            this.menuItemAdministration.Text = "Administrativo";
            // 
            // menuItemProduct
            // 
            this.menuItemProduct.Name = "menuItemProduct";
            this.menuItemProduct.Size = new System.Drawing.Size(122, 22);
            this.menuItemProduct.Text = "Produtos";
            // 
            // menuItemStock
            // 
            this.menuItemStock.Name = "menuItemStock";
            this.menuItemStock.Size = new System.Drawing.Size(122, 22);
            this.menuItemStock.Text = "Estoque";
            // 
            // menuItemSell
            // 
            this.menuItemSell.Name = "menuItemSell";
            this.menuItemSell.Size = new System.Drawing.Size(122, 22);
            this.menuItemSell.Text = "Vendas";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser,
            this.txtUser,
            this.lblDateTime,
            this.txtDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 17);
            this.lblUser.Text = "Usuário:";
            // 
            // txtUser
            // 
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(78, 17);
            this.txtUser.Text = "Carregando...";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(76, 17);
            this.lblDateTime.Text = "Data e Hora:";
            // 
            // txtDateTime
            // 
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(78, 17);
            this.txtDateTime.Text = "Carregando...";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(984, 515);
            this.tabControlMain.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmMain";
            this.Text = ":: MAT - CONTROLE DE ESTOQUE ::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuItemSystem;
        private ToolStripMenuItem menuItemUser;
        private ToolStripMenuItem menuItemClient;
        private ToolStripMenuItem menuItemChangePassword;
        private ToolStripMenuItem menuItemClose;
        private ToolStripMenuItem menuItemAdministration;
        private ToolStripMenuItem menuItemProduct;
        private ToolStripMenuItem menuItemStock;
        private ToolStripMenuItem menuItemSell;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUser;
        private ToolStripStatusLabel txtUser;
        private ToolStripStatusLabel lblDateTime;
        private ToolStripStatusLabel txtDateTime;
        private System.Windows.Forms.Timer timer;
        private TabControl tabControlMain;
    }
}