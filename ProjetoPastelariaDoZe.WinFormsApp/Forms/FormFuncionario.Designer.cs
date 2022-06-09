namespace ProjetoPastelariaDoZe.WinFormsApp
{
    partial class FormFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            this.labelNome = new System.Windows.Forms.Label();
            this.PanelFuncionarios = new System.Windows.Forms.Panel();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.radioButtonBalcao = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.PanelFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(3, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // PanelFuncionarios
            // 
            this.PanelFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.PanelFuncionarios.Controls.Add(this.maskedTextBoxTelefone);
            this.PanelFuncionarios.Controls.Add(this.maskedTextBoxCPF);
            this.PanelFuncionarios.Controls.Add(this.textBoxSenha);
            this.PanelFuncionarios.Controls.Add(this.textBoxMatricula);
            this.PanelFuncionarios.Controls.Add(this.radioButtonBalcao);
            this.PanelFuncionarios.Controls.Add(this.radioButtonAdmin);
            this.PanelFuncionarios.Controls.Add(this.textBoxNome);
            this.PanelFuncionarios.Controls.Add(this.labelGrupo);
            this.PanelFuncionarios.Controls.Add(this.labelSenha);
            this.PanelFuncionarios.Controls.Add(this.labelTelefone);
            this.PanelFuncionarios.Controls.Add(this.labelMatricula);
            this.PanelFuncionarios.Controls.Add(this.labelCPF);
            this.PanelFuncionarios.Controls.Add(this.labelNome);
            this.PanelFuncionarios.Location = new System.Drawing.Point(12, 12);
            this.PanelFuncionarios.Name = "PanelFuncionarios";
            this.PanelFuncionarios.Size = new System.Drawing.Size(371, 334);
            this.PanelFuncionarios.TabIndex = 1;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(3, 180);
            this.maskedTextBoxTelefone.Mask = "(00) 90000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxTelefone.TabIndex = 3;
            this.maskedTextBoxTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(3, 68);
            this.maskedTextBoxCPF.Mask = "000\\.000\\.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(144, 23);
            this.maskedTextBoxCPF.TabIndex = 1;
            this.maskedTextBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(3, 224);
            this.textBoxSenha.MaxLength = 20;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '×';
            this.textBoxSenha.PlaceholderText = "********";
            this.textBoxSenha.Size = new System.Drawing.Size(196, 23);
            this.textBoxSenha.TabIndex = 4;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(3, 123);
            this.textBoxMatricula.MaxLength = 10;
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.PlaceholderText = "000000";
            this.textBoxMatricula.Size = new System.Drawing.Size(196, 23);
            this.textBoxMatricula.TabIndex = 2;
            // 
            // radioButtonBalcao
            // 
            this.radioButtonBalcao.AutoSize = true;
            this.radioButtonBalcao.ForeColor = System.Drawing.Color.White;
            this.radioButtonBalcao.Location = new System.Drawing.Point(0, 306);
            this.radioButtonBalcao.Name = "radioButtonBalcao";
            this.radioButtonBalcao.Size = new System.Drawing.Size(60, 19);
            this.radioButtonBalcao.TabIndex = 6;
            this.radioButtonBalcao.TabStop = true;
            this.radioButtonBalcao.Text = "Balcão";
            this.radioButtonBalcao.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.ForeColor = System.Drawing.Color.White;
            this.radioButtonAdmin.Location = new System.Drawing.Point(0, 281);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(61, 19);
            this.radioButtonAdmin.TabIndex = 5;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(3, 18);
            this.textBoxNome.MaxLength = 120;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.PlaceholderText = "Nome empregado";
            this.textBoxNome.Size = new System.Drawing.Size(196, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.ForeColor = System.Drawing.Color.White;
            this.labelGrupo.Location = new System.Drawing.Point(0, 263);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(43, 15);
            this.labelGrupo.TabIndex = 5;
            this.labelGrupo.Text = "Grupo:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(3, 206);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(42, 15);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.ForeColor = System.Drawing.Color.White;
            this.labelTelefone.Location = new System.Drawing.Point(3, 162);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 3;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.ForeColor = System.Drawing.Color.White;
            this.labelMatricula.Location = new System.Drawing.Point(3, 105);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(60, 15);
            this.labelMatricula.TabIndex = 2;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.ForeColor = System.Drawing.Color.White;
            this.labelCPF.Location = new System.Drawing.Point(3, 47);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 15);
            this.labelCPF.TabIndex = 1;
            this.labelCPF.Text = "CPF:";
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(395, 352);
            this.Controls.Add(this.PanelFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.PanelFuncionarios.ResumeLayout(false);
            this.PanelFuncionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelNome;
        private Panel PanelFuncionarios;
        private RadioButton radioButtonBalcao;
        private RadioButton radioButtonAdmin;
        private TextBox textBoxNome;
        private Label labelGrupo;
        private Label labelSenha;
        private Label labelTelefone;
        private Label labelMatricula;
        private Label labelCPF;
        private TextBox textBoxSenha;
        private TextBox textBoxMatricula;
        private MaskedTextBox maskedTextBoxTelefone;
        private MaskedTextBox maskedTextBoxCPF;
    }
}