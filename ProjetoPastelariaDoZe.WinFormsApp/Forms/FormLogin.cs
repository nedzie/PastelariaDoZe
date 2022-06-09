using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    public partial class FormLogin : Form
    {
        /// <summary>
        /// Construtor da classe Login
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formLogin.Text");
            MaximizeBox = false;
        }
    }
}