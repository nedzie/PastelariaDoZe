namespace ProjetoPastelariaDoZe.WinFormsApp.Compartilhado
{
    /// <summary>
    /// Classe auxiliar Fechar
    /// </summary>
    partial class Fechar
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
            this.buttonSim = new System.Windows.Forms.Button();
            this.buttonNao = new System.Windows.Forms.Button();
            this.labelDesejaSair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSim
            // 
            this.buttonSim.BackColor = System.Drawing.Color.Black;
            this.buttonSim.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonSim.FlatAppearance.BorderSize = 0;
            this.buttonSim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSim.ForeColor = System.Drawing.Color.White;
            this.buttonSim.Location = new System.Drawing.Point(24, 47);
            this.buttonSim.Name = "buttonSim";
            this.buttonSim.Size = new System.Drawing.Size(80, 35);
            this.buttonSim.TabIndex = 0;
            this.buttonSim.Text = "Sim";
            this.buttonSim.UseVisualStyleBackColor = false;
            // 
            // buttonNao
            // 
            this.buttonNao.BackColor = System.Drawing.Color.Black;
            this.buttonNao.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNao.FlatAppearance.BorderSize = 0;
            this.buttonNao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNao.ForeColor = System.Drawing.Color.White;
            this.buttonNao.Location = new System.Drawing.Point(124, 47);
            this.buttonNao.Name = "buttonNao";
            this.buttonNao.Size = new System.Drawing.Size(80, 35);
            this.buttonNao.TabIndex = 1;
            this.buttonNao.Text = "Não";
            this.buttonNao.UseVisualStyleBackColor = false;
            // 
            // labelDesejaSair
            // 
            this.labelDesejaSair.AutoSize = true;
            this.labelDesejaSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDesejaSair.ForeColor = System.Drawing.Color.White;
            this.labelDesejaSair.Location = new System.Drawing.Point(24, 9);
            this.labelDesejaSair.Name = "labelDesejaSair";
            this.labelDesejaSair.Size = new System.Drawing.Size(71, 15);
            this.labelDesejaSair.TabIndex = 2;
            this.labelDesejaSair.Text = "Deseja sair?";
            // 
            // Fechar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(236, 102);
            this.Controls.Add(this.labelDesejaSair);
            this.Controls.Add(this.buttonNao);
            this.Controls.Add(this.buttonSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fechar";
            this.Text = "Fechar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// Botão Sim de confirmação
        /// </summary>
        public Button buttonSim;
        /// <summary>
        /// Botão Não de confirmação
        /// </summary>
        public Button buttonNao;
        private Label labelDesejaSair;
    }
}