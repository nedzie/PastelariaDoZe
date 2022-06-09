namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe auxiliar UserControlControleUsuarioGeral - Criada para evitar repetição de códigos. 
    /// Pode ser utilizada em diversas partes do cógido. 
    /// Modular.
    /// </summary>
    partial class UserControlControleUsuarioGeral
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSalvar.FlatAppearance.BorderSize = 0;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.salvar_solido_branco;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(0, 0);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 49);
            this.buttonSalvar.TabIndex = 20;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.editar_solido_branco;
            this.buttonEditar.Location = new System.Drawing.Point(100, 0);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 49);
            this.buttonEditar.TabIndex = 21;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluir.FlatAppearance.BorderSize = 0;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.apagar_solido_branco;
            this.buttonExcluir.Location = new System.Drawing.Point(200, 0);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 49);
            this.buttonExcluir.TabIndex = 22;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.fechar_solido_branco;
            this.buttonSair.Location = new System.Drawing.Point(300, 0);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(100, 49);
            this.buttonSair.TabIndex = 23;
            this.buttonSair.Text = "Sair";
            this.buttonSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSair.UseVisualStyleBackColor = false;
            // 
            // UserControlControleUsuarioGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "UserControlControleUsuarioGeral";
            this.Size = new System.Drawing.Size(400, 49);
            this.ResumeLayout(false);

        }

        #endregion
        /// <summary>
        /// Botão para salvar ações
        /// </summary>
        public Button buttonSalvar;
        /// <summary>
        /// Botão para editar campos selecionados
        /// </summary>
        public Button buttonEditar;
        /// <summary>
        /// Botão para excluir campos selecionados
        /// </summary>
        public Button buttonExcluir;
        /// <summary>
        /// Botão para fechar ambientes
        /// </summary>
        public Button buttonSair;
    }
}
