namespace SacoiIII.Views
{
    partial class FrmInfoMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoMessage));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblSender = new System.Windows.Forms.Label();
            this.LblAbout = new System.Windows.Forms.Label();
            this.LblText = new System.Windows.Forms.Label();
            this.PnlMenu.SuspendLayout();
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
            this.PnlMenu.Size = new System.Drawing.Size(387, 40);
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
            this.BtnSair.Location = new System.Drawing.Point(301, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(84, 38);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = " &Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblSender
            // 
            this.LblSender.AutoSize = true;
            this.LblSender.Location = new System.Drawing.Point(13, 47);
            this.LblSender.Name = "LblSender";
            this.LblSender.Size = new System.Drawing.Size(41, 15);
            this.LblSender.TabIndex = 8;
            this.LblSender.Text = "label1";
            // 
            // LblAbout
            // 
            this.LblAbout.AutoSize = true;
            this.LblAbout.Location = new System.Drawing.Point(12, 71);
            this.LblAbout.Name = "LblAbout";
            this.LblAbout.Size = new System.Drawing.Size(41, 15);
            this.LblAbout.TabIndex = 9;
            this.LblAbout.Text = "label1";
            // 
            // LblText
            // 
            this.LblText.Location = new System.Drawing.Point(13, 99);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(362, 253);
            this.LblText.TabIndex = 10;
            this.LblText.Text = "label1";
            // 
            // FrmInfoMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSair;
            this.ClientSize = new System.Drawing.Size(387, 361);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.LblAbout);
            this.Controls.Add(this.LblSender);
            this.Controls.Add(this.PnlMenu);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInfoMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SACOI - Detalhes da Mensage";
            this.PnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblSender;
        private System.Windows.Forms.Label LblAbout;
        private System.Windows.Forms.Label LblText;
    }
}