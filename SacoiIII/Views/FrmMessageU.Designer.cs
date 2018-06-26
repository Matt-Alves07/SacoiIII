namespace SacoiIII.Views
{
    partial class FrmMessageU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessageU));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.DGVMessage = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.About = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnRelistar = new System.Windows.Forms.Button();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMessage)).BeginInit();
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
            this.PnlMenu.Size = new System.Drawing.Size(814, 40);
            this.PnlMenu.TabIndex = 7;
            // 
            // DGVMessage
            // 
            this.DGVMessage.AllowUserToAddRows = false;
            this.DGVMessage.AllowUserToDeleteRows = false;
            this.DGVMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.sender,
            this.About,
            this.Text});
            this.DGVMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMessage.Location = new System.Drawing.Point(0, 40);
            this.DGVMessage.Name = "DGVMessage";
            this.DGVMessage.ReadOnly = true;
            this.DGVMessage.Size = new System.Drawing.Size(814, 481);
            this.DGVMessage.TabIndex = 8;
            this.DGVMessage.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMessage_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.ToolTipText = "Identificador da mensagem";
            this.ID.Visible = false;
            // 
            // sender
            // 
            this.sender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sender.HeaderText = "Remetente";
            this.sender.Name = "sender";
            this.sender.ReadOnly = true;
            this.sender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sender.ToolTipText = "Remetente da mensagem";
            // 
            // About
            // 
            this.About.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.About.HeaderText = "Assunto";
            this.About.Name = "About";
            this.About.ReadOnly = true;
            this.About.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.About.ToolTipText = "Assunto da mensagem";
            // 
            // Text
            // 
            this.Text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Text.HeaderText = "Texto";
            this.Text.Name = "Text";
            this.Text.ReadOnly = true;
            this.Text.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Text.ToolTipText = "Texto da Mensagem";
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
            this.BtnSair.Location = new System.Drawing.Point(728, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(84, 38);
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
            this.BtnRelistar.Size = new System.Drawing.Size(165, 38);
            this.BtnRelistar.TabIndex = 5;
            this.BtnRelistar.TabStop = false;
            this.BtnRelistar.Text = " Atualiza&r Mensagens";
            this.BtnRelistar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRelistar.UseVisualStyleBackColor = true;
            this.BtnRelistar.Click += new System.EventHandler(this.BtnRelistar_Click);
            // 
            // FrmMessageU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSair;
            this.ClientSize = new System.Drawing.Size(814, 521);
            this.Controls.Add(this.DGVMessage);
            this.Controls.Add(this.PnlMenu);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMessageU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView DGVMessage;
        private System.Windows.Forms.Button BtnRelistar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn About;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
    }
}