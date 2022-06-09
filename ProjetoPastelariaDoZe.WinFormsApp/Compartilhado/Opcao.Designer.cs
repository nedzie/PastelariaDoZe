namespace ProjetoPastelariaDoZe.WinFormsApp.Compartilhado
{
    partial class Opcao
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
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.buttonListagem = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.BackColor = System.Drawing.Color.LightGray;
            this.buttonCadastro.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCadastro.FlatAppearance.BorderSize = 0;
            this.buttonCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastro.ForeColor = System.Drawing.Color.White;
            this.buttonCadastro.Location = new System.Drawing.Point(12, 12);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(75, 37);
            this.buttonCadastro.TabIndex = 0;
            this.buttonCadastro.Text = "Cadastrar";
            this.buttonCadastro.UseVisualStyleBackColor = false;
            // 
            // buttonListagem
            // 
            this.buttonListagem.BackColor = System.Drawing.Color.LightGray;
            this.buttonListagem.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonListagem.FlatAppearance.BorderSize = 0;
            this.buttonListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonListagem.ForeColor = System.Drawing.Color.White;
            this.buttonListagem.Location = new System.Drawing.Point(103, 12);
            this.buttonListagem.Name = "buttonListagem";
            this.buttonListagem.Size = new System.Drawing.Size(75, 37);
            this.buttonListagem.TabIndex = 1;
            this.buttonListagem.Text = "Listagem";
            this.buttonListagem.UseVisualStyleBackColor = false;
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.LightGray;
            this.buttonFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonFechar.ForeColor = System.Drawing.Color.White;
            this.buttonFechar.Location = new System.Drawing.Point(194, 12);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 37);
            this.buttonFechar.TabIndex = 2;
            this.buttonFechar.Text = "X";
            this.buttonFechar.UseVisualStyleBackColor = false;
            // 
            // Opcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonListagem);
            this.Controls.Add(this.buttonCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Opcao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opcao";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCadastro;
        private Button buttonListagem;
        private Button buttonFechar;
    }
}