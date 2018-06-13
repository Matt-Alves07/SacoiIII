namespace SacoiIII.Views
{
    partial class FrmMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessage));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblAssunto = new System.Windows.Forms.Label();
            this.LblDestinatario = new System.Windows.Forms.Label();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.TxtTo = new System.Windows.Forms.TextBox();
            this.TxtBody = new System.Windows.Forms.TextBox();
            this.PnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.PnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMenu.Controls.Add(this.BtnLimpar);
            this.PnlMenu.Controls.Add(this.BtnEnviar);
            this.PnlMenu.Controls.Add(this.BtnSair);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(814, 40);
            this.PnlMenu.TabIndex = 7;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpar.FlatAppearance.BorderSize = 0;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(150, 5);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(109, 29);
            this.BtnLimpar.TabIndex = 13;
            this.BtnLimpar.Text = "&Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnviar.FlatAppearance.BorderSize = 0;
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.BtnEnviar.ForeColor = System.Drawing.Color.White;
            this.BtnEnviar.Image = global::SacoiIII.Properties.Resources.share_option_24w;
            this.BtnEnviar.Location = new System.Drawing.Point(13, 3);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(109, 32);
            this.BtnEnviar.TabIndex = 12;
            this.BtnEnviar.Text = "&Enviar";
            this.BtnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
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
            // 
            // LblAssunto
            // 
            this.LblAssunto.AutoSize = true;
            this.LblAssunto.Location = new System.Drawing.Point(29, 90);
            this.LblAssunto.Name = "LblAssunto";
            this.LblAssunto.Size = new System.Drawing.Size(48, 13);
            this.LblAssunto.TabIndex = 15;
            this.LblAssunto.Text = "Assunto:";
            // 
            // LblDestinatario
            // 
            this.LblDestinatario.AutoSize = true;
            this.LblDestinatario.Location = new System.Drawing.Point(29, 64);
            this.LblDestinatario.Name = "LblDestinatario";
            this.LblDestinatario.Size = new System.Drawing.Size(66, 13);
            this.LblDestinatario.TabIndex = 14;
            this.LblDestinatario.Text = "Destinatário:";
            // 
            // TxtSubject
            // 
            this.TxtSubject.Location = new System.Drawing.Point(97, 88);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Size = new System.Drawing.Size(308, 20);
            this.TxtSubject.TabIndex = 13;
            // 
            // TxtTo
            // 
            this.TxtTo.Location = new System.Drawing.Point(97, 61);
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.Size = new System.Drawing.Size(308, 20);
            this.TxtTo.TabIndex = 12;
            // 
            // TxtBody
            // 
            this.TxtBody.Location = new System.Drawing.Point(12, 134);
            this.TxtBody.Multiline = true;
            this.TxtBody.Name = "TxtBody";
            this.TxtBody.Size = new System.Drawing.Size(789, 375);
            this.TxtBody.TabIndex = 16;
            // 
            // FrmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 521);
            this.Controls.Add(this.TxtBody);
            this.Controls.Add(this.LblAssunto);
            this.Controls.Add(this.LblDestinatario);
            this.Controls.Add(this.TxtSubject);
            this.Controls.Add(this.TxtTo);
            this.Controls.Add(this.PnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMessage";
            this.Text = "SACOI - Enviar Mensagem";
            this.PnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblAssunto;
        private System.Windows.Forms.Label LblDestinatario;
        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.TextBox TxtTo;
        private System.Windows.Forms.TextBox TxtBody;
    }
}