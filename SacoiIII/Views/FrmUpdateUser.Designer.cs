namespace SacoiIII.Views
{
    partial class FrmUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateUser));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblCargo = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.ChkSenha = new System.Windows.Forms.CheckBox();
            this.TxtRSenha = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblRSenha = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtSNome = new System.Windows.Forms.TextBox();
            this.TxtPNome = new System.Windows.Forms.TextBox();
            this.LblSNome = new System.Windows.Forms.Label();
            this.LblPNome = new System.Windows.Forms.Label();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.PnlMenu.SuspendLayout();
            this.PnlContent.SuspendLayout();
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
            this.PnlMenu.Size = new System.Drawing.Size(424, 40);
            this.PnlMenu.TabIndex = 2;
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
            this.BtnSair.Location = new System.Drawing.Point(329, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(93, 38);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = " &Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
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
            this.PnlContent.Controls.Add(this.TxtSNome);
            this.PnlContent.Controls.Add(this.TxtPNome);
            this.PnlContent.Controls.Add(this.LblSNome);
            this.PnlContent.Controls.Add(this.LblPNome);
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlContent.Location = new System.Drawing.Point(0, 40);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(424, 333);
            this.PnlContent.TabIndex = 4;
            // 
            // TxtCargo
            // 
            this.TxtCargo.Location = new System.Drawing.Point(220, 97);
            this.TxtCargo.Name = "TxtCargo";
            this.TxtCargo.Size = new System.Drawing.Size(187, 21);
            this.TxtCargo.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(12, 97);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(187, 21);
            this.TxtEmail.TabIndex = 3;
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.Location = new System.Drawing.Point(217, 66);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(115, 16);
            this.LblCargo.TabIndex = 19;
            this.LblCargo.Text = "Digite seu cargo:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(12, 66);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(113, 16);
            this.LblEmail.TabIndex = 18;
            this.LblEmail.Text = "Digite seu email:";
            // 
            // ChkSenha
            // 
            this.ChkSenha.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkSenha.AutoSize = true;
            this.ChkSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkSenha.FlatAppearance.BorderSize = 0;
            this.ChkSenha.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.ChkSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.ChkSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkSenha.Image = global::SacoiIII.Properties.Resources.pin_code_24b;
            this.ChkSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkSenha.Location = new System.Drawing.Point(292, 203);
            this.ChkSenha.Name = "ChkSenha";
            this.ChkSenha.Size = new System.Drawing.Size(115, 30);
            this.ChkSenha.TabIndex = 11;
            this.ChkSenha.TabStop = false;
            this.ChkSenha.Text = " Exibir senha";
            this.ChkSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChkSenha.UseVisualStyleBackColor = true;
            this.ChkSenha.CheckedChanged += new System.EventHandler(this.ChkSenha_CheckedChanged);
            this.ChkSenha.MouseEnter += new System.EventHandler(this.ChkSenha_MouseEnter);
            this.ChkSenha.MouseLeave += new System.EventHandler(this.ChkSenha_MouseLeave);
            // 
            // TxtRSenha
            // 
            this.TxtRSenha.Location = new System.Drawing.Point(220, 176);
            this.TxtRSenha.Name = "TxtRSenha";
            this.TxtRSenha.Size = new System.Drawing.Size(187, 21);
            this.TxtRSenha.TabIndex = 6;
            this.TxtRSenha.UseSystemPasswordChar = true;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(14, 176);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(187, 21);
            this.TxtSenha.TabIndex = 5;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // LblRSenha
            // 
            this.LblRSenha.AutoSize = true;
            this.LblRSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRSenha.Location = new System.Drawing.Point(218, 146);
            this.LblRSenha.Name = "LblRSenha";
            this.LblRSenha.Size = new System.Drawing.Size(123, 16);
            this.LblRSenha.TabIndex = 10;
            this.LblRSenha.Text = "Repita sua senha:";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(11, 146);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(119, 16);
            this.LblSenha.TabIndex = 8;
            this.LblSenha.Text = "Digite sua senha:";
            // 
            // TxtSNome
            // 
            this.TxtSNome.Location = new System.Drawing.Point(220, 30);
            this.TxtSNome.Name = "TxtSNome";
            this.TxtSNome.Size = new System.Drawing.Size(187, 21);
            this.TxtSNome.TabIndex = 1;
            // 
            // TxtPNome
            // 
            this.TxtPNome.Location = new System.Drawing.Point(14, 30);
            this.TxtPNome.Name = "TxtPNome";
            this.TxtPNome.Size = new System.Drawing.Size(187, 21);
            this.TxtPNome.TabIndex = 0;
            // 
            // LblSNome
            // 
            this.LblSNome.AutoSize = true;
            this.LblSNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSNome.Location = new System.Drawing.Point(209, 8);
            this.LblSNome.Name = "LblSNome";
            this.LblSNome.Size = new System.Drawing.Size(151, 16);
            this.LblSNome.TabIndex = 1;
            this.LblSNome.Text = "Digite seu sobrenome:";
            // 
            // LblPNome
            // 
            this.LblPNome.AutoSize = true;
            this.LblPNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPNome.Location = new System.Drawing.Point(3, 8);
            this.LblPNome.Name = "LblPNome";
            this.LblPNome.Size = new System.Drawing.Size(170, 16);
            this.LblPNome.TabIndex = 0;
            this.LblPNome.Text = "Digite seu primeiro nome:";
            // 
            // PnlButtons
            // 
            this.PnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.PnlButtons.Controls.Add(this.BtnLimpar);
            this.PnlButtons.Controls.Add(this.BtnSalvar);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButtons.Location = new System.Drawing.Point(0, 286);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(424, 87);
            this.PnlButtons.TabIndex = 9;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpar.FlatAppearance.BorderSize = 0;
            this.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Image = global::SacoiIII.Properties.Resources.backspace_32b;
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(212, 9);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(181, 69);
            this.BtnLimpar.TabIndex = 1;
            this.BtnLimpar.TabStop = false;
            this.BtnLimpar.Text = " &Limpar";
            this.BtnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            this.BtnLimpar.MouseEnter += new System.EventHandler(this.BtnLimpar_MouseEnter);
            this.BtnLimpar.MouseLeave += new System.EventHandler(this.BtnLimpar_MouseLeave);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Image = global::SacoiIII.Properties.Resources.success_32b;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvar.Location = new System.Drawing.Point(25, 9);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(181, 69);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.TabStop = false;
            this.BtnSalvar.Text = " &Salvar";
            this.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            this.BtnSalvar.MouseEnter += new System.EventHandler(this.BtnSalvar_MouseEnter);
            this.BtnSalvar.MouseLeave += new System.EventHandler(this.BtnSalvar_MouseLeave);
            // 
            // FrmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 373);
            this.Controls.Add(this.PnlButtons);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sacoi - Atualização de cadastro";
            this.PnlMenu.ResumeLayout(false);
            this.PnlContent.ResumeLayout(false);
            this.PnlContent.PerformLayout();
            this.PnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Panel PnlContent;
        private System.Windows.Forms.TextBox TxtCargo;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.CheckBox ChkSenha;
        private System.Windows.Forms.TextBox TxtRSenha;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblRSenha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxtSNome;
        private System.Windows.Forms.TextBox TxtPNome;
        private System.Windows.Forms.Label LblSNome;
        private System.Windows.Forms.Label LblPNome;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvar;
    }
}