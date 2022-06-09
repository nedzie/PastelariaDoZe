namespace ProjetoPastelariaDoZe.WinFormsApp
{   /// <summary>
    /// Classe Sobre, onde contém todas as informações do programa
    /// </summary>
    partial class FormSobre
    {
        /// <summary>
        /// Formulário "Sobre", que contém as informações do programa
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
            this.labelTextoTemporario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTextoTemporario
            // 
            this.labelTextoTemporario.AutoSize = true;
            this.labelTextoTemporario.ForeColor = System.Drawing.Color.White;
            this.labelTextoTemporario.Location = new System.Drawing.Point(324, 207);
            this.labelTextoTemporario.Name = "labelTextoTemporario";
            this.labelTextoTemporario.Size = new System.Drawing.Size(127, 15);
            this.labelTextoTemporario.TabIndex = 0;
            this.labelTextoTemporario.Text = "Em desenvolvimento...";
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTextoTemporario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTextoTemporario;
    }
}