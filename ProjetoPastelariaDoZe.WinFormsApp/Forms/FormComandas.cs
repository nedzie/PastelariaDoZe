using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;

namespace ProjetoPastelariaDoZe.WinFormsApp
{   /// <summary>
    /// Classe comandas
    /// </summary>
    public partial class FormComandas : Form
    {
        /// <summary>
        /// Construtor da classe Comandas
        /// </summary>
        public FormComandas()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formComandas.Text");
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
            opcoes.buttonSair.Click += ButtonSair_Click; // Invoke
        }

        private void ButtonSair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}