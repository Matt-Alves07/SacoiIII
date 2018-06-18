namespace SacoiIII
{
    partial class FrmPedidosAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidosAdmin));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.DGVUser = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnRelistar = new System.Windows.Forms.Button();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.PnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMenu.Controls.Add(this.BtnRelistar);
            this.PnlMenu.Controls.Add(this.BtnSair);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(514, 46);
            this.PnlMenu.TabIndex = 6;
            // 
            // DGVUser
            // 
            this.DGVUser.AllowUserToAddRows = false;
            this.DGVUser.AllowUserToDeleteRows = false;
            this.DGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Pedido,
            this.NomeUser,
            this.DataPedido});
            this.DGVUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUser.Location = new System.Drawing.Point(0, 46);
            this.DGVUser.Name = "DGVUser";
            this.DGVUser.ReadOnly = true;
            this.DGVUser.Size = new System.Drawing.Size(514, 350);
            this.DGVUser.TabIndex = 7;
            this.DGVUser.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUser_CellContentDoubleClick);
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Visible = false;
            // 
            // Pedido
            // 
            this.Pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.ReadOnly = true;
            this.Pedido.Visible = false;
            // 
            // NomeUser
            // 
            this.NomeUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeUser.HeaderText = "Nome de Usuário";
            this.NomeUser.Name = "NomeUser";
            this.NomeUser.ReadOnly = true;
            // 
            // DataPedido
            // 
            this.DataPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataPedido.HeaderText = "Data da Solicitação";
            this.DataPedido.Name = "DataPedido";
            this.DataPedido.ReadOnly = true;
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
            this.BtnSair.Location = new System.Drawing.Point(414, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(98, 44);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = " &Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnRelistar
            // 
            this.BtnRelistar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRelistar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnRelistar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnRelistar.FlatAppearance.BorderSize = 0;
            this.BtnRelistar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnRelistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelistar.ForeColor = System.Drawing.Color.White;
            this.BtnRelistar.Image = global::SacoiIII.Properties.Resources.circular_arrow_24w;
            this.BtnRelistar.Location = new System.Drawing.Point(0, 0);
            this.BtnRelistar.Name = "BtnRelistar";
            this.BtnRelistar.Size = new System.Drawing.Size(146, 44);
            this.BtnRelistar.TabIndex = 4;
            this.BtnRelistar.TabStop = false;
            this.BtnRelistar.Text = " Atualiza&r Lista";
            this.BtnRelistar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRelistar.UseVisualStyleBackColor = true;
            this.BtnRelistar.Click += new System.EventHandler(this.BtnRelistar_Click);
            // 
            // FrmPedidosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSair;
            this.ClientSize = new System.Drawing.Size(514, 396);
            this.Controls.Add(this.DGVUser);
            this.Controls.Add(this.PnlMenu);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidosAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SACOI - Pedidos para Administrar o sistema";
            this.PnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnRelistar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView DGVUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPedido;
    }
}