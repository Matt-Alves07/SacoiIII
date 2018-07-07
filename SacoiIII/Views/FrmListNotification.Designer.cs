namespace SacoiIII.Views
{
    partial class FrmListNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListNotification));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.ChkInvalidas = new System.Windows.Forms.CheckBox();
            this.BtnRelistar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.DGVNotification = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.PnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMenu.Controls.Add(this.ChkInvalidas);
            this.PnlMenu.Controls.Add(this.BtnRelistar);
            this.PnlMenu.Controls.Add(this.BtnSair);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(694, 40);
            this.PnlMenu.TabIndex = 6;
            // 
            // ChkInvalidas
            // 
            this.ChkInvalidas.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkInvalidas.AutoSize = true;
            this.ChkInvalidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkInvalidas.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChkInvalidas.FlatAppearance.BorderSize = 0;
            this.ChkInvalidas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.ChkInvalidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.ChkInvalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkInvalidas.ForeColor = System.Drawing.Color.White;
            this.ChkInvalidas.Location = new System.Drawing.Point(125, 0);
            this.ChkInvalidas.Name = "ChkInvalidas";
            this.ChkInvalidas.Size = new System.Drawing.Size(104, 38);
            this.ChkInvalidas.TabIndex = 5;
            this.ChkInvalidas.TabStop = false;
            this.ChkInvalidas.Text = "Listar Invalidas";
            this.ChkInvalidas.UseVisualStyleBackColor = true;
            this.ChkInvalidas.CheckedChanged += new System.EventHandler(this.ChkInvalidas_CheckedChanged);
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
            this.BtnRelistar.Size = new System.Drawing.Size(125, 38);
            this.BtnRelistar.TabIndex = 4;
            this.BtnRelistar.TabStop = false;
            this.BtnRelistar.Text = " Atualiza&r Lista";
            this.BtnRelistar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRelistar.UseVisualStyleBackColor = true;
            this.BtnRelistar.Click += new System.EventHandler(this.BtnRelistar_Click);
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
            this.BtnSair.Location = new System.Drawing.Point(608, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(84, 38);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = " &Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // DGVNotification
            // 
            this.DGVNotification.AllowUserToAddRows = false;
            this.DGVNotification.AllowUserToDeleteRows = false;
            this.DGVNotification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVNotification.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNotification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.texto,
            this.idUsuario,
            this.user_name,
            this.valido});
            this.DGVNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVNotification.Location = new System.Drawing.Point(0, 40);
            this.DGVNotification.MultiSelect = false;
            this.DGVNotification.Name = "DGVNotification";
            this.DGVNotification.ReadOnly = true;
            this.DGVNotification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVNotification.Size = new System.Drawing.Size(694, 367);
            this.DGVNotification.TabIndex = 7;
            this.DGVNotification.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNotification_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MaxInputLength = 32;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.ToolTipText = "Id da notificação";
            this.id.Visible = false;
            // 
            // texto
            // 
            this.texto.HeaderText = "Conteúdo";
            this.texto.MaxInputLength = 300;
            this.texto.Name = "texto";
            this.texto.ReadOnly = true;
            this.texto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.texto.ToolTipText = "Conteúdo da notificação";
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "ID Usuário";
            this.idUsuario.MaxInputLength = 32;
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idUsuario.ToolTipText = "Id do usuário que criou a notificação";
            this.idUsuario.Visible = false;
            // 
            // user_name
            // 
            this.user_name.HeaderText = "Criador";
            this.user_name.MaxInputLength = 25;
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            this.user_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.user_name.ToolTipText = "Nome de usuário que criou a notificação";
            // 
            // valido
            // 
            this.valido.HeaderText = "Valido";
            this.valido.MaxInputLength = 5;
            this.valido.Name = "valido";
            this.valido.ReadOnly = true;
            this.valido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.valido.ToolTipText = "Informa se a notificação será exibida na listagem do Home";
            // 
            // FrmListNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSair;
            this.ClientSize = new System.Drawing.Size(694, 407);
            this.Controls.Add(this.DGVNotification);
            this.Controls.Add(this.PnlMenu);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SACOI - Lista de Notificações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListNotification_FormClosing);
            this.Enter += new System.EventHandler(this.FrmListNotification_Enter);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNotification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnRelistar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView DGVNotification;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn texto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn valido;
        private System.Windows.Forms.CheckBox ChkInvalidas;
    }
}