namespace ProjetoPastelariaDoZe.WinFormsApp.Forms
{
    partial class FormCaixa
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
            this.panelComandas = new System.Windows.Forms.Panel();
            this.groupBoxComandas = new System.Windows.Forms.GroupBox();
            this.dataGridViewItensComanda = new System.Windows.Forms.DataGridView();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.comboBoxComandas = new System.Windows.Forms.ComboBox();
            this.labelSelecionarComanda = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.groupBoxDadosCliente = new System.Windows.Forms.GroupBox();
            this.labelInadimplente = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxCompraFiado = new System.Windows.Forms.TextBox();
            this.labelCompraFiado = new System.Windows.Forms.Label();
            this.textBoxVencimento = new System.Windows.Forms.TextBox();
            this.labelVencimento = new System.Windows.Forms.Label();
            this.maskedTextBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.textBoxCodigoCliente = new System.Windows.Forms.TextBox();
            this.labelBuscarCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCaixa = new System.Windows.Forms.Panel();
            this.buttonFiado = new System.Windows.Forms.Button();
            this.buttonAVista = new System.Windows.Forms.Button();
            this.checkBoxComprovante = new System.Windows.Forms.CheckBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelDesconto = new System.Windows.Forms.Label();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.labelJuros = new System.Windows.Forms.Label();
            this.textBoxJuros = new System.Windows.Forms.TextBox();
            this.labelMulta = new System.Windows.Forms.Label();
            this.textBoxMulta = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.panelComandas.SuspendLayout();
            this.groupBoxComandas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensComanda)).BeginInit();
            this.panelCliente.SuspendLayout();
            this.groupBoxDadosCliente.SuspendLayout();
            this.panelCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelComandas
            // 
            this.panelComandas.Controls.Add(this.groupBoxComandas);
            this.panelComandas.Controls.Add(this.buttonPesquisar);
            this.panelComandas.Controls.Add(this.comboBoxComandas);
            this.panelComandas.Controls.Add(this.labelSelecionarComanda);
            this.panelComandas.Location = new System.Drawing.Point(12, 12);
            this.panelComandas.Name = "panelComandas";
            this.panelComandas.Size = new System.Drawing.Size(726, 746);
            this.panelComandas.TabIndex = 0;
            // 
            // groupBoxComandas
            // 
            this.groupBoxComandas.Controls.Add(this.dataGridViewItensComanda);
            this.groupBoxComandas.ForeColor = System.Drawing.Color.White;
            this.groupBoxComandas.Location = new System.Drawing.Point(3, 78);
            this.groupBoxComandas.Name = "groupBoxComandas";
            this.groupBoxComandas.Size = new System.Drawing.Size(720, 454);
            this.groupBoxComandas.TabIndex = 9;
            this.groupBoxComandas.TabStop = false;
            this.groupBoxComandas.Text = "Itens da comanda:";
            // 
            // dataGridViewItensComanda
            // 
            this.dataGridViewItensComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItensComanda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItensComanda.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewItensComanda.Name = "dataGridViewItensComanda";
            this.dataGridViewItensComanda.RowTemplate.Height = 25;
            this.dataGridViewItensComanda.Size = new System.Drawing.Size(714, 432);
            this.dataGridViewItensComanda.TabIndex = 0;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.White;
            this.buttonPesquisar.FlatAppearance.BorderSize = 0;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPesquisar.Location = new System.Drawing.Point(248, 15);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(92, 41);
            this.buttonPesquisar.TabIndex = 8;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            // 
            // comboBoxComandas
            // 
            this.comboBoxComandas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComandas.FormattingEnabled = true;
            this.comboBoxComandas.Location = new System.Drawing.Point(15, 33);
            this.comboBoxComandas.Name = "comboBoxComandas";
            this.comboBoxComandas.Size = new System.Drawing.Size(153, 23);
            this.comboBoxComandas.TabIndex = 1;
            // 
            // labelSelecionarComanda
            // 
            this.labelSelecionarComanda.AutoSize = true;
            this.labelSelecionarComanda.ForeColor = System.Drawing.Color.White;
            this.labelSelecionarComanda.Location = new System.Drawing.Point(15, 15);
            this.labelSelecionarComanda.Name = "labelSelecionarComanda";
            this.labelSelecionarComanda.Size = new System.Drawing.Size(213, 15);
            this.labelSelecionarComanda.TabIndex = 0;
            this.labelSelecionarComanda.Text = "Selecione uma das comanadas abertas:";
            // 
            // panelCliente
            // 
            this.panelCliente.Controls.Add(this.groupBoxDadosCliente);
            this.panelCliente.Controls.Add(this.textBoxCodigoCliente);
            this.panelCliente.Controls.Add(this.labelBuscarCliente);
            this.panelCliente.Controls.Add(this.button1);
            this.panelCliente.Location = new System.Drawing.Point(738, 12);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(294, 525);
            this.panelCliente.TabIndex = 1;
            // 
            // groupBoxDadosCliente
            // 
            this.groupBoxDadosCliente.Controls.Add(this.labelInadimplente);
            this.groupBoxDadosCliente.Controls.Add(this.textBox2);
            this.groupBoxDadosCliente.Controls.Add(this.textBoxCompraFiado);
            this.groupBoxDadosCliente.Controls.Add(this.labelCompraFiado);
            this.groupBoxDadosCliente.Controls.Add(this.textBoxVencimento);
            this.groupBoxDadosCliente.Controls.Add(this.labelVencimento);
            this.groupBoxDadosCliente.Controls.Add(this.maskedTextBoxCNPJ);
            this.groupBoxDadosCliente.Controls.Add(this.maskedTextBoxTelefone);
            this.groupBoxDadosCliente.Controls.Add(this.labelTelefone);
            this.groupBoxDadosCliente.Controls.Add(this.labelCNPJ);
            this.groupBoxDadosCliente.Controls.Add(this.textBox1);
            this.groupBoxDadosCliente.Controls.Add(this.label1);
            this.groupBoxDadosCliente.Controls.Add(this.maskedTextBoxCPF);
            this.groupBoxDadosCliente.Controls.Add(this.labelID);
            this.groupBoxDadosCliente.Controls.Add(this.textBoxId);
            this.groupBoxDadosCliente.Controls.Add(this.labelCPF);
            this.groupBoxDadosCliente.ForeColor = System.Drawing.Color.White;
            this.groupBoxDadosCliente.Location = new System.Drawing.Point(12, 97);
            this.groupBoxDadosCliente.Name = "groupBoxDadosCliente";
            this.groupBoxDadosCliente.Size = new System.Drawing.Size(275, 429);
            this.groupBoxDadosCliente.TabIndex = 12;
            this.groupBoxDadosCliente.TabStop = false;
            this.groupBoxDadosCliente.Text = "Dados do cliente:";
            // 
            // labelInadimplente
            // 
            this.labelInadimplente.AutoSize = true;
            this.labelInadimplente.ForeColor = System.Drawing.Color.White;
            this.labelInadimplente.Location = new System.Drawing.Point(9, 364);
            this.labelInadimplente.Name = "labelInadimplente";
            this.labelInadimplente.Size = new System.Drawing.Size(82, 15);
            this.labelInadimplente.TabIndex = 27;
            this.labelInadimplente.Text = "Inadimplente?";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(9, 382);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(97, 23);
            this.textBox2.TabIndex = 26;
            // 
            // textBoxCompraFiado
            // 
            this.textBoxCompraFiado.Enabled = false;
            this.textBoxCompraFiado.Location = new System.Drawing.Point(9, 331);
            this.textBoxCompraFiado.Name = "textBoxCompraFiado";
            this.textBoxCompraFiado.ReadOnly = true;
            this.textBoxCompraFiado.Size = new System.Drawing.Size(97, 23);
            this.textBoxCompraFiado.TabIndex = 25;
            // 
            // labelCompraFiado
            // 
            this.labelCompraFiado.AutoSize = true;
            this.labelCompraFiado.ForeColor = System.Drawing.Color.White;
            this.labelCompraFiado.Location = new System.Drawing.Point(6, 313);
            this.labelCompraFiado.Name = "labelCompraFiado";
            this.labelCompraFiado.Size = new System.Drawing.Size(83, 15);
            this.labelCompraFiado.TabIndex = 24;
            this.labelCompraFiado.Text = "Compra fiado:";
            // 
            // textBoxVencimento
            // 
            this.textBoxVencimento.Enabled = false;
            this.textBoxVencimento.Location = new System.Drawing.Point(6, 287);
            this.textBoxVencimento.Name = "textBoxVencimento";
            this.textBoxVencimento.ReadOnly = true;
            this.textBoxVencimento.Size = new System.Drawing.Size(97, 23);
            this.textBoxVencimento.TabIndex = 23;
            // 
            // labelVencimento
            // 
            this.labelVencimento.AutoSize = true;
            this.labelVencimento.ForeColor = System.Drawing.Color.White;
            this.labelVencimento.Location = new System.Drawing.Point(6, 269);
            this.labelVencimento.Name = "labelVencimento";
            this.labelVencimento.Size = new System.Drawing.Size(73, 15);
            this.labelVencimento.TabIndex = 22;
            this.labelVencimento.Text = "Vencimento:";
            // 
            // maskedTextBoxCNPJ
            // 
            this.maskedTextBoxCNPJ.Enabled = false;
            this.maskedTextBoxCNPJ.Location = new System.Drawing.Point(6, 190);
            this.maskedTextBoxCNPJ.Mask = "00\\.000\\.000/0000-00";
            this.maskedTextBoxCNPJ.Name = "maskedTextBoxCNPJ";
            this.maskedTextBoxCNPJ.Size = new System.Drawing.Size(144, 23);
            this.maskedTextBoxCNPJ.TabIndex = 20;
            this.maskedTextBoxCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Enabled = false;
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(6, 234);
            this.maskedTextBoxTelefone.Mask = "(00) 90000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxTelefone.TabIndex = 18;
            this.maskedTextBoxTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.ForeColor = System.Drawing.Color.White;
            this.labelTelefone.Location = new System.Drawing.Point(6, 216);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 17;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.ForeColor = System.Drawing.Color.White;
            this.labelCNPJ.Location = new System.Drawing.Point(6, 172);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(37, 15);
            this.labelCNPJ.TabIndex = 21;
            this.labelCNPJ.Text = "CNPJ:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(264, 23);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome:";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Enabled = false;
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(6, 137);
            this.maskedTextBoxCPF.Mask = "000\\.000\\.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(144, 23);
            this.maskedTextBoxCPF.TabIndex = 19;
            this.maskedTextBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(6, 31);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 15);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(6, 49);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(97, 23);
            this.textBoxId.TabIndex = 0;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.ForeColor = System.Drawing.Color.White;
            this.labelCPF.Location = new System.Drawing.Point(6, 119);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 15);
            this.labelCPF.TabIndex = 14;
            this.labelCPF.Text = "CPF:";
            // 
            // textBoxCodigoCliente
            // 
            this.textBoxCodigoCliente.Location = new System.Drawing.Point(12, 47);
            this.textBoxCodigoCliente.Name = "textBoxCodigoCliente";
            this.textBoxCodigoCliente.Size = new System.Drawing.Size(177, 23);
            this.textBoxCodigoCliente.TabIndex = 11;
            // 
            // labelBuscarCliente
            // 
            this.labelBuscarCliente.AutoSize = true;
            this.labelBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.labelBuscarCliente.Location = new System.Drawing.Point(12, 25);
            this.labelBuscarCliente.Name = "labelBuscarCliente";
            this.labelBuscarCliente.Size = new System.Drawing.Size(83, 15);
            this.labelBuscarCliente.TabIndex = 10;
            this.labelBuscarCliente.Text = "Buscar cliente:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(195, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelCaixa
            // 
            this.panelCaixa.Controls.Add(this.buttonFiado);
            this.panelCaixa.Controls.Add(this.buttonAVista);
            this.panelCaixa.Controls.Add(this.checkBoxComprovante);
            this.panelCaixa.Controls.Add(this.labelTotal);
            this.panelCaixa.Controls.Add(this.textBoxTotal);
            this.panelCaixa.Controls.Add(this.labelDesconto);
            this.panelCaixa.Controls.Add(this.textBoxDesconto);
            this.panelCaixa.Controls.Add(this.labelJuros);
            this.panelCaixa.Controls.Add(this.textBoxJuros);
            this.panelCaixa.Controls.Add(this.labelMulta);
            this.panelCaixa.Controls.Add(this.textBoxMulta);
            this.panelCaixa.Controls.Add(this.labelValor);
            this.panelCaixa.Controls.Add(this.textBoxValor);
            this.panelCaixa.Location = new System.Drawing.Point(1038, 12);
            this.panelCaixa.Name = "panelCaixa";
            this.panelCaixa.Size = new System.Drawing.Size(130, 525);
            this.panelCaixa.TabIndex = 2;
            // 
            // buttonFiado
            // 
            this.buttonFiado.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonFiado.FlatAppearance.BorderSize = 0;
            this.buttonFiado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiado.Location = new System.Drawing.Point(14, 340);
            this.buttonFiado.Name = "buttonFiado";
            this.buttonFiado.Size = new System.Drawing.Size(97, 41);
            this.buttonFiado.TabIndex = 40;
            this.buttonFiado.Text = "Registra fiado";
            this.buttonFiado.UseVisualStyleBackColor = false;
            // 
            // buttonAVista
            // 
            this.buttonAVista.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonAVista.FlatAppearance.BorderSize = 0;
            this.buttonAVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAVista.Location = new System.Drawing.Point(14, 287);
            this.buttonAVista.Name = "buttonAVista";
            this.buttonAVista.Size = new System.Drawing.Size(97, 41);
            this.buttonAVista.TabIndex = 39;
            this.buttonAVista.Text = "Receber à vista";
            this.buttonAVista.UseVisualStyleBackColor = false;
            // 
            // checkBoxComprovante
            // 
            this.checkBoxComprovante.AutoSize = true;
            this.checkBoxComprovante.ForeColor = System.Drawing.Color.White;
            this.checkBoxComprovante.Location = new System.Drawing.Point(14, 251);
            this.checkBoxComprovante.Name = "checkBoxComprovante";
            this.checkBoxComprovante.Size = new System.Drawing.Size(104, 19);
            this.checkBoxComprovante.TabIndex = 38;
            this.checkBoxComprovante.Text = "Comprovante?";
            this.checkBoxComprovante.UseVisualStyleBackColor = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(14, 193);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(35, 15);
            this.labelTotal.TabIndex = 37;
            this.labelTotal.Text = "Total:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(14, 211);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(97, 23);
            this.textBoxTotal.TabIndex = 36;
            // 
            // labelDesconto
            // 
            this.labelDesconto.AutoSize = true;
            this.labelDesconto.ForeColor = System.Drawing.Color.White;
            this.labelDesconto.Location = new System.Drawing.Point(14, 146);
            this.labelDesconto.Name = "labelDesconto";
            this.labelDesconto.Size = new System.Drawing.Size(60, 15);
            this.labelDesconto.TabIndex = 35;
            this.labelDesconto.Text = "Desconto:";
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.Location = new System.Drawing.Point(14, 164);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(97, 23);
            this.textBoxDesconto.TabIndex = 34;
            // 
            // labelJuros
            // 
            this.labelJuros.AutoSize = true;
            this.labelJuros.ForeColor = System.Drawing.Color.White;
            this.labelJuros.Location = new System.Drawing.Point(14, 103);
            this.labelJuros.Name = "labelJuros";
            this.labelJuros.Size = new System.Drawing.Size(37, 15);
            this.labelJuros.TabIndex = 33;
            this.labelJuros.Text = "Juros:";
            // 
            // textBoxJuros
            // 
            this.textBoxJuros.Enabled = false;
            this.textBoxJuros.Location = new System.Drawing.Point(14, 121);
            this.textBoxJuros.Name = "textBoxJuros";
            this.textBoxJuros.ReadOnly = true;
            this.textBoxJuros.Size = new System.Drawing.Size(97, 23);
            this.textBoxJuros.TabIndex = 32;
            // 
            // labelMulta
            // 
            this.labelMulta.AutoSize = true;
            this.labelMulta.ForeColor = System.Drawing.Color.White;
            this.labelMulta.Location = new System.Drawing.Point(14, 59);
            this.labelMulta.Name = "labelMulta";
            this.labelMulta.Size = new System.Drawing.Size(41, 15);
            this.labelMulta.TabIndex = 31;
            this.labelMulta.Text = "Multa:";
            // 
            // textBoxMulta
            // 
            this.textBoxMulta.Enabled = false;
            this.textBoxMulta.Location = new System.Drawing.Point(14, 77);
            this.textBoxMulta.Name = "textBoxMulta";
            this.textBoxMulta.ReadOnly = true;
            this.textBoxMulta.Size = new System.Drawing.Size(97, 23);
            this.textBoxMulta.TabIndex = 30;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.ForeColor = System.Drawing.Color.White;
            this.labelValor.Location = new System.Drawing.Point(14, 15);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(36, 15);
            this.labelValor.TabIndex = 29;
            this.labelValor.Text = "Valor:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Enabled = false;
            this.textBoxValor.Location = new System.Drawing.Point(14, 33);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.ReadOnly = true;
            this.textBoxValor.Size = new System.Drawing.Size(97, 23);
            this.textBoxValor.TabIndex = 28;
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1179, 559);
            this.Controls.Add(this.panelCaixa);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.panelComandas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCaixa";
            this.panelComandas.ResumeLayout(false);
            this.panelComandas.PerformLayout();
            this.groupBoxComandas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensComanda)).EndInit();
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.groupBoxDadosCliente.ResumeLayout(false);
            this.groupBoxDadosCliente.PerformLayout();
            this.panelCaixa.ResumeLayout(false);
            this.panelCaixa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelComandas;
        private ComboBox comboBoxComandas;
        private Label labelSelecionarComanda;
        private Panel panelCliente;
        private Panel panelCaixa;
        private GroupBox groupBoxComandas;
        private DataGridView dataGridViewItensComanda;
        private Button buttonPesquisar;
        private GroupBox groupBoxDadosCliente;
        private Label labelTelefone;
        private TextBox textBox1;
        private Label label1;
        private Label labelCPF;
        private Label labelID;
        private TextBox textBoxId;
        private TextBox textBoxCodigoCliente;
        private Label labelBuscarCliente;
        private Button button1;
        private MaskedTextBox maskedTextBoxTelefone;
        private MaskedTextBox maskedTextBoxCPF;
        private Label labelInadimplente;
        private TextBox textBox2;
        private TextBox textBoxCompraFiado;
        private Label labelCompraFiado;
        private TextBox textBoxVencimento;
        private Label labelVencimento;
        private MaskedTextBox maskedTextBoxCNPJ;
        private Label labelCNPJ;
        private Button buttonFiado;
        private Button buttonAVista;
        private CheckBox checkBoxComprovante;
        private Label labelTotal;
        private TextBox textBoxTotal;
        private Label labelDesconto;
        private TextBox textBoxDesconto;
        private Label labelJuros;
        private TextBox textBoxJuros;
        private Label labelMulta;
        private TextBox textBoxMulta;
        private Label labelValor;
        private TextBox textBoxValor;
    }
}