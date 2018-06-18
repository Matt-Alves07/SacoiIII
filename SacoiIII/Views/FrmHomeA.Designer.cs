namespace SacoiIII.Views
{
    partial class FrmHomeA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomeA));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnListarUsers = new System.Windows.Forms.Button();
            this.BtnMensagens = new System.Windows.Forms.Button();
            this.BtnRelistar = new System.Windows.Forms.Button();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.BtnListarNotificacoes = new System.Windows.Forms.Button();
            this.BtnListPedidoAdmin = new System.Windows.Forms.Button();
            this.BtnAtualizarCadastro = new System.Windows.Forms.Button();
            this.BtnSolicitaExclusao = new System.Windows.Forms.Button();
            this.BtnListPedidoExlusao = new System.Windows.Forms.Button();
            this.BtnShare = new System.Windows.Forms.Button();
            this.PnlInfo = new System.Windows.Forms.Panel();
            this.PnlOptions = new System.Windows.Forms.Panel();
            this.TblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.LblUserName = new System.Windows.Forms.Label();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.PicBoxAdmin = new System.Windows.Forms.PictureBox();
            this.lbl_img_pencil = new System.Windows.Forms.Label();
            this.PnlFeed = new System.Windows.Forms.Panel();
            this.PnlNewNotification = new System.Windows.Forms.Panel();
            this.PnlButtonShare = new System.Windows.Forms.Panel();
            this.TxtNotification = new System.Windows.Forms.TextBox();
            this.PnlMenu.SuspendLayout();
            this.PnlInfo.SuspendLayout();
            this.PnlOptions.SuspendLayout();
            this.TblButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxAdmin)).BeginInit();
            this.PnlNewNotification.SuspendLayout();
            this.PnlButtonShare.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.PnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMenu.Controls.Add(this.BtnListarUsers);
            this.PnlMenu.Controls.Add(this.BtnMensagens);
            this.PnlMenu.Controls.Add(this.BtnRelistar);
            this.PnlMenu.Controls.Add(this.BtnInfo);
            this.PnlMenu.Controls.Add(this.BtnSair);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(864, 40);
            this.PnlMenu.TabIndex = 4;
            // 
            // BtnListarUsers
            // 
            this.BtnListarUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListarUsers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnListarUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnListarUsers.FlatAppearance.BorderSize = 0;
            this.BtnListarUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnListarUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListarUsers.ForeColor = System.Drawing.Color.White;
            this.BtnListarUsers.Image = global::SacoiIII.Properties.Resources.user_list_24w;
            this.BtnListarUsers.Location = new System.Drawing.Point(218, 0);
            this.BtnListarUsers.Name = "BtnListarUsers";
            this.BtnListarUsers.Size = new System.Drawing.Size(127, 38);
            this.BtnListarUsers.TabIndex = 7;
            this.BtnListarUsers.TabStop = false;
            this.BtnListarUsers.Text = " &Listar Usuários";
            this.BtnListarUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnListarUsers, "Clique aqui para listar os usuários cadastrados");
            this.BtnListarUsers.UseVisualStyleBackColor = true;
            this.BtnListarUsers.Click += new System.EventHandler(this.BtnListarUsers_Click);
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
            this.BtnMensagens.Image = global::SacoiIII.Properties.Resources.email_24w;
            this.BtnMensagens.Location = new System.Drawing.Point(109, 0);
            this.BtnMensagens.Name = "BtnMensagens";
            this.BtnMensagens.Size = new System.Drawing.Size(109, 38);
            this.BtnMensagens.TabIndex = 6;
            this.BtnMensagens.TabStop = false;
            this.BtnMensagens.Text = " &Mensagens";
            this.BtnMensagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnMensagens, "Clique aqui para exibir suas mensagens");
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
            this.BtnRelistar.TabIndex = 3;
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
            this.BtnListarNotificacoes.Location = new System.Drawing.Point(3, 119);
            this.BtnListarNotificacoes.Name = "BtnListarNotificacoes";
            this.BtnListarNotificacoes.Size = new System.Drawing.Size(207, 27);
            this.BtnListarNotificacoes.TabIndex = 11;
            this.BtnListarNotificacoes.Text = "Listar todas notificações";
            this.Hint.SetToolTip(this.BtnListarNotificacoes, "Clique aqui para visualizar todas as notificações criadas");
            this.BtnListarNotificacoes.UseVisualStyleBackColor = false;
            this.BtnListarNotificacoes.MouseEnter += new System.EventHandler(this.BtnListarNotificacoes_MouseEnter);
            this.BtnListarNotificacoes.MouseLeave += new System.EventHandler(this.BtnListarNotificacoes_MouseLeave);
            // 
            // BtnListPedidoAdmin
            // 
            this.BtnListPedidoAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnListPedidoAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListPedidoAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnListPedidoAdmin.FlatAppearance.BorderSize = 0;
            this.BtnListPedidoAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnListPedidoAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.BtnListPedidoAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListPedidoAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListPedidoAdmin.ForeColor = System.Drawing.Color.Black;
            this.BtnListPedidoAdmin.Location = new System.Drawing.Point(3, 90);
            this.BtnListPedidoAdmin.Name = "BtnListPedidoAdmin";
            this.BtnListPedidoAdmin.Size = new System.Drawing.Size(207, 23);
            this.BtnListPedidoAdmin.TabIndex = 10;
            this.BtnListPedidoAdmin.Text = "Listar Pedidos de Administrador";
            this.Hint.SetToolTip(this.BtnListPedidoAdmin, "Clique aqui para listar as solicitações de usuários que desejam se tornar adminis" +
        "tradores");
            this.BtnListPedidoAdmin.UseVisualStyleBackColor = false;
            this.BtnListPedidoAdmin.Click += new System.EventHandler(this.BtnListPedidoAdmin_Click);
            this.BtnListPedidoAdmin.MouseEnter += new System.EventHandler(this.BtnListPedidoAdmin_MouseEnter);
            this.BtnListPedidoAdmin.MouseLeave += new System.EventHandler(this.BtnListPedidoAdmin_MouseLeave);
            // 
            // BtnAtualizarCadastro
            // 
            this.BtnAtualizarCadastro.BackColor = System.Drawing.Color.Transparent;
            this.BtnAtualizarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtualizarCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAtualizarCadastro.FlatAppearance.BorderSize = 0;
            this.BtnAtualizarCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAtualizarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.BtnAtualizarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizarCadastro.ForeColor = System.Drawing.Color.Black;
            this.BtnAtualizarCadastro.Location = new System.Drawing.Point(3, 32);
            this.BtnAtualizarCadastro.Name = "BtnAtualizarCadastro";
            this.BtnAtualizarCadastro.Size = new System.Drawing.Size(207, 23);
            this.BtnAtualizarCadastro.TabIndex = 8;
            this.BtnAtualizarCadastro.Text = "Atualizar Cadastro";
            this.Hint.SetToolTip(this.BtnAtualizarCadastro, "Clique aqui para atualizar seu cadastro");
            this.BtnAtualizarCadastro.UseVisualStyleBackColor = false;
            this.BtnAtualizarCadastro.MouseEnter += new System.EventHandler(this.BtnAtualizarCadastro_MouseEnter);
            this.BtnAtualizarCadastro.MouseLeave += new System.EventHandler(this.BtnAtualizarCadastro_MouseLeave);
            // 
            // BtnSolicitaExclusao
            // 
            this.BtnSolicitaExclusao.BackColor = System.Drawing.Color.Transparent;
            this.BtnSolicitaExclusao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSolicitaExclusao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSolicitaExclusao.FlatAppearance.BorderSize = 0;
            this.BtnSolicitaExclusao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnSolicitaExclusao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.BtnSolicitaExclusao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSolicitaExclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSolicitaExclusao.ForeColor = System.Drawing.Color.Black;
            this.BtnSolicitaExclusao.Location = new System.Drawing.Point(3, 3);
            this.BtnSolicitaExclusao.Name = "BtnSolicitaExclusao";
            this.BtnSolicitaExclusao.Size = new System.Drawing.Size(207, 23);
            this.BtnSolicitaExclusao.TabIndex = 7;
            this.BtnSolicitaExclusao.Text = "Solicitar Exclusão";
            this.Hint.SetToolTip(this.BtnSolicitaExclusao, "Clique aqui para solicitar a exclusão do seu cadastro");
            this.BtnSolicitaExclusao.UseVisualStyleBackColor = false;
            this.BtnSolicitaExclusao.MouseEnter += new System.EventHandler(this.BtnSolicitaExclusao_MouseEnter);
            this.BtnSolicitaExclusao.MouseLeave += new System.EventHandler(this.BtnSolicitaExclusao_MouseLeave);
            // 
            // BtnListPedidoExlusao
            // 
            this.BtnListPedidoExlusao.AutoSize = true;
            this.BtnListPedidoExlusao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListPedidoExlusao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnListPedidoExlusao.FlatAppearance.BorderSize = 0;
            this.BtnListPedidoExlusao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnListPedidoExlusao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.BtnListPedidoExlusao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListPedidoExlusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListPedidoExlusao.Location = new System.Drawing.Point(3, 61);
            this.BtnListPedidoExlusao.Name = "BtnListPedidoExlusao";
            this.BtnListPedidoExlusao.Size = new System.Drawing.Size(207, 23);
            this.BtnListPedidoExlusao.TabIndex = 9;
            this.BtnListPedidoExlusao.Text = "Listar Pedidos de Exclusão";
            this.Hint.SetToolTip(this.BtnListPedidoExlusao, "Clique aqui para listar os pedidos de exclusão");
            this.BtnListPedidoExlusao.UseVisualStyleBackColor = true;
            this.BtnListPedidoExlusao.Click += new System.EventHandler(this.BtnListPedidoExlusao_Click);
            this.BtnListPedidoExlusao.MouseEnter += new System.EventHandler(this.BtnListPedidoExlusao_MouseEnter);
            this.BtnListPedidoExlusao.MouseLeave += new System.EventHandler(this.BtnListPedidoExlusao_MouseLeave);
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
            this.BtnShare.Location = new System.Drawing.Point(540, 0);
            this.BtnShare.Name = "BtnShare";
            this.BtnShare.Size = new System.Drawing.Size(90, 40);
            this.BtnShare.TabIndex = 2;
            this.BtnShare.Text = "Notificar";
            this.BtnShare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hint.SetToolTip(this.BtnShare, "Clique aqui para enviar essa notificação");
            this.BtnShare.UseVisualStyleBackColor = false;
            this.BtnShare.Click += new System.EventHandler(this.BtnShare_Click);
            this.BtnShare.MouseEnter += new System.EventHandler(this.BtnShare_MouseEnter);
            this.BtnShare.MouseLeave += new System.EventHandler(this.BtnShare_MouseLeave);
            // 
            // PnlInfo
            // 
            this.PnlInfo.BackColor = System.Drawing.Color.White;
            this.PnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlInfo.Controls.Add(this.PnlOptions);
            this.PnlInfo.Controls.Add(this.PnlBottom);
            this.PnlInfo.Controls.Add(this.PicBoxAdmin);
            this.PnlInfo.Controls.Add(this.lbl_img_pencil);
            this.PnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlInfo.Location = new System.Drawing.Point(0, 40);
            this.PnlInfo.Name = "PnlInfo";
            this.PnlInfo.Size = new System.Drawing.Size(215, 481);
            this.PnlInfo.TabIndex = 5;
            // 
            // PnlOptions
            // 
            this.PnlOptions.Controls.Add(this.TblButtons);
            this.PnlOptions.Controls.Add(this.LblUserName);
            this.PnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlOptions.Location = new System.Drawing.Point(0, 80);
            this.PnlOptions.Name = "PnlOptions";
            this.PnlOptions.Size = new System.Drawing.Size(213, 195);
            this.PnlOptions.TabIndex = 9;
            // 
            // TblButtons
            // 
            this.TblButtons.ColumnCount = 1;
            this.TblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblButtons.Controls.Add(this.BtnListarNotificacoes, 0, 4);
            this.TblButtons.Controls.Add(this.BtnListPedidoAdmin, 0, 3);
            this.TblButtons.Controls.Add(this.BtnAtualizarCadastro, 0, 1);
            this.TblButtons.Controls.Add(this.BtnSolicitaExclusao, 0, 0);
            this.TblButtons.Controls.Add(this.BtnListPedidoExlusao, 0, 2);
            this.TblButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.TblButtons.Location = new System.Drawing.Point(0, 45);
            this.TblButtons.Name = "TblButtons";
            this.TblButtons.RowCount = 5;
            this.TblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblButtons.Size = new System.Drawing.Size(213, 149);
            this.TblButtons.TabIndex = 13;
            // 
            // LblUserName
            // 
            this.LblUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.Black;
            this.LblUserName.Location = new System.Drawing.Point(0, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(213, 45);
            this.LblUserName.TabIndex = 10;
            this.LblUserName.Text = "Olá, ";
            this.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlBottom
            // 
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBottom.Location = new System.Drawing.Point(0, 80);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(213, 399);
            this.PnlBottom.TabIndex = 7;
            // 
            // PicBoxAdmin
            // 
            this.PicBoxAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicBoxAdmin.Image = global::SacoiIII.Properties.Resources.manager_profile_64b;
            this.PicBoxAdmin.Location = new System.Drawing.Point(0, 0);
            this.PicBoxAdmin.Name = "PicBoxAdmin";
            this.PicBoxAdmin.Size = new System.Drawing.Size(213, 80);
            this.PicBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicBoxAdmin.TabIndex = 5;
            this.PicBoxAdmin.TabStop = false;
            // 
            // lbl_img_pencil
            // 
            this.lbl_img_pencil.Location = new System.Drawing.Point(77, 183);
            this.lbl_img_pencil.Name = "lbl_img_pencil";
            this.lbl_img_pencil.Size = new System.Drawing.Size(37, 27);
            this.lbl_img_pencil.TabIndex = 0;
            // 
            // PnlFeed
            // 
            this.PnlFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlFeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlFeed.BackColor = System.Drawing.Color.White;
            this.PnlFeed.Location = new System.Drawing.Point(222, 198);
            this.PnlFeed.Name = "PnlFeed";
            this.PnlFeed.Size = new System.Drawing.Size(630, 311);
            this.PnlFeed.TabIndex = 10;
            // 
            // PnlNewNotification
            // 
            this.PnlNewNotification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlNewNotification.BackColor = System.Drawing.Color.White;
            this.PnlNewNotification.Controls.Add(this.PnlButtonShare);
            this.PnlNewNotification.Controls.Add(this.TxtNotification);
            this.PnlNewNotification.Location = new System.Drawing.Point(222, 45);
            this.PnlNewNotification.Name = "PnlNewNotification";
            this.PnlNewNotification.Size = new System.Drawing.Size(630, 147);
            this.PnlNewNotification.TabIndex = 9;
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
            // FrmHomeA
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
            this.Name = "FrmHomeA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SACOI - Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHomeA_FormClosing);
            this.Load += new System.EventHandler(this.FrmHomeA_Load);
            this.Resize += new System.EventHandler(this.FrmHomeA_Resize);
            this.PnlMenu.ResumeLayout(false);
            this.PnlInfo.ResumeLayout(false);
            this.PnlOptions.ResumeLayout(false);
            this.TblButtons.ResumeLayout(false);
            this.TblButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxAdmin)).EndInit();
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
        private System.Windows.Forms.Button BtnListarUsers;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.Panel PnlInfo;
        private System.Windows.Forms.Label lbl_img_pencil;
        private System.Windows.Forms.PictureBox PicBoxAdmin;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel PnlOptions;
        private System.Windows.Forms.TableLayoutPanel TblButtons;
        private System.Windows.Forms.Button BtnListarNotificacoes;
        private System.Windows.Forms.Button BtnListPedidoAdmin;
        private System.Windows.Forms.Button BtnAtualizarCadastro;
        private System.Windows.Forms.Button BtnSolicitaExclusao;
        private System.Windows.Forms.Button BtnListPedidoExlusao;
        public System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Panel PnlFeed;
        private System.Windows.Forms.Panel PnlNewNotification;
        private System.Windows.Forms.TextBox TxtNotification;
        private System.Windows.Forms.Panel PnlButtonShare;
        private System.Windows.Forms.Button BtnShare;
    }
}