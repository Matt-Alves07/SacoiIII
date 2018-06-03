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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomeU));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.BtnListarNotificacoes = new System.Windows.Forms.Button();
            this.BtnSolExcluir = new System.Windows.Forms.Button();
            this.BtnSolModerar = new System.Windows.Forms.Button();
            this.BtnUserAtualizar = new System.Windows.Forms.Button();
            this.PnlInfo = new System.Windows.Forms.Panel();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.TblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.LblUserName = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PicBoxUser = new System.Windows.Forms.PictureBox();
            this.BtnMensagens = new System.Windows.Forms.Button();
            this.BtnRelistar = new System.Windows.Forms.Button();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.PnlFeed = new System.Windows.Forms.Panel();
            this.PnlNewNotification = new System.Windows.Forms.Panel();
            this.PnlButtonShare = new System.Windows.Forms.Panel();
            this.BtnShare = new System.Windows.Forms.Button();
            this.TxtNotification = new System.Windows.Forms.TextBox();
            this.PnlMenu.SuspendLayout();
            this.PnlInfo.SuspendLayout();
            this.TblButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxUser)).BeginInit();
            this.PnlNewNotification.SuspendLayout();
            this.PnlButtonShare.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.PnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMenu.Controls.Add(this.BtnMensagens);
            this.PnlMenu.Controls.Add(this.BtnRelistar);
            this.PnlMenu.Controls.Add(this.BtnInfo);
            this.PnlMenu.Controls.Add(this.BtnSair);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(864, 40);
            this.PnlMenu.TabIndex = 5;
            // 
            // BtnListarNotificacoes
            // 
            this.BtnListarNotificacoes.BackColor = System.Drawing.Color.Transparent;
            this.BtnListarNotificacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListarNotificacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnListarNotificacoes.FlatAppearance.BorderSize = 0;
            this.BtnListarNotificacoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnListarNotificacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.BtnListarNotificacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListarNotificacoes.ForeColor = System.Drawing.Color.Black;
            this.BtnListarNotificacoes.Location = new System.Drawing.Point(3, 81);
            this.BtnListarNotificacoes.Name = "BtnListarNotificacoes";
            this.BtnListarNotificacoes.Size = new System.Drawing.Size(209, 23);
            this.BtnListarNotificacoes.TabIndex = 5;
            this.BtnListarNotificacoes.Text = "Listar todas notificações";
            this.Hint.SetToolTip(this.BtnListarNotificacoes, "Clique aqui para visualizar todas as notificações criadas");
            this.BtnListarNotificacoes.UseVisualStyleBackColor = false;
            this.BtnListarNotificacoes.MouseEnter += new System.EventHandler(this.BtnListarNotificacoes_MouseEnter);
            this.BtnListarNotificacoes.MouseLeave += new System.EventHandler(this.BtnListarNotificacoes_MouseLeave);
            // 
            // BtnSolExcluir
            // 
            this.BtnSolExcluir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSolExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSolExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSolExcluir.FlatAppearance.BorderSize = 0;
            this.BtnSolExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnSolExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.BtnSolExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSolExcluir.ForeColor = System.Drawing.Color.Black;
            this.BtnSolExcluir.Location = new System.Drawing.Point(3, 55);
            this.BtnSolExcluir.Name = "BtnSolExcluir";
            this.BtnSolExcluir.Size = new System.Drawing.Size(209, 20);
            this.BtnSolExcluir.TabIndex = 4;
            this.BtnSolExcluir.Text = "Solicitar Exclusão";
            this.Hint.SetToolTip(this.BtnSolExcluir, "Clique aqui para solicitar a exclusão do seu cadastro");
            this.BtnSolExcluir.UseVisualStyleBackColor = false;
            this.BtnSolExcluir.MouseEnter += new System.EventHandler(this.BtnSolExcluir_MouseEnter);
            this.BtnSolExcluir.MouseLeave += new System.EventHandler(this.BtnSolExcluir_MouseLeave);
            // 
            // BtnSolModerar
            // 
            this.BtnSolModerar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSolModerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSolModerar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSolModerar.FlatAppearance.BorderSize = 0;
            this.BtnSolModerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnSolModerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.BtnSolModerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSolModerar.ForeColor = System.Drawing.Color.Black;
            this.BtnSolModerar.Location = new System.Drawing.Point(3, 29);
            this.BtnSolModerar.Name = "BtnSolModerar";
            this.BtnSolModerar.Size = new System.Drawing.Size(209, 20);
            this.BtnSolModerar.TabIndex = 3;
            this.BtnSolModerar.Text = "Solicitar Moderação";
            this.Hint.SetToolTip(this.BtnSolModerar, "Clique aqui para solicitar a mudança para o perfil de administrador");
            this.BtnSolModerar.UseVisualStyleBackColor = false;
            this.BtnSolModerar.MouseEnter += new System.EventHandler(this.BtnSolModerar_MouseEnter);
            this.BtnSolModerar.MouseLeave += new System.EventHandler(this.BtnSolModerar_MouseLeave);
            // 
            // BtnUserAtualizar
            // 
            this.BtnUserAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnUserAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserAtualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUserAtualizar.FlatAppearance.BorderSize = 0;
            this.BtnUserAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnUserAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.BtnUserAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserAtualizar.ForeColor = System.Drawing.Color.Black;
            this.BtnUserAtualizar.Location = new System.Drawing.Point(3, 3);
            this.BtnUserAtualizar.Name = "BtnUserAtualizar";
            this.BtnUserAtualizar.Size = new System.Drawing.Size(209, 20);
            this.BtnUserAtualizar.TabIndex = 2;
            this.BtnUserAtualizar.Text = "Atualizar Cadastro";
            this.Hint.SetToolTip(this.BtnUserAtualizar, "Clique aqui para atualizar seu cadastro");
            this.BtnUserAtualizar.UseVisualStyleBackColor = false;
            this.BtnUserAtualizar.MouseEnter += new System.EventHandler(this.BtnUserAtualizar_MouseEnter);
            this.BtnUserAtualizar.MouseLeave += new System.EventHandler(this.BtnUserAtualizar_MouseLeave);
            // 
            // PnlInfo
            // 
            this.PnlInfo.BackColor = System.Drawing.Color.White;
            this.PnlInfo.Controls.Add(this.PnlBottom);
            this.PnlInfo.Controls.Add(this.TblButtons);
            this.PnlInfo.Controls.Add(this.LblUserName);
            this.PnlInfo.Controls.Add(this.PicBoxUser);
            this.PnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlInfo.Location = new System.Drawing.Point(0, 40);
            this.PnlInfo.Name = "PnlInfo";
            this.PnlInfo.Size = new System.Drawing.Size(215, 481);
            this.PnlInfo.TabIndex = 6;
            // 
            // PnlBottom
            // 
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBottom.Location = new System.Drawing.Point(0, 232);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(215, 249);
            this.PnlBottom.TabIndex = 11;
            // 
            // TblButtons
            // 
            this.TblButtons.ColumnCount = 1;
            this.TblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblButtons.Controls.Add(this.BtnListarNotificacoes, 0, 3);
            this.TblButtons.Controls.Add(this.BtnSolExcluir, 0, 2);
            this.TblButtons.Controls.Add(this.BtnSolModerar, 0, 1);
            this.TblButtons.Controls.Add(this.BtnUserAtualizar, 0, 0);
            this.TblButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.TblButtons.Location = new System.Drawing.Point(0, 125);
            this.TblButtons.Name = "TblButtons";
            this.TblButtons.RowCount = 4;
            this.TblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblButtons.Size = new System.Drawing.Size(215, 107);
            this.TblButtons.TabIndex = 10;
            // 
            // LblUserName
            // 
            this.LblUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.Black;
            this.LblUserName.Location = new System.Drawing.Point(0, 80);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(215, 45);
            this.LblUserName.TabIndex = 9;
            this.LblUserName.Text = "Olá, ";
            this.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnSair.Image = global::SacoiIII.Properties.Resources.logout_24w;
            this.BtnSair.Location = new System.Drawing.Point(796, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(66, 38);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = " &Sair";
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnSair, "Clique aqui para efetuar logoff");
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PicBoxUser
            // 
            this.PicBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicBoxUser.Image = global::SacoiIII.Properties.Resources.user_64b;
            this.PicBoxUser.Location = new System.Drawing.Point(0, 0);
            this.PicBoxUser.Name = "PicBoxUser";
            this.PicBoxUser.Size = new System.Drawing.Size(215, 80);
            this.PicBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicBoxUser.TabIndex = 6;
            this.PicBoxUser.TabStop = false;
            // 
            // BtnMensagens
            // 
            this.BtnMensagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMensagens.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMensagens.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMensagens.FlatAppearance.BorderSize = 0;
            this.BtnMensagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnMensagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMensagens.ForeColor = System.Drawing.Color.White;
            this.BtnMensagens.Image = global::SacoiIII.Properties.Resources.email_received_24w;
            this.BtnMensagens.Location = new System.Drawing.Point(109, 0);
            this.BtnMensagens.Name = "BtnMensagens";
            this.BtnMensagens.Size = new System.Drawing.Size(169, 38);
            this.BtnMensagens.TabIndex = 5;
            this.BtnMensagens.TabStop = false;
            this.BtnMensagens.Text = " &Mensagens Recebidas";
            this.BtnMensagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnMensagens, "Clique aqui para listar as mensagens que você recebeu");
            this.BtnMensagens.UseVisualStyleBackColor = true;
            this.BtnMensagens.Click += new System.EventHandler(this.BtnMensagens_Click);
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
            this.BtnRelistar.Size = new System.Drawing.Size(109, 38);
            this.BtnRelistar.TabIndex = 4;
            this.BtnRelistar.TabStop = false;
            this.BtnRelistar.Text = " &Recarregar";
            this.BtnRelistar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnRelistar, "Clique aqui para atualizar a lista de notificações");
            this.BtnRelistar.UseVisualStyleBackColor = true;
            this.BtnRelistar.Click += new System.EventHandler(this.BtnRelistar_Click);
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
            this.BtnInfo.Location = new System.Drawing.Point(706, 0);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(90, 38);
            this.BtnInfo.TabIndex = 2;
            this.BtnInfo.TabStop = false;
            this.BtnInfo.Text = " So&bre";
            this.BtnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnInfo, "Clique aqui para saber mais sobre este programa");
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // PnlFeed
            // 
            this.PnlFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlFeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlFeed.BackColor = System.Drawing.Color.White;
            this.PnlFeed.Location = new System.Drawing.Point(222, 199);
            this.PnlFeed.Name = "PnlFeed";
            this.PnlFeed.Size = new System.Drawing.Size(630, 311);
            this.PnlFeed.TabIndex = 12;
            // 
            // PnlNewNotification
            // 
            this.PnlNewNotification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlNewNotification.BackColor = System.Drawing.Color.White;
            this.PnlNewNotification.Controls.Add(this.PnlButtonShare);
            this.PnlNewNotification.Controls.Add(this.TxtNotification);
            this.PnlNewNotification.Location = new System.Drawing.Point(222, 46);
            this.PnlNewNotification.Name = "PnlNewNotification";
            this.PnlNewNotification.Size = new System.Drawing.Size(630, 147);
            this.PnlNewNotification.TabIndex = 11;
            // 
            // PnlButtonShare
            // 
            this.PnlButtonShare.Controls.Add(this.BtnShare);
            this.PnlButtonShare.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButtonShare.Location = new System.Drawing.Point(0, 107);
            this.PnlButtonShare.Name = "PnlButtonShare";
            this.PnlButtonShare.Size = new System.Drawing.Size(630, 40);
            this.PnlButtonShare.TabIndex = 1;
            // 
            // BtnShare
            // 
            this.BtnShare.BackColor = System.Drawing.Color.Transparent;
            this.BtnShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShare.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnShare.FlatAppearance.BorderSize = 0;
            this.BtnShare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.BtnShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShare.Image = global::SacoiIII.Properties.Resources.share_option_24b;
            this.BtnShare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnShare.Location = new System.Drawing.Point(554, 0);
            this.BtnShare.Name = "BtnShare";
            this.BtnShare.Size = new System.Drawing.Size(76, 40);
            this.BtnShare.TabIndex = 2;
            this.BtnShare.Text = "Enviar";
            this.BtnShare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnShare, "Clique aqui para enviar essa notificação");
            this.BtnShare.UseVisualStyleBackColor = false;
            this.BtnShare.Click += new System.EventHandler(this.BtnShare_Click);
            this.BtnShare.MouseEnter += new System.EventHandler(this.BtnShare_MouseEnter);
            this.BtnShare.MouseLeave += new System.EventHandler(this.BtnShare_MouseLeave);
            // 
            // TxtNotification
            // 
            this.TxtNotification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNotification.Location = new System.Drawing.Point(3, 3);
            this.TxtNotification.MaxLength = 255;
            this.TxtNotification.Multiline = true;
            this.TxtNotification.Name = "TxtNotification";
            this.TxtNotification.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtNotification.Size = new System.Drawing.Size(624, 98);
            this.TxtNotification.TabIndex = 0;
            // 
            // FrmHomeU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSair;
            this.ClientSize = new System.Drawing.Size(864, 521);
            this.Controls.Add(this.PnlFeed);
            this.Controls.Add(this.PnlNewNotification);
            this.Controls.Add(this.PnlInfo);
            this.Controls.Add(this.PnlMenu);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHomeU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SACOI - Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHomeU_FormClosing);
            this.Load += new System.EventHandler(this.FrmHomeU_Load);
            this.PnlMenu.ResumeLayout(false);
            this.PnlInfo.ResumeLayout(false);
            this.TblButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxUser)).EndInit();
            this.PnlNewNotification.ResumeLayout(false);
            this.PnlNewNotification.PerformLayout();
            this.PnlButtonShare.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnRelistar;
        private System.Windows.Forms.Button BtnMensagens;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.Panel PnlInfo;
        private System.Windows.Forms.PictureBox PicBoxUser;
        public System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TableLayoutPanel TblButtons;
        private System.Windows.Forms.Button BtnListarNotificacoes;
        private System.Windows.Forms.Button BtnSolExcluir;
        private System.Windows.Forms.Button BtnSolModerar;
        private System.Windows.Forms.Button BtnUserAtualizar;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel PnlFeed;
        private System.Windows.Forms.Panel PnlNewNotification;
        private System.Windows.Forms.Panel PnlButtonShare;
        private System.Windows.Forms.Button BtnShare;
        private System.Windows.Forms.TextBox TxtNotification;
    }
}