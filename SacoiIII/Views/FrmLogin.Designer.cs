namespace SacoiIII
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.LblUserName = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.ChkSenha = new System.Windows.Forms.CheckBox();
            this.PnlMenu.SuspendLayout();
            this.PnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.PnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMenu.Controls.Add(this.BtnSair);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(365, 42);
            this.PnlMenu.TabIndex = 0;
            // 
            // BtnSair
            // 
            this.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Image = global::SacoiIII.Properties.Resources.power;
            this.BtnSair.Location = new System.Drawing.Point(288, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 40);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = " &Sair";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnSair, "Clique aqui para sair");
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PnlButtons
            // 
            this.PnlButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.PnlButtons.Controls.Add(this.BtnCadastrar);
            this.PnlButtons.Controls.Add(this.BtnLogin);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButtons.Location = new System.Drawing.Point(0, 310);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(365, 95);
            this.PnlButtons.TabIndex = 1;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.FlatAppearance.BorderSize = 0;
            this.BtnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Image = global::SacoiIII.Properties.Resources.plus_32b;
            this.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCadastrar.Location = new System.Drawing.Point(194, 3);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(157, 88);
            this.BtnCadastrar.TabIndex = 1;
            this.BtnCadastrar.TabStop = false;
            this.BtnCadastrar.Text = " &Cadastrar";
            this.BtnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnCadastrar, "Clique aqui para se cadastrar");
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            this.BtnCadastrar.MouseEnter += new System.EventHandler(this.BtnCadastrar_MouseEnter);
            this.BtnCadastrar.MouseLeave += new System.EventHandler(this.BtnCadastrar_MouseLeave);
            // 
            // BtnLogin
            // 
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Image = global::SacoiIII.Properties.Resources.login_32b;
            this.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogin.Location = new System.Drawing.Point(14, 3);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(157, 88);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.TabStop = false;
            this.BtnLogin.Text = " Efetuar &Login";
            this.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnLogin, "Clique aqui para efetuar login");
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BtnLogin.MouseEnter += new System.EventHandler(this.BtnLogin_MouseEnter);
            this.BtnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(88, 105);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(192, 16);
            this.LblUserName.TabIndex = 2;
            this.LblUserName.Text = "Digite seu nome de usuário:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(91, 124);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(184, 21);
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(91, 190);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(184, 21);
            this.TxtSenha.TabIndex = 3;
            this.TxtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(120, 171);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(123, 16);
            this.LblSenha.TabIndex = 4;
            this.LblSenha.Text = "Digite sua senha:";
            // 
            // ChkSenha
            // 
            this.ChkSenha.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkSenha.AutoSize = true;
            this.ChkSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkSenha.FlatAppearance.BorderSize = 0;
            this.ChkSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.ChkSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkSenha.Image = global::SacoiIII.Properties.Resources.pin_code_24b;
            this.ChkSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkSenha.Location = new System.Drawing.Point(160, 217);
            this.ChkSenha.Name = "ChkSenha";
            this.ChkSenha.Size = new System.Drawing.Size(115, 30);
            this.ChkSenha.TabIndex = 5;
            this.ChkSenha.TabStop = false;
            this.ChkSenha.Text = " Exibir senha";
            this.ChkSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChkSenha.UseVisualStyleBackColor = true;
            this.ChkSenha.CheckedChanged += new System.EventHandler(this.ChkSenha_CheckedChanged);
            this.ChkSenha.MouseEnter += new System.EventHandler(this.ChkSenha_MouseEnter);
            this.ChkSenha.MouseLeave += new System.EventHandler(this.ChkSenha_MouseLeave);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSair;
            this.ClientSize = new System.Drawing.Size(365, 405);
            this.Controls.Add(this.ChkSenha);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.PnlButtons);
            this.Controls.Add(this.PnlMenu);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SACOI - Login";
            this.PnlMenu.ResumeLayout(false);
            this.PnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.CheckBox ChkSenha;
    }
}

