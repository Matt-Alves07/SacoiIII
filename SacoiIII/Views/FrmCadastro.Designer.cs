namespace SacoiIII.Views
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.LblPNome = new System.Windows.Forms.Label();
            this.LblSNome = new System.Windows.Forms.Label();
            this.TxtPNome = new System.Windows.Forms.TextBox();
            this.TxtSNome = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnDisp = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.TxtRSenha = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblRSenha = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.ChkSenha = new System.Windows.Forms.CheckBox();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblCargo = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.PnlMenu.SuspendLayout();
            this.PnlButtons.SuspendLayout();
            this.PnlContent.SuspendLayout();
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
            this.PnlMenu.Size = new System.Drawing.Size(373, 41);
            this.PnlMenu.TabIndex = 1;
            // 
            // PnlButtons
            // 
            this.PnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.PnlButtons.Controls.Add(this.BtnLimpar);
            this.PnlButtons.Controls.Add(this.BtnCadastro);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButtons.Location = new System.Drawing.Point(0, 309);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(373, 82);
            this.PnlButtons.TabIndex = 2;
            // 
            // PnlContent
            // 
            this.PnlContent.BackColor = System.Drawing.Color.Transparent;
            this.PnlContent.Controls.Add(this.TxtCargo);
            this.PnlContent.Controls.Add(this.TxtEmail);
            this.PnlContent.Controls.Add(this.LblCargo);
            this.PnlContent.Controls.Add(this.LblEmail);
            this.PnlContent.Controls.Add(this.ChkSenha);
            this.PnlContent.Controls.Add(this.TxtRSenha);
            this.PnlContent.Controls.Add(this.TxtSenha);
            this.PnlContent.Controls.Add(this.LblRSenha);
            this.PnlContent.Controls.Add(this.LblSenha);
            this.PnlContent.Controls.Add(this.BtnDisp);
            this.PnlContent.Controls.Add(this.TxtUserName);
            this.PnlContent.Controls.Add(this.LblUserName);
            this.PnlContent.Controls.Add(this.TxtSNome);
            this.PnlContent.Controls.Add(this.TxtPNome);
            this.PnlContent.Controls.Add(this.LblSNome);
            this.PnlContent.Controls.Add(this.LblPNome);
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlContent.Location = new System.Drawing.Point(0, 41);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(373, 268);
            this.PnlContent.TabIndex = 3;
            // 
            // LblPNome
            // 
            this.LblPNome.AutoSize = true;
            this.LblPNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPNome.Location = new System.Drawing.Point(3, 7);
            this.LblPNome.Name = "LblPNome";
            this.LblPNome.Size = new System.Drawing.Size(170, 16);
            this.LblPNome.TabIndex = 0;
            this.LblPNome.Text = "Digite seu primeiro nome:";
            // 
            // LblSNome
            // 
            this.LblSNome.AutoSize = true;
            this.LblSNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSNome.Location = new System.Drawing.Point(179, 7);
            this.LblSNome.Name = "LblSNome";
            this.LblSNome.Size = new System.Drawing.Size(151, 16);
            this.LblSNome.TabIndex = 1;
            this.LblSNome.Text = "Digite seu sobrenome:";
            // 
            // TxtPNome
            // 
            this.TxtPNome.Location = new System.Drawing.Point(12, 26);
            this.TxtPNome.Name = "TxtPNome";
            this.TxtPNome.Size = new System.Drawing.Size(161, 21);
            this.TxtPNome.TabIndex = 0;
            this.Hint.SetToolTip(this.TxtPNome, "Preencha com seu primeiro nome");
            // 
            // TxtSNome
            // 
            this.TxtSNome.Location = new System.Drawing.Point(189, 26);
            this.TxtSNome.Name = "TxtSNome";
            this.TxtSNome.Size = new System.Drawing.Size(161, 21);
            this.TxtSNome.TabIndex = 1;
            this.Hint.SetToolTip(this.TxtSNome, "Preencha com seu sobrenome");
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(11, 82);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(161, 21);
            this.TxtUserName.TabIndex = 2;
            this.Hint.SetToolTip(this.TxtUserName, "Preencha com seu nome de usuário");
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(3, 63);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(186, 16);
            this.LblUserName.TabIndex = 5;
            this.LblUserName.Text = "Digite seu nome de usuário:";
            // 
            // BtnSair
            // 
            this.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Image = global::SacoiIII.Properties.Resources.error_24w;
            this.BtnSair.Location = new System.Drawing.Point(291, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(80, 39);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = " &Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnSair, "Clique aqui para fechar");
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnDisp
            // 
            this.BtnDisp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDisp.FlatAppearance.BorderSize = 0;
            this.BtnDisp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.BtnDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisp.Image = global::SacoiIII.Properties.Resources.search_16b;
            this.BtnDisp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDisp.Location = new System.Drawing.Point(196, 63);
            this.BtnDisp.Name = "BtnDisp";
            this.BtnDisp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDisp.Size = new System.Drawing.Size(154, 40);
            this.BtnDisp.TabIndex = 6;
            this.BtnDisp.TabStop = false;
            this.BtnDisp.Text = "Verificar disponibilidade";
            this.BtnDisp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnDisp, "Clique para verficar se seu nome de usuário está disponível");
            this.BtnDisp.UseVisualStyleBackColor = true;
            this.BtnDisp.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.BtnDisp.MouseLeave += new System.EventHandler(this.BtnDisp_MouseLeave);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpar.FlatAppearance.BorderSize = 0;
            this.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Image = global::SacoiIII.Properties.Resources.backspace_32b;
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(196, 6);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(157, 67);
            this.BtnLimpar.TabIndex = 3;
            this.BtnLimpar.TabStop = false;
            this.BtnLimpar.Text = " &Limpar campos";
            this.BtnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnLimpar, "Clique aqui para limpar todos os campos");
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            this.BtnLimpar.MouseEnter += new System.EventHandler(this.BtnLimpar_MouseEnter);
            this.BtnLimpar.MouseLeave += new System.EventHandler(this.BtnLimpar_MouseLeave);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.FlatAppearance.BorderSize = 0;
            this.BtnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.BtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastro.Image = global::SacoiIII.Properties.Resources.success_32b;
            this.BtnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCadastro.Location = new System.Drawing.Point(16, 6);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(157, 67);
            this.BtnCadastro.TabIndex = 2;
            this.BtnCadastro.TabStop = false;
            this.BtnCadastro.Text = " Efetuar &cadastro";
            this.BtnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnCadastro, "Clique aqui para efetuar seu cadastro");
            this.BtnCadastro.UseVisualStyleBackColor = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            this.BtnCadastro.MouseEnter += new System.EventHandler(this.BtnCadastro_MouseEnter);
            this.BtnCadastro.MouseLeave += new System.EventHandler(this.BtnCadastro_MouseLeave);
            // 
            // TxtRSenha
            // 
            this.TxtRSenha.Location = new System.Drawing.Point(189, 200);
            this.TxtRSenha.Name = "TxtRSenha";
            this.TxtRSenha.Size = new System.Drawing.Size(161, 21);
            this.TxtRSenha.TabIndex = 6;
            this.Hint.SetToolTip(this.TxtRSenha, "Repita sua senha");
            this.TxtRSenha.UseSystemPasswordChar = true;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(12, 200);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(161, 21);
            this.TxtSenha.TabIndex = 5;
            this.Hint.SetToolTip(this.TxtSenha, "Preencha com sua senha");
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // LblRSenha
            // 
            this.LblRSenha.AutoSize = true;
            this.LblRSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRSenha.Location = new System.Drawing.Point(179, 181);
            this.LblRSenha.Name = "LblRSenha";
            this.LblRSenha.Size = new System.Drawing.Size(123, 16);
            this.LblRSenha.TabIndex = 10;
            this.LblRSenha.Text = "Repita sua senha:";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(3, 181);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(119, 16);
            this.LblSenha.TabIndex = 8;
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
            this.ChkSenha.Location = new System.Drawing.Point(235, 225);
            this.ChkSenha.Name = "ChkSenha";
            this.ChkSenha.Size = new System.Drawing.Size(115, 30);
            this.ChkSenha.TabIndex = 11;
            this.ChkSenha.TabStop = false;
            this.ChkSenha.Text = " Exibir senha";
            this.ChkSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.ChkSenha, "Clique para exibir sua senha");
            this.ChkSenha.UseVisualStyleBackColor = true;
            this.ChkSenha.CheckedChanged += new System.EventHandler(this.ChkSenha_CheckedChanged);
            this.ChkSenha.MouseEnter += new System.EventHandler(this.ChkSenha_MouseEnter);
            this.ChkSenha.MouseLeave += new System.EventHandler(this.ChkSenha_MouseLeave);
            // 
            // TxtCargo
            // 
            this.TxtCargo.Location = new System.Drawing.Point(189, 139);
            this.TxtCargo.Name = "TxtCargo";
            this.TxtCargo.Size = new System.Drawing.Size(161, 21);
            this.TxtCargo.TabIndex = 4;
            this.Hint.SetToolTip(this.TxtCargo, "Digite seu cargo");
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(12, 139);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(161, 21);
            this.TxtEmail.TabIndex = 3;
            this.Hint.SetToolTip(this.TxtEmail, "Preencha com seu email");
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.Location = new System.Drawing.Point(179, 120);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(115, 16);
            this.LblCargo.TabIndex = 19;
            this.LblCargo.Text = "Digite seu cargo:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(3, 120);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(113, 16);
            this.LblEmail.TabIndex = 18;
            this.LblEmail.Text = "Digite seu email:";
            // 
            // FrmCadastro
            // 
            this.AcceptButton = this.BtnCadastro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSair;
            this.ClientSize = new System.Drawing.Size(373, 391);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlButtons);
            this.Controls.Add(this.PnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastro";
            this.PnlMenu.ResumeLayout(false);
            this.PnlButtons.ResumeLayout(false);
            this.PnlContent.ResumeLayout(false);
            this.PnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Panel PnlContent;
        private System.Windows.Forms.Label LblPNome;
        private System.Windows.Forms.TextBox TxtSNome;
        private System.Windows.Forms.TextBox TxtPNome;
        private System.Windows.Forms.Label LblSNome;
        private System.Windows.Forms.Button BtnDisp;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.TextBox TxtRSenha;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblRSenha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.CheckBox ChkSenha;
        private System.Windows.Forms.TextBox TxtCargo;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.Label LblEmail;
    }
}