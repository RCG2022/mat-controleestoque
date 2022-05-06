namespace MAT.ControleEstoque.App
{
    partial class frmUser
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.spanEnable = new System.Windows.Forms.Label();
            this.spanPassword = new System.Windows.Forms.Label();
            this.spanLogin = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.chkBoxDesabilitado = new System.Windows.Forms.CheckBox();
            this.chkBoxHabilitado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gbMenu.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(7, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(91, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(175, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(259, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnClose);
            this.gbMenu.Controls.Add(this.btnSave);
            this.gbMenu.Controls.Add(this.btnSearch);
            this.gbMenu.Controls.Add(this.btnAdd);
            this.gbMenu.Location = new System.Drawing.Point(-2, -11);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(795, 48);
            this.gbMenu.TabIndex = 1;
            this.gbMenu.TabStop = false;
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.spanEnable);
            this.gbUser.Controls.Add(this.spanPassword);
            this.gbUser.Controls.Add(this.spanLogin);
            this.gbUser.Controls.Add(this.txtPassword);
            this.gbUser.Controls.Add(this.txtLogin);
            this.gbUser.Controls.Add(this.chkBoxDesabilitado);
            this.gbUser.Controls.Add(this.chkBoxHabilitado);
            this.gbUser.Controls.Add(this.label1);
            this.gbUser.Controls.Add(this.lblPassword);
            this.gbUser.Controls.Add(this.lblLogin);
            this.gbUser.Controls.Add(this.txtId);
            this.gbUser.Controls.Add(this.lblId);
            this.gbUser.Location = new System.Drawing.Point(12, 46);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(760, 153);
            this.gbUser.TabIndex = 2;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Usuario";
            // 
            // spanEnable
            // 
            this.spanEnable.AutoSize = true;
            this.spanEnable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spanEnable.ForeColor = System.Drawing.Color.IndianRed;
            this.spanEnable.Location = new System.Drawing.Point(269, 123);
            this.spanEnable.Name = "spanEnable";
            this.spanEnable.Size = new System.Drawing.Size(34, 15);
            this.spanEnable.TabIndex = 15;
            this.spanEnable.Text = "Span";
            // 
            // spanPassword
            // 
            this.spanPassword.AutoSize = true;
            this.spanPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spanPassword.ForeColor = System.Drawing.Color.IndianRed;
            this.spanPassword.Location = new System.Drawing.Point(383, 96);
            this.spanPassword.Name = "spanPassword";
            this.spanPassword.Size = new System.Drawing.Size(34, 15);
            this.spanPassword.TabIndex = 14;
            this.spanPassword.Text = "Span";
            // 
            // spanLogin
            // 
            this.spanLogin.AutoSize = true;
            this.spanLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spanLogin.ForeColor = System.Drawing.Color.IndianRed;
            this.spanLogin.Location = new System.Drawing.Point(383, 64);
            this.spanLogin.Name = "spanLogin";
            this.spanLogin.Size = new System.Drawing.Size(34, 15);
            this.spanLogin.TabIndex = 13;
            this.spanLogin.Text = "Span";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(77, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 23);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(77, 61);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(300, 23);
            this.txtLogin.TabIndex = 11;
            // 
            // chkBoxDesabilitado
            // 
            this.chkBoxDesabilitado.AutoSize = true;
            this.chkBoxDesabilitado.Location = new System.Drawing.Point(161, 119);
            this.chkBoxDesabilitado.Name = "chkBoxDesabilitado";
            this.chkBoxDesabilitado.Size = new System.Drawing.Size(91, 19);
            this.chkBoxDesabilitado.TabIndex = 10;
            this.chkBoxDesabilitado.Text = "Desabilitado";
            this.chkBoxDesabilitado.UseVisualStyleBackColor = true;
            this.chkBoxDesabilitado.CheckedChanged += new System.EventHandler(this.chkBoxDesabilitado_CheckedChanged);
            // 
            // chkBoxHabilitado
            // 
            this.chkBoxHabilitado.AutoSize = true;
            this.chkBoxHabilitado.Location = new System.Drawing.Point(77, 119);
            this.chkBoxHabilitado.Name = "chkBoxHabilitado";
            this.chkBoxHabilitado.Size = new System.Drawing.Size(81, 19);
            this.chkBoxHabilitado.TabIndex = 9;
            this.chkBoxHabilitado.Text = "Habilitado";
            this.chkBoxHabilitado.UseVisualStyleBackColor = true;
            this.chkBoxHabilitado.CheckedChanged += new System.EventHandler(this.chkBoxHabilitado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(29, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(42, 15);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(31, 65);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 15);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(77, 28);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(300, 23);
            this.txtId.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(51, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id:";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.gbMenu);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuario";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.gbMenu.ResumeLayout(false);
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnClose;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnSave;
        private GroupBox gbMenu;
        private GroupBox gbUser;
        private TextBox txtId;
        private Label lblId;
        private Label lblPassword;
        private TextBox txtLogin;
        private Label lblLogin;
        private CheckBox chkBoxDesabilitado;
        private CheckBox chkBoxHabilitado;
        private Label label1;
        private TextBox txtPassword;
        private Label spanPassword;
        private Label spanLogin;
        private Label spanEnable;
    }
}