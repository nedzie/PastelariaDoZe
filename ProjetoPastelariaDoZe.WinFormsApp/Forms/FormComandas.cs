using ProjetoPastelariaDoZe.DAO.Compartilhado;
using ProjetoPastelariaDoZe.DAO.ModuloComanda;
using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using System.Configuration;
using System.Data;

namespace ProjetoPastelariaDoZe.WinFormsApp
{   /// <summary>
    /// Classe comandas
    /// </summary>
    public partial class FormComandas : Form
    {
        ComandaDAO? dao;
        /// <summary>
        /// Construtor da classe Comandas
        /// </summary>
        public FormComandas()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formComandas.Text");
            ConfigurarUserControl();
            AtualizarTelAreaComandas();
        }

        private void ConfigurarUserControl()
        {
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
            opcoes.buttonSair.Click += ButtonSair_Click;

            ConfigurarDAO();
        }

        private void ConfigurarDAO()
        {
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new(provider, connectionString);
        }

        private void ButtonSair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAbrirComanda_Click(object sender, EventArgs e)
        {
            var comanda = new Comanda
            {
                NumeroComanda = textBoxNumeroComanda.Text,
                DataHora = DateTime.Now,
                StatusComanda = 0
            };

            try
            {
                if (!dao!.AbreNovaComanda(comanda))
                {
                    MessageBox.Show("ERRO!!! Comanda " + textBoxNumeroComanda.Text + " já esta aberta!!!");
                }
                else
                {
                    MessageBox.Show("Comanda aberta com sucesso!");
                    AtualizarTelAreaComandas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelAreaComandas()
        {
            var comanda = new Comanda
            {
                StatusComanda = 0
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao!.ListarComandas(comanda);
                // seta o data souce com os dados retornados
                dataGridViewComandasAbertas.AutoGenerateColumns = true;
                dataGridViewComandasAbertas.DataSource = linhas;
                dataGridViewComandasAbertas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}