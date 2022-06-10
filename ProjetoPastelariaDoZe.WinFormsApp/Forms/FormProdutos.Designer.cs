namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe Produtos, onde são definidas as informações dos produtos
    /// </summary>
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricaoProduto = new System.Windows.Forms.TextBox();
            this.labelValorUnitario = new System.Windows.Forms.Label();
            this.textBoxValorUnitario = new System.Windows.Forms.TextBox();
            this.labelFoto = new System.Windows.Forms.Label();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.openFileDialogImagem = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.panelProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(3, 44);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Location = new System.Drawing.Point(3, 62);
            this.textBoxNome.MaxLength = 120;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.PlaceholderText = "Nome produto:";
            this.textBoxNome.Size = new System.Drawing.Size(235, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.ForeColor = System.Drawing.Color.White;
            this.labelDescricao.Location = new System.Drawing.Point(3, 96);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(61, 15);
            this.labelDescricao.TabIndex = 2;
            this.labelDescricao.Text = "Descriçao:";
            // 
            // textBoxDescricaoProduto
            // 
            this.textBoxDescricaoProduto.Location = new System.Drawing.Point(3, 114);
            this.textBoxDescricaoProduto.Name = "textBoxDescricaoProduto";
            this.textBoxDescricaoProduto.PlaceholderText = "Descrição do produto";
            this.textBoxDescricaoProduto.Size = new System.Drawing.Size(298, 23);
            this.textBoxDescricaoProduto.TabIndex = 1;
            // 
            // labelValorUnitario
            // 
            this.labelValorUnitario.AutoSize = true;
            this.labelValorUnitario.ForeColor = System.Drawing.Color.White;
            this.labelValorUnitario.Location = new System.Drawing.Point(-1, 154);
            this.labelValorUnitario.Name = "labelValorUnitario";
            this.labelValorUnitario.Size = new System.Drawing.Size(104, 15);
            this.labelValorUnitario.TabIndex = 4;
            this.labelValorUnitario.Text = "Valor unitário (R$):";
            // 
            // textBoxValorUnitario
            // 
            this.textBoxValorUnitario.Location = new System.Drawing.Point(3, 172);
            this.textBoxValorUnitario.MaxLength = 6;
            this.textBoxValorUnitario.Name = "textBoxValorUnitario";
            this.textBoxValorUnitario.PlaceholderText = "R$";
            this.textBoxValorUnitario.Size = new System.Drawing.Size(100, 23);
            this.textBoxValorUnitario.TabIndex = 2;
            // 
            // labelFoto
            // 
            this.labelFoto.AutoSize = true;
            this.labelFoto.ForeColor = System.Drawing.Color.White;
            this.labelFoto.Location = new System.Drawing.Point(338, 12);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(34, 15);
            this.labelFoto.TabIndex = 6;
            this.labelFoto.Text = "Foto:";
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImagem.ErrorImage = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.null1;
            this.pictureBoxImagem.InitialImage = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.addNew;
            this.pictureBoxImagem.Location = new System.Drawing.Point(342, 30);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(138, 107);
            this.pictureBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagem.TabIndex = 8;
            this.pictureBoxImagem.TabStop = false;
            this.pictureBoxImagem.Click += new System.EventHandler(this.pictureBoxImagem_Click);
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.Color.Transparent;
            this.panelProdutos.Controls.Add(this.textBoxID);
            this.panelProdutos.Controls.Add(this.labelID);
            this.panelProdutos.Controls.Add(this.pictureBoxImagem);
            this.panelProdutos.Controls.Add(this.labelFoto);
            this.panelProdutos.Controls.Add(this.textBoxDescricaoProduto);
            this.panelProdutos.Controls.Add(this.textBoxValorUnitario);
            this.panelProdutos.Controls.Add(this.labelDescricao);
            this.panelProdutos.Controls.Add(this.labelValorUnitario);
            this.panelProdutos.Controls.Add(this.textBoxNome);
            this.panelProdutos.Controls.Add(this.labelNome);
            this.panelProdutos.Location = new System.Drawing.Point(12, 12);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(490, 230);
            this.panelProdutos.TabIndex = 11;
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(3, 18);
            this.textBoxID.MaxLength = 120;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(85, 23);
            this.textBoxID.TabIndex = 10;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(3, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 15);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "ID";
            // 
            // openFileDialogImagem
            // 
            this.openFileDialogImagem.FileName = "openFileDialog1";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(512, 248);
            this.Controls.Add(this.panelProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelDescricao;
        private TextBox textBoxDescricaoProduto;
        private Label labelValorUnitario;
        private TextBox textBoxValorUnitario;
        private Label labelFoto;
        private PictureBox pictureBoxImagem;
        private Panel panelProdutos;
        private OpenFileDialog openFileDialogImagem;
        private TextBox textBoxID;
        private Label labelID;
    }
}