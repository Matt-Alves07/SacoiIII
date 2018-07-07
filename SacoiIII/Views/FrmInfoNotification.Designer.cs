namespace SacoiIII.Views
{
    partial class FrmInfoNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoNotification));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PnlDetails = new System.Windows.Forms.Panel();
            this.LblValido = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnDenunciar = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.PnlTexto = new System.Windows.Forms.Panel();
            this.LblTexto = new System.Windows.Forms.Label();
            this.PnlMenu.SuspendLayout();
            this.PnlDetails.SuspendLayout();
            this.PnlButtons.SuspendLayout();
            this.PnlTexto.SuspendLayout();
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
            this.PnlMenu.Size = new System.Drawing.Size(477, 40);
            this.PnlMenu.TabIndex = 7;
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
            this.BtnSair.Location = new System.Drawing.Point(391, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(84, 38);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = " &Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSair.UseVisualStyleBackColor = true;
            // 
            // PnlDetails
            // 
            this.PnlDetails.BackColor = System.Drawing.Color.Transparent;
            this.PnlDetails.Controls.Add(this.LblValido);
            this.PnlDetails.Controls.Add(this.LblUserName);
            this.PnlDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDetails.Location = new System.Drawing.Point(0, 40);
            this.PnlDetails.Name = "PnlDetails";
            this.PnlDetails.Size = new System.Drawing.Size(477, 43);
            this.PnlDetails.TabIndex = 9;
            // 
            // LblValido
            // 
            this.LblValido.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblValido.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValido.Location = new System.Drawing.Point(249, 0);
            this.LblValido.Name = "LblValido";
            this.LblValido.Size = new System.Drawing.Size(228, 43);
            this.LblValido.TabIndex = 10;
            this.LblValido.Text = "Valido";
            this.LblValido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUserName
            // 
            this.LblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblUserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(0, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(477, 43);
            this.LblUserName.TabIndex = 9;
            this.LblUserName.Text = "Nome do usuário";
            this.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlButtons
            // 
            this.PnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.PnlButtons.Controls.Add(this.BtnExcluir);
            this.PnlButtons.Controls.Add(this.BtnDenunciar);
            this.PnlButtons.Controls.Add(this.BtnEdit);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButtons.Location = new System.Drawing.Point(0, 332);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(477, 86);
            this.PnlButtons.TabIndex = 10;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Image = global::SacoiIII.Properties.Resources.delete_32b;
            this.BtnExcluir.Location = new System.Drawing.Point(319, 7);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(147, 67);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "E&xcluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            this.BtnExcluir.MouseEnter += new System.EventHandler(this.BtnExcluir_MouseEnter);
            this.BtnExcluir.MouseLeave += new System.EventHandler(this.BtnExcluir_MouseLeave);
            // 
            // BtnDenunciar
            // 
            this.BtnDenunciar.FlatAppearance.BorderSize = 0;
            this.BtnDenunciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnDenunciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDenunciar.Image = global::SacoiIII.Properties.Resources.warning_32b;
            this.BtnDenunciar.Location = new System.Drawing.Point(166, 7);
            this.BtnDenunciar.Name = "BtnDenunciar";
            this.BtnDenunciar.Size = new System.Drawing.Size(147, 67);
            this.BtnDenunciar.TabIndex = 1;
            this.BtnDenunciar.TabStop = false;
            this.BtnDenunciar.Text = " &Invalidar";
            this.BtnDenunciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDenunciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDenunciar.UseVisualStyleBackColor = true;
            this.BtnDenunciar.Click += new System.EventHandler(this.BtnDenunciar_Click);
            this.BtnDenunciar.MouseEnter += new System.EventHandler(this.BtnDenunciar_MouseEnter);
            this.BtnDenunciar.MouseLeave += new System.EventHandler(this.BtnDenunciar_MouseLeave);
            // 
            // BtnEdit
            // 
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Image = global::SacoiIII.Properties.Resources.update_32b;
            this.BtnEdit.Location = new System.Drawing.Point(13, 7);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(147, 67);
            this.BtnEdit.TabIndex = 0;
            this.BtnEdit.TabStop = false;
            this.BtnEdit.Text = " &Editar";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            this.BtnEdit.MouseEnter += new System.EventHandler(this.BtnEdit_MouseEnter);
            this.BtnEdit.MouseLeave += new System.EventHandler(this.BtnEdit_MouseLeave);
            // 
            // PnlTexto
            // 
            this.PnlTexto.BackColor = System.Drawing.Color.Transparent;
            this.PnlTexto.Controls.Add(this.LblTexto);
            this.PnlTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTexto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlTexto.Location = new System.Drawing.Point(0, 83);
            this.PnlTexto.Name = "PnlTexto";
            this.PnlTexto.Size = new System.Drawing.Size(477, 249);
            this.PnlTexto.TabIndex = 11;
            // 
            // LblTexto
            // 
            this.LblTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTexto.Location = new System.Drawing.Point(0, 0);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(477, 249);
            this.LblTexto.TabIndex = 0;
            this.LblTexto.Text = "Conteúdo da notificação";
            this.LblTexto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmInfoNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSair;
            this.ClientSize = new System.Drawing.Size(477, 418);
            this.Controls.Add(this.PnlTexto);
            this.Controls.Add(this.PnlButtons);
            this.Controls.Add(this.PnlDetails);
            this.Controls.Add(this.PnlMenu);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInfoNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações da Notificação";
            this.Load += new System.EventHandler(this.FrmInfoNotification_Load);
            this.Leave += new System.EventHandler(this.FrmInfoNotification_Leave);
            this.PnlMenu.ResumeLayout(false);
            this.PnlDetails.ResumeLayout(false);
            this.PnlButtons.ResumeLayout(false);
            this.PnlTexto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Panel PnlDetails;
        private System.Windows.Forms.Label LblValido;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Panel PnlTexto;
        private System.Windows.Forms.Label LblTexto;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnDenunciar;
        private System.Windows.Forms.Button BtnEdit;
    }
}