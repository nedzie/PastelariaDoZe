namespace ProjetoPastelariaDoZe.WinFormsApp
{
    partial class FormComandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComandas));
            this.PanelComandas = new System.Windows.Forms.Panel();
            this.panelItensComanda = new System.Windows.Forms.Panel();
            this.groupBoxItensComanda = new System.Windows.Forms.GroupBox();
            this.dataGridViewItensComanda = new System.Windows.Forms.DataGridView();
            this.panelComandasAbertas = new System.Windows.Forms.Panel();
            this.groupBoxComandasAbertas = new System.Windows.Forms.GroupBox();
            this.dataGridViewComandasAbertas = new System.Windows.Forms.DataGridView();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.groupBoxProdutos = new System.Windows.Forms.GroupBox();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.panelAbrirComanda = new System.Windows.Forms.Panel();
            this.buttonAbrirComanda = new System.Windows.Forms.Button();
            this.textBoxNumeroComanda = new System.Windows.Forms.TextBox();
            this.labelNumeroComanda = new System.Windows.Forms.Label();
            this.PanelComandas.SuspendLayout();
            this.panelItensComanda.SuspendLayout();
            this.groupBoxItensComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensComanda)).BeginInit();
            this.panelComandasAbertas.SuspendLayout();
            this.groupBoxComandasAbertas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasAbertas)).BeginInit();
            this.panelProdutos.SuspendLayout();
            this.groupBoxProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.panelAbrirComanda.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelComandas
            // 
            this.PanelComandas.Controls.Add(this.panelItensComanda);
            this.PanelComandas.Controls.Add(this.panelComandasAbertas);
            this.PanelComandas.Controls.Add(this.panelProdutos);
            this.PanelComandas.Controls.Add(this.panelAbrirComanda);
            this.PanelComandas.Location = new System.Drawing.Point(12, 12);
            this.PanelComandas.Name = "PanelComandas";
            this.PanelComandas.Size = new System.Drawing.Size(1491, 698);
            this.PanelComandas.TabIndex = 1;
            // 
            // panelItensComanda
            // 
            this.panelItensComanda.Controls.Add(this.groupBoxItensComanda);
            this.panelItensComanda.Location = new System.Drawing.Point(3, 389);
            this.panelItensComanda.Name = "panelItensComanda";
            this.panelItensComanda.Size = new System.Drawing.Size(754, 296);
            this.panelItensComanda.TabIndex = 5;
            // 
            // groupBoxItensComanda
            // 
            this.groupBoxItensComanda.Controls.Add(this.dataGridViewItensComanda);
            this.groupBoxItensComanda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxItensComanda.ForeColor = System.Drawing.Color.White;
            this.groupBoxItensComanda.Location = new System.Drawing.Point(0, 0);
            this.groupBoxItensComanda.Name = "groupBoxItensComanda";
            this.groupBoxItensComanda.Size = new System.Drawing.Size(754, 296);
            this.groupBoxItensComanda.TabIndex = 2;
            this.groupBoxItensComanda.TabStop = false;
            this.groupBoxItensComanda.Text = "Itens da comanda (Duplo clique para editar)";
            // 
            // dataGridViewItensComanda
            // 
            this.dataGridViewItensComanda.AllowUserToAddRows = false;
            this.dataGridViewItensComanda.AllowUserToDeleteRows = false;
            this.dataGridViewItensComanda.AllowUserToResizeRows = false;
            this.dataGridViewItensComanda.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewItensComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItensComanda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewItensComanda.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewItensComanda.MultiSelect = false;
            this.dataGridViewItensComanda.Name = "dataGridViewItensComanda";
            this.dataGridViewItensComanda.RowTemplate.Height = 25;
            this.dataGridViewItensComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItensComanda.Size = new System.Drawing.Size(742, 268);
            this.dataGridViewItensComanda.TabIndex = 1;
            // 
            // panelComandasAbertas
            // 
            this.panelComandasAbertas.Controls.Add(this.groupBoxComandasAbertas);
            this.panelComandasAbertas.Location = new System.Drawing.Point(3, 87);
            this.panelComandasAbertas.Name = "panelComandasAbertas";
            this.panelComandasAbertas.Size = new System.Drawing.Size(754, 296);
            this.panelComandasAbertas.TabIndex = 4;
            // 
            // groupBoxComandasAbertas
            // 
            this.groupBoxComandasAbertas.Controls.Add(this.dataGridViewComandasAbertas);
            this.groupBoxComandasAbertas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxComandasAbertas.ForeColor = System.Drawing.Color.White;
            this.groupBoxComandasAbertas.Location = new System.Drawing.Point(0, 0);
            this.groupBoxComandasAbertas.Name = "groupBoxComandasAbertas";
            this.groupBoxComandasAbertas.Size = new System.Drawing.Size(754, 296);
            this.groupBoxComandasAbertas.TabIndex = 3;
            this.groupBoxComandasAbertas.TabStop = false;
            this.groupBoxComandasAbertas.Text = "Comandas abertas";
            // 
            // dataGridViewComandasAbertas
            // 
            this.dataGridViewComandasAbertas.AllowUserToAddRows = false;
            this.dataGridViewComandasAbertas.AllowUserToDeleteRows = false;
            this.dataGridViewComandasAbertas.AllowUserToResizeRows = false;
            this.dataGridViewComandasAbertas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewComandasAbertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandasAbertas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandasAbertas.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewComandasAbertas.MultiSelect = false;
            this.dataGridViewComandasAbertas.Name = "dataGridViewComandasAbertas";
            this.dataGridViewComandasAbertas.RowTemplate.Height = 25;
            this.dataGridViewComandasAbertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandasAbertas.Size = new System.Drawing.Size(745, 251);
            this.dataGridViewComandasAbertas.TabIndex = 0;
            // 
            // panelProdutos
            // 
            this.panelProdutos.Controls.Add(this.buttonPesquisar);
            this.panelProdutos.Controls.Add(this.textBoxProduto);
            this.panelProdutos.Controls.Add(this.groupBoxProdutos);
            this.panelProdutos.Location = new System.Drawing.Point(763, 3);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(725, 682);
            this.panelProdutos.TabIndex = 3;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.White;
            this.buttonPesquisar.FlatAppearance.BorderSize = 0;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPesquisar.Location = new System.Drawing.Point(257, 32);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(92, 33);
            this.buttonPesquisar.TabIndex = 7;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProduto.Location = new System.Drawing.Point(26, 32);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(225, 33);
            this.textBoxProduto.TabIndex = 6;
            // 
            // groupBoxProdutos
            // 
            this.groupBoxProdutos.Controls.Add(this.dataGridViewProdutos);
            this.groupBoxProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProdutos.ForeColor = System.Drawing.Color.White;
            this.groupBoxProdutos.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProdutos.Name = "groupBoxProdutos";
            this.groupBoxProdutos.Size = new System.Drawing.Size(725, 682);
            this.groupBoxProdutos.TabIndex = 8;
            this.groupBoxProdutos.TabStop = false;
            this.groupBoxProdutos.Text = "Produtos (Duplo clique para adicionar à comanda)";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.AllowUserToResizeRows = false;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(6, 106);
            this.dataGridViewProdutos.MultiSelect = false;
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(716, 570);
            this.dataGridViewProdutos.TabIndex = 2;
            // 
            // panelAbrirComanda
            // 
            this.panelAbrirComanda.Controls.Add(this.buttonAbrirComanda);
            this.panelAbrirComanda.Controls.Add(this.textBoxNumeroComanda);
            this.panelAbrirComanda.Controls.Add(this.labelNumeroComanda);
            this.panelAbrirComanda.Location = new System.Drawing.Point(3, 3);
            this.panelAbrirComanda.Name = "panelAbrirComanda";
            this.panelAbrirComanda.Size = new System.Drawing.Size(754, 78);
            this.panelAbrirComanda.TabIndex = 0;
            // 
            // buttonAbrirComanda
            // 
            this.buttonAbrirComanda.BackColor = System.Drawing.Color.White;
            this.buttonAbrirComanda.FlatAppearance.BorderSize = 0;
            this.buttonAbrirComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrirComanda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAbrirComanda.Location = new System.Drawing.Point(365, 36);
            this.buttonAbrirComanda.Name = "buttonAbrirComanda";
            this.buttonAbrirComanda.Size = new System.Drawing.Size(122, 29);
            this.buttonAbrirComanda.TabIndex = 2;
            this.buttonAbrirComanda.Text = "Abrir comanda";
            this.buttonAbrirComanda.UseVisualStyleBackColor = false;
            this.buttonAbrirComanda.Click += new System.EventHandler(this.buttonAbrirComanda_Click);
            // 
            // textBoxNumeroComanda
            // 
            this.textBoxNumeroComanda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumeroComanda.Location = new System.Drawing.Point(202, 36);
            this.textBoxNumeroComanda.MaxLength = 6;
            this.textBoxNumeroComanda.Name = "textBoxNumeroComanda";
            this.textBoxNumeroComanda.Size = new System.Drawing.Size(147, 29);
            this.textBoxNumeroComanda.TabIndex = 1;
            // 
            // labelNumeroComanda
            // 
            this.labelNumeroComanda.AutoSize = true;
            this.labelNumeroComanda.ForeColor = System.Drawing.Color.White;
            this.labelNumeroComanda.Location = new System.Drawing.Point(202, 18);
            this.labelNumeroComanda.Name = "labelNumeroComanda";
            this.labelNumeroComanda.Size = new System.Drawing.Size(54, 15);
            this.labelNumeroComanda.TabIndex = 0;
            this.labelNumeroComanda.Text = "Número:";
            // 
            // FormComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1515, 723);
            this.Controls.Add(this.PanelComandas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FormComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comandas";
            this.PanelComandas.ResumeLayout(false);
            this.panelItensComanda.ResumeLayout(false);
            this.groupBoxItensComanda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensComanda)).EndInit();
            this.panelComandasAbertas.ResumeLayout(false);
            this.groupBoxComandasAbertas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasAbertas)).EndInit();
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.groupBoxProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.panelAbrirComanda.ResumeLayout(false);
            this.panelAbrirComanda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel PanelComandas;
        private Panel panelAbrirComanda;
        private Button buttonAbrirComanda;
        private TextBox textBoxNumeroComanda;
        private Label labelNumeroComanda;
        private Panel panelItensComanda;
        private Panel panelComandasAbertas;
        private Panel panelProdutos;
        private DataGridView dataGridViewItensComanda;
        private DataGridView dataGridViewComandasAbertas;
        private DataGridView dataGridViewProdutos;
        private Button buttonPesquisar;
        private TextBox textBoxProduto;
        private GroupBox groupBoxComandasAbertas;
        private GroupBox groupBoxItensComanda;
        private GroupBox groupBoxProdutos;
    }
}