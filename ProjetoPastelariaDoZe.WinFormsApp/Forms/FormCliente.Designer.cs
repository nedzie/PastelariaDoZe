namespace ProjetoPastelariaDoZe.WinFormsApp
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.panelClientes = new System.Windows.Forms.Panel();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxTipoCliente = new System.Windows.Forms.GroupBox();
            this.labelOpcaoCliente = new System.Windows.Forms.Label();
            this.radioButtonFisica = new System.Windows.Forms.RadioButton();
            this.radioButtonJuridica = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.labelDiaDoFiado = new System.Windows.Forms.Label();
            this.numericUpDownDiaDoFiado = new System.Windows.Forms.NumericUpDown();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.groupBoxMarcaFiado = new System.Windows.Forms.GroupBox();
            this.labelMarcaFiado = new System.Windows.Forms.Label();
            this.radioButtonFiadoSim = new System.Windows.Forms.RadioButton();
            this.radioButtonFiadoNao = new System.Windows.Forms.RadioButton();
            this.panelClientes.SuspendLayout();
            this.groupBoxTipoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiaDoFiado)).BeginInit();
            this.groupBoxMarcaFiado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClientes
            // 
            this.panelClientes.Controls.Add(this.maskedTextBoxTelefone);
            this.panelClientes.Controls.Add(this.groupBoxTipoCliente);
            this.panelClientes.Controls.Add(this.maskedTextBoxCPF);
            this.panelClientes.Controls.Add(this.maskedTextBoxCNPJ);
            this.panelClientes.Controls.Add(this.labelCNPJ);
            this.panelClientes.Controls.Add(this.labelDiaDoFiado);
            this.panelClientes.Controls.Add(this.numericUpDownDiaDoFiado);
            this.panelClientes.Controls.Add(this.textBoxSenha);
            this.panelClientes.Controls.Add(this.textBoxNome);
            this.panelClientes.Controls.Add(this.labelSenha);
            this.panelClientes.Controls.Add(this.labelTelefone);
            this.panelClientes.Controls.Add(this.labelCPF);
            this.panelClientes.Controls.Add(this.labelNome);
            this.panelClientes.Controls.Add(this.groupBoxMarcaFiado);
            this.panelClientes.Location = new System.Drawing.Point(12, 12);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(443, 374);
            this.panelClientes.TabIndex = 0;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Enabled = false;
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(6, 346);
            this.maskedTextBoxTelefone.Mask = "(00) 90000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxTelefone.TabIndex = 6;
            this.maskedTextBoxTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // groupBoxTipoCliente
            // 
            this.groupBoxTipoCliente.Controls.Add(this.labelOpcaoCliente);
            this.groupBoxTipoCliente.Controls.Add(this.radioButtonFisica);
            this.groupBoxTipoCliente.Controls.Add(this.radioButtonJuridica);
            this.groupBoxTipoCliente.Location = new System.Drawing.Point(0, 194);
            this.groupBoxTipoCliente.Name = "groupBoxTipoCliente";
            this.groupBoxTipoCliente.Size = new System.Drawing.Size(200, 113);
            this.groupBoxTipoCliente.TabIndex = 3;
            this.groupBoxTipoCliente.TabStop = false;
            this.groupBoxTipoCliente.Text = "*";
            // 
            // labelOpcaoCliente
            // 
            this.labelOpcaoCliente.AutoSize = true;
            this.labelOpcaoCliente.ForeColor = System.Drawing.Color.White;
            this.labelOpcaoCliente.Location = new System.Drawing.Point(6, 19);
            this.labelOpcaoCliente.Name = "labelOpcaoCliente";
            this.labelOpcaoCliente.Size = new System.Drawing.Size(137, 15);
            this.labelOpcaoCliente.TabIndex = 13;
            this.labelOpcaoCliente.Text = "Pessoa física ou jurídica?";
            // 
            // radioButtonFisica
            // 
            this.radioButtonFisica.AutoSize = true;
            this.radioButtonFisica.Enabled = false;
            this.radioButtonFisica.ForeColor = System.Drawing.Color.White;
            this.radioButtonFisica.Location = new System.Drawing.Point(6, 43);
            this.radioButtonFisica.Name = "radioButtonFisica";
            this.radioButtonFisica.Size = new System.Drawing.Size(54, 19);
            this.radioButtonFisica.TabIndex = 1;
            this.radioButtonFisica.TabStop = true;
            this.radioButtonFisica.Text = "Física";
            this.radioButtonFisica.UseVisualStyleBackColor = true;
            this.radioButtonFisica.CheckedChanged += new System.EventHandler(this.radioButtonFisica_CheckedChanged);
            // 
            // radioButtonJuridica
            // 
            this.radioButtonJuridica.AutoSize = true;
            this.radioButtonJuridica.Enabled = false;
            this.radioButtonJuridica.ForeColor = System.Drawing.Color.White;
            this.radioButtonJuridica.Location = new System.Drawing.Point(6, 68);
            this.radioButtonJuridica.Name = "radioButtonJuridica";
            this.radioButtonJuridica.Size = new System.Drawing.Size(65, 19);
            this.radioButtonJuridica.TabIndex = 2;
            this.radioButtonJuridica.TabStop = true;
            this.radioButtonJuridica.Text = "Jurídica";
            this.radioButtonJuridica.UseVisualStyleBackColor = true;
            this.radioButtonJuridica.CheckedChanged += new System.EventHandler(this.radioButtonJuridica_CheckedChanged);
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Enabled = false;
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(223, 231);
            this.maskedTextBoxCPF.Mask = "000\\.000\\.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(144, 23);
            this.maskedTextBoxCPF.TabIndex = 4;
            this.maskedTextBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxCNPJ
            // 
            this.maskedTextBoxCNPJ.Enabled = false;
            this.maskedTextBoxCNPJ.Location = new System.Drawing.Point(223, 275);
            this.maskedTextBoxCNPJ.Mask = "00\\.000\\.000/0000-00";
            this.maskedTextBoxCNPJ.Name = "maskedTextBoxCNPJ";
            this.maskedTextBoxCNPJ.Size = new System.Drawing.Size(144, 23);
            this.maskedTextBoxCNPJ.TabIndex = 5;
            this.maskedTextBoxCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.ForeColor = System.Drawing.Color.White;
            this.labelCNPJ.Location = new System.Drawing.Point(223, 257);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(37, 15);
            this.labelCNPJ.TabIndex = 17;
            this.labelCNPJ.Text = "CNPJ:";
            // 
            // labelDiaDoFiado
            // 
            this.labelDiaDoFiado.AutoSize = true;
            this.labelDiaDoFiado.ForeColor = System.Drawing.Color.White;
            this.labelDiaDoFiado.Location = new System.Drawing.Point(227, 34);
            this.labelDiaDoFiado.Name = "labelDiaDoFiado";
            this.labelDiaDoFiado.Size = new System.Drawing.Size(166, 15);
            this.labelDiaDoFiado.TabIndex = 12;
            this.labelDiaDoFiado.Text = "Dia do fiado (0 - dias corridos)";
            // 
            // numericUpDownDiaDoFiado
            // 
            this.numericUpDownDiaDoFiado.Enabled = false;
            this.numericUpDownDiaDoFiado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownDiaDoFiado.Location = new System.Drawing.Point(227, 56);
            this.numericUpDownDiaDoFiado.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDiaDoFiado.Name = "numericUpDownDiaDoFiado";
            this.numericUpDownDiaDoFiado.ReadOnly = true;
            this.numericUpDownDiaDoFiado.Size = new System.Drawing.Size(62, 33);
            this.numericUpDownDiaDoFiado.TabIndex = 1;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Enabled = false;
            this.textBoxSenha.Location = new System.Drawing.Point(120, 346);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.PlaceholderText = "********";
            this.textBoxSenha.Size = new System.Drawing.Size(257, 23);
            this.textBoxSenha.TabIndex = 7;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Enabled = false;
            this.textBoxNome.Location = new System.Drawing.Point(9, 156);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.PlaceholderText = "Nome do cliente";
            this.textBoxNome.Size = new System.Drawing.Size(358, 23);
            this.textBoxNome.TabIndex = 2;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(120, 328);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(42, 15);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "Senha:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.ForeColor = System.Drawing.Color.White;
            this.labelTelefone.Location = new System.Drawing.Point(6, 328);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.ForeColor = System.Drawing.Color.White;
            this.labelCPF.Location = new System.Drawing.Point(223, 213);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 15);
            this.labelCPF.TabIndex = 1;
            this.labelCPF.Text = "CPF:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(9, 129);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // groupBoxMarcaFiado
            // 
            this.groupBoxMarcaFiado.Controls.Add(this.labelMarcaFiado);
            this.groupBoxMarcaFiado.Controls.Add(this.radioButtonFiadoSim);
            this.groupBoxMarcaFiado.Controls.Add(this.radioButtonFiadoNao);
            this.groupBoxMarcaFiado.ForeColor = System.Drawing.Color.White;
            this.groupBoxMarcaFiado.Location = new System.Drawing.Point(3, 15);
            this.groupBoxMarcaFiado.Name = "groupBoxMarcaFiado";
            this.groupBoxMarcaFiado.Size = new System.Drawing.Size(200, 100);
            this.groupBoxMarcaFiado.TabIndex = 0;
            this.groupBoxMarcaFiado.TabStop = false;
            this.groupBoxMarcaFiado.Text = "*";
            // 
            // labelMarcaFiado
            // 
            this.labelMarcaFiado.AutoSize = true;
            this.labelMarcaFiado.ForeColor = System.Drawing.Color.White;
            this.labelMarcaFiado.Location = new System.Drawing.Point(6, 19);
            this.labelMarcaFiado.Name = "labelMarcaFiado";
            this.labelMarcaFiado.Size = new System.Drawing.Size(75, 15);
            this.labelMarcaFiado.TabIndex = 8;
            this.labelMarcaFiado.Text = "Marca fiado?";
            // 
            // radioButtonFiadoSim
            // 
            this.radioButtonFiadoSim.AutoSize = true;
            this.radioButtonFiadoSim.ForeColor = System.Drawing.Color.White;
            this.radioButtonFiadoSim.Location = new System.Drawing.Point(6, 41);
            this.radioButtonFiadoSim.Name = "radioButtonFiadoSim";
            this.radioButtonFiadoSim.Size = new System.Drawing.Size(45, 19);
            this.radioButtonFiadoSim.TabIndex = 5;
            this.radioButtonFiadoSim.TabStop = true;
            this.radioButtonFiadoSim.Text = "Sim";
            this.radioButtonFiadoSim.UseVisualStyleBackColor = true;
            this.radioButtonFiadoSim.CheckedChanged += new System.EventHandler(this.radioButtonFiadoSim_CheckedChanged);
            // 
            // radioButtonFiadoNao
            // 
            this.radioButtonFiadoNao.AutoSize = true;
            this.radioButtonFiadoNao.ForeColor = System.Drawing.Color.White;
            this.radioButtonFiadoNao.Location = new System.Drawing.Point(6, 66);
            this.radioButtonFiadoNao.Name = "radioButtonFiadoNao";
            this.radioButtonFiadoNao.Size = new System.Drawing.Size(47, 19);
            this.radioButtonFiadoNao.TabIndex = 6;
            this.radioButtonFiadoNao.TabStop = true;
            this.radioButtonFiadoNao.Text = "Não";
            this.radioButtonFiadoNao.UseVisualStyleBackColor = true;
            this.radioButtonFiadoNao.CheckedChanged += new System.EventHandler(this.radioButtonFiadoNao_CheckedChanged);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(465, 391);
            this.Controls.Add(this.panelClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            this.groupBoxTipoCliente.ResumeLayout(false);
            this.groupBoxTipoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiaDoFiado)).EndInit();
            this.groupBoxMarcaFiado.ResumeLayout(false);
            this.groupBoxMarcaFiado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelClientes;
        private TextBox textBoxNome;
        private Label labelSenha;
        private Label labelTelefone;
        private Label labelCPF;
        private Label labelNome;
        private TextBox textBoxSenha;
        private Label labelMarcaFiado;
        private RadioButton radioButtonFiadoNao;
        private RadioButton radioButtonFiadoSim;
        private Label labelDiaDoFiado;
        private NumericUpDown numericUpDownDiaDoFiado;
        private Label labelCNPJ;
        private RadioButton radioButtonJuridica;
        private RadioButton radioButtonFisica;
        private Label labelOpcaoCliente;
        private MaskedTextBox maskedTextBoxCPF;
        private MaskedTextBox maskedTextBoxCNPJ;
        private MaskedTextBox maskedTextBoxTelefone;
        private GroupBox groupBoxMarcaFiado;
        private GroupBox groupBoxTipoCliente;
    }
}