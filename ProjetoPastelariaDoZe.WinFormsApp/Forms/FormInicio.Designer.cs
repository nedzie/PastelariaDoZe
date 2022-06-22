namespace ProjetoPastelariaDoZe.WinFormsApp
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonCaixa = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSobre = new System.Windows.Forms.Button();
            this.buttonConfiguracoes = new System.Windows.Forms.Button();
            this.buttonFuncionarios = new System.Windows.Forms.Button();
            this.buttonProdutos = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonComandas = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.panelMenuSuperior = new System.Windows.Forms.Panel();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxProcurarNome = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.panelMenuGeral = new System.Windows.Forms.Panel();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.contextMenuStripInicio = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripSystemTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSystemTrayAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSystemTraySair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSystemTraySobre = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenuLateral.SuspendLayout();
            this.panelMenuSuperior.SuspendLayout();
            this.panelMenuGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.contextMenuStripInicio.SuspendLayout();
            this.contextMenuStripSystemTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.Black;
            this.panelMenuLateral.Controls.Add(this.buttonSair);
            this.panelMenuLateral.Controls.Add(this.buttonCaixa);
            this.panelMenuLateral.Controls.Add(this.buttonLogin);
            this.panelMenuLateral.Controls.Add(this.buttonSobre);
            this.panelMenuLateral.Controls.Add(this.buttonConfiguracoes);
            this.panelMenuLateral.Controls.Add(this.buttonFuncionarios);
            this.panelMenuLateral.Controls.Add(this.buttonProdutos);
            this.panelMenuLateral.Controls.Add(this.buttonClientes);
            this.panelMenuLateral.Controls.Add(this.buttonComandas);
            this.panelMenuLateral.Controls.Add(this.buttonInicio);
            this.panelMenuLateral.Location = new System.Drawing.Point(-1, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(211, 679);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Transparent;
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.fechar_solido_branco;
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSair.Location = new System.Drawing.Point(1, 551);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(210, 44);
            this.buttonSair.TabIndex = 9;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            // 
            // buttonCaixa
            // 
            this.buttonCaixa.BackColor = System.Drawing.Color.Transparent;
            this.buttonCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCaixa.FlatAppearance.BorderSize = 0;
            this.buttonCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.buttonCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaixa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCaixa.ForeColor = System.Drawing.Color.White;
            this.buttonCaixa.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.caixa_solido_branco;
            this.buttonCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCaixa.Location = new System.Drawing.Point(0, 240);
            this.buttonCaixa.Name = "buttonCaixa";
            this.buttonCaixa.Size = new System.Drawing.Size(213, 44);
            this.buttonCaixa.TabIndex = 2;
            this.buttonCaixa.Text = "Caixa";
            this.buttonCaixa.UseVisualStyleBackColor = false;
            this.buttonCaixa.Click += new System.EventHandler(this.buttonCaixa_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.user_friends_solid;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(1, 0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(210, 103);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonSobre
            // 
            this.buttonSobre.BackColor = System.Drawing.Color.Transparent;
            this.buttonSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSobre.FlatAppearance.BorderSize = 0;
            this.buttonSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSobre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSobre.ForeColor = System.Drawing.Color.White;
            this.buttonSobre.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.sobre_solido_branco;
            this.buttonSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSobre.Location = new System.Drawing.Point(1, 504);
            this.buttonSobre.Name = "buttonSobre";
            this.buttonSobre.Size = new System.Drawing.Size(210, 44);
            this.buttonSobre.TabIndex = 8;
            this.buttonSobre.Text = "Sobre";
            this.buttonSobre.UseVisualStyleBackColor = false;
            this.buttonSobre.Click += new System.EventHandler(this.buttonSobre_Click);
            // 
            // buttonConfiguracoes
            // 
            this.buttonConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfiguracoes.FlatAppearance.BorderSize = 0;
            this.buttonConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.buttonConfiguracoes.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.barras_configuracoes_solido_branco;
            this.buttonConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfiguracoes.Location = new System.Drawing.Point(1, 460);
            this.buttonConfiguracoes.Name = "buttonConfiguracoes";
            this.buttonConfiguracoes.Size = new System.Drawing.Size(210, 44);
            this.buttonConfiguracoes.TabIndex = 7;
            this.buttonConfiguracoes.Text = "Configurações";
            this.buttonConfiguracoes.UseVisualStyleBackColor = false;
            this.buttonConfiguracoes.Click += new System.EventHandler(this.buttonConfiguracoes_Click);
            // 
            // buttonFuncionarios
            // 
            this.buttonFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.buttonFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFuncionarios.FlatAppearance.BorderSize = 0;
            this.buttonFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.buttonFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFuncionarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFuncionarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFuncionarios.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.funcionarios_solido_branco;
            this.buttonFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFuncionarios.Location = new System.Drawing.Point(0, 284);
            this.buttonFuncionarios.Name = "buttonFuncionarios";
            this.buttonFuncionarios.Size = new System.Drawing.Size(213, 44);
            this.buttonFuncionarios.TabIndex = 3;
            this.buttonFuncionarios.Text = "Funcionários";
            this.buttonFuncionarios.UseVisualStyleBackColor = false;
            this.buttonFuncionarios.Click += new System.EventHandler(this.buttonFuncionarios_Click);
            // 
            // buttonProdutos
            // 
            this.buttonProdutos.BackColor = System.Drawing.Color.Transparent;
            this.buttonProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProdutos.FlatAppearance.BorderSize = 0;
            this.buttonProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProdutos.ForeColor = System.Drawing.Color.White;
            this.buttonProdutos.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.produtos_solido_branco;
            this.buttonProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProdutos.Location = new System.Drawing.Point(0, 416);
            this.buttonProdutos.Name = "buttonProdutos";
            this.buttonProdutos.Size = new System.Drawing.Size(213, 44);
            this.buttonProdutos.TabIndex = 6;
            this.buttonProdutos.Text = "Produtos";
            this.buttonProdutos.UseVisualStyleBackColor = false;
            this.buttonProdutos.Click += new System.EventHandler(this.buttonProdutos_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.BackColor = System.Drawing.Color.Transparent;
            this.buttonClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(175)))));
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClientes.ForeColor = System.Drawing.Color.White;
            this.buttonClientes.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.clientes_solido_branco;
            this.buttonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.Location = new System.Drawing.Point(0, 372);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(213, 44);
            this.buttonClientes.TabIndex = 5;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = false;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonComandas
            // 
            this.buttonComandas.BackColor = System.Drawing.Color.Transparent;
            this.buttonComandas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComandas.FlatAppearance.BorderSize = 0;
            this.buttonComandas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.buttonComandas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComandas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonComandas.ForeColor = System.Drawing.Color.White;
            this.buttonComandas.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.comanda_solido_branco;
            this.buttonComandas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComandas.Location = new System.Drawing.Point(1, 328);
            this.buttonComandas.Name = "buttonComandas";
            this.buttonComandas.Size = new System.Drawing.Size(213, 44);
            this.buttonComandas.TabIndex = 4;
            this.buttonComandas.Text = "Comandas";
            this.buttonComandas.UseVisualStyleBackColor = false;
            this.buttonComandas.Click += new System.EventHandler(this.buttonComandas_Click);
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackColor = System.Drawing.Color.Transparent;
            this.buttonInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInicio.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.inicio_solido_branco;
            this.buttonInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInicio.Location = new System.Drawing.Point(0, 196);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(213, 44);
            this.buttonInicio.TabIndex = 1;
            this.buttonInicio.Text = "Início";
            this.buttonInicio.UseVisualStyleBackColor = false;
            // 
            // panelMenuSuperior
            // 
            this.panelMenuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenuSuperior.Controls.Add(this.buttonPesquisar);
            this.panelMenuSuperior.Controls.Add(this.textBoxProcurarNome);
            this.panelMenuSuperior.Controls.Add(this.labelGroup);
            this.panelMenuSuperior.Controls.Add(this.labelNome);
            this.panelMenuSuperior.Controls.Add(this.labelGrupo);
            this.panelMenuSuperior.Controls.Add(this.labelUsuario);
            this.panelMenuSuperior.Location = new System.Drawing.Point(209, 0);
            this.panelMenuSuperior.Name = "panelMenuSuperior";
            this.panelMenuSuperior.Size = new System.Drawing.Size(1098, 103);
            this.panelMenuSuperior.TabIndex = 1;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.White;
            this.buttonPesquisar.Enabled = false;
            this.buttonPesquisar.FlatAppearance.BorderSize = 0;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPesquisar.Location = new System.Drawing.Point(249, 36);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(92, 33);
            this.buttonPesquisar.TabIndex = 5;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // textBoxProcurarNome
            // 
            this.textBoxProcurarNome.Enabled = false;
            this.textBoxProcurarNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProcurarNome.Location = new System.Drawing.Point(18, 36);
            this.textBoxProcurarNome.Name = "textBoxProcurarNome";
            this.textBoxProcurarNome.Size = new System.Drawing.Size(225, 33);
            this.textBoxProcurarNome.TabIndex = 4;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGroup.ForeColor = System.Drawing.Color.White;
            this.labelGroup.Location = new System.Drawing.Point(939, 57);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(58, 15);
            this.labelGroup.TabIndex = 3;
            this.labelGroup.Text = "                 ";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(939, 30);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(58, 15);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "                 ";
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.ForeColor = System.Drawing.Color.White;
            this.labelGrupo.Location = new System.Drawing.Point(873, 57);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(43, 15);
            this.labelGrupo.TabIndex = 1;
            this.labelGrupo.Text = "Grupo:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(873, 30);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(50, 15);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuário:";
            // 
            // panelMenuGeral
            // 
            this.panelMenuGeral.BackColor = System.Drawing.Color.Gray;
            this.panelMenuGeral.Controls.Add(this.dataGridViewDados);
            this.panelMenuGeral.Location = new System.Drawing.Point(209, 103);
            this.panelMenuGeral.Name = "panelMenuGeral";
            this.panelMenuGeral.Size = new System.Drawing.Size(1098, 576);
            this.panelMenuGeral.TabIndex = 2;
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AllowUserToDeleteRows = false;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDados.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDados.MultiSelect = false;
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.RowTemplate.Height = 25;
            this.dataGridViewDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDados.Size = new System.Drawing.Size(1098, 576);
            this.dataGridViewDados.TabIndex = 1;
            this.dataGridViewDados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewDados_MouseDoubleClick);
            // 
            // contextMenuStripInicio
            // 
            this.contextMenuStripInicio.BackColor = System.Drawing.Color.White;
            this.contextMenuStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInicio,
            this.toolStripSeparator1,
            this.toolStripMenuItemFuncionarios,
            this.toolStripMenuItemClientes,
            this.toolStripMenuItemProdutos,
            this.toolStripSeparator2,
            this.toolStripMenuItemSobre,
            this.toolStripMenuItemConfiguracoes,
            this.toolStripSeparator3,
            this.toolStripMenuItemLogin,
            this.toolStripSeparator4,
            this.toolStripMenuItemSair});
            this.contextMenuStripInicio.Name = "contextMenuStripInicio";
            this.contextMenuStripInicio.Size = new System.Drawing.Size(203, 204);
            // 
            // toolStripMenuItemInicio
            // 
            this.toolStripMenuItemInicio.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItemInicio.Name = "toolStripMenuItemInicio";
            this.toolStripMenuItemInicio.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.toolStripMenuItemInicio.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemInicio.Text = "Início";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // toolStripMenuItemFuncionarios
            // 
            this.toolStripMenuItemFuncionarios.Name = "toolStripMenuItemFuncionarios";
            this.toolStripMenuItemFuncionarios.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
            this.toolStripMenuItemFuncionarios.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemFuncionarios.Text = "Funcionários";
            // 
            // toolStripMenuItemClientes
            // 
            this.toolStripMenuItemClientes.Name = "toolStripMenuItemClientes";
            this.toolStripMenuItemClientes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.toolStripMenuItemClientes.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemClientes.Text = "Clientes";
            // 
            // toolStripMenuItemProdutos
            // 
            this.toolStripMenuItemProdutos.Name = "toolStripMenuItemProdutos";
            this.toolStripMenuItemProdutos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItemProdutos.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemProdutos.Text = "Produtos";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // toolStripMenuItemSobre
            // 
            this.toolStripMenuItemSobre.Name = "toolStripMenuItemSobre";
            this.toolStripMenuItemSobre.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F8)));
            this.toolStripMenuItemSobre.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemSobre.Text = "Sobre";
            // 
            // toolStripMenuItemConfiguracoes
            // 
            this.toolStripMenuItemConfiguracoes.Name = "toolStripMenuItemConfiguracoes";
            this.toolStripMenuItemConfiguracoes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F9)));
            this.toolStripMenuItemConfiguracoes.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemConfiguracoes.Text = "Configurações";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // toolStripMenuItemLogin
            // 
            this.toolStripMenuItemLogin.Name = "toolStripMenuItemLogin";
            this.toolStripMenuItemLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10)));
            this.toolStripMenuItemLogin.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemLogin.Text = "Login";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
            // 
            // toolStripMenuItemSair
            // 
            this.toolStripMenuItemSair.Name = "toolStripMenuItemSair";
            this.toolStripMenuItemSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F11)));
            this.toolStripMenuItemSair.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemSair.Text = "Sair";
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconSystemTray.BalloonTipText = "A aplicação continuará rodando em segundo plano";
            this.notifyIconSystemTray.BalloonTipTitle = "Pastelaria do Zé";
            this.notifyIconSystemTray.ContextMenuStrip = this.contextMenuStripSystemTray;
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "Pastelaria Do Zé";
            this.notifyIconSystemTray.Visible = true;
            this.notifyIconSystemTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseDoubleClick);
            // 
            // contextMenuStripSystemTray
            // 
            this.contextMenuStripSystemTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSystemTrayAbrir,
            this.toolStripMenuItemSystemTraySair,
            this.toolStripMenuItemSystemTraySobre});
            this.contextMenuStripSystemTray.Name = "contextMenuStripSystemTray";
            this.contextMenuStripSystemTray.Size = new System.Drawing.Size(105, 70);
            // 
            // toolStripMenuItemSystemTrayAbrir
            // 
            this.toolStripMenuItemSystemTrayAbrir.Name = "toolStripMenuItemSystemTrayAbrir";
            this.toolStripMenuItemSystemTrayAbrir.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItemSystemTrayAbrir.Text = "Abrir";
            // 
            // toolStripMenuItemSystemTraySair
            // 
            this.toolStripMenuItemSystemTraySair.Name = "toolStripMenuItemSystemTraySair";
            this.toolStripMenuItemSystemTraySair.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItemSystemTraySair.Text = "Sair";
            // 
            // toolStripMenuItemSystemTraySobre
            // 
            this.toolStripMenuItemSystemTraySobre.Name = "toolStripMenuItemSystemTraySobre";
            this.toolStripMenuItemSystemTraySobre.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItemSystemTraySobre.Text = "Sobre";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1307, 679);
            this.ContextMenuStrip = this.contextMenuStripInicio;
            this.Controls.Add(this.panelMenuGeral);
            this.Controls.Add(this.panelMenuSuperior);
            this.Controls.Add(this.panelMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Resize += new System.EventHandler(this.Inicio_Resize);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelMenuSuperior.ResumeLayout(false);
            this.panelMenuSuperior.PerformLayout();
            this.panelMenuGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.contextMenuStripInicio.ResumeLayout(false);
            this.contextMenuStripSystemTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuLateral;
        private Panel panelMenuSuperior;
        private Panel panelMenuGeral;
        private Button buttonInicio;
        private Button buttonComandas;
        private Button buttonFuncionarios;
        private Button buttonProdutos;
        private Button buttonClientes;
        private Button buttonLogin;
        private Button buttonSobre;
        private Button buttonConfiguracoes;
        private Button buttonCaixa;
        private ToolStripMenuItem toolStripMenuItemInicio;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemLogin;
        private ToolStripMenuItem toolStripMenuItemFuncionarios;
        private ToolStripMenuItem toolStripMenuItemClientes;
        private ToolStripMenuItem toolStripMenuItemProdutos;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItemConfiguracoes;
        private ToolStripMenuItem toolStripMenuItemSobre;
        private ToolStripMenuItem toolStripMenuItemSair;
        /// <summary>
        /// Menu de contexto do menu inicial. Acesse clicando com o botão direito do mouse em algum local do mesmo.
        /// </summary>
        public ContextMenuStrip contextMenuStripInicio;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private NotifyIcon notifyIconSystemTray;
        private ContextMenuStrip contextMenuStripSystemTray;
        private ToolStripMenuItem toolStripMenuItemSystemTrayAbrir;
        private ToolStripMenuItem toolStripMenuItemSystemTraySair;
        private ToolStripMenuItem toolStripMenuItemSystemTraySobre;
        private Button buttonSair;
        private DataGridView dataGridViewDados;
        private Label labelGrupo;
        private Label labelUsuario;
        private Label labelGroup;
        private Label labelNome;
        private Button buttonPesquisar;
        private TextBox textBoxProcurarNome;
    }
}