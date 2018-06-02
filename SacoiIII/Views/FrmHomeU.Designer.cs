namespace SacoiIII.Views
{
    partial class FrmHomeU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomeU));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.PnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMenu.Controls.Add(this.BtnInfo);
            this.PnlMenu.Controls.Add(this.BtnSair);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(864, 40);
            this.PnlMenu.TabIndex = 3;
            // 
            // BtnInfo
            // 
            this.BtnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInfo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnInfo.FlatAppearance.BorderSize = 0;
            this.BtnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.ForeColor = System.Drawing.Color.White;
            this.BtnInfo.Image = global::SacoiIII.Properties.Resources.info;
            this.BtnInfo.Location = new System.Drawing.Point(679, 0);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(90, 38);
            this.BtnInfo.TabIndex = 2;
            this.BtnInfo.TabStop = false;
            this.BtnInfo.Text = " So&bre";
            this.BtnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
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
            this.BtnSair.Location = new System.Drawing.Point(769, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(93, 38);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = " &Fechar";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmHomeU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 521);
            this.Controls.Add(this.PnlMenu);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHomeU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SACOI - Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHomeU_FormClosing);
            this.PnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button BtnSair;
    }
}