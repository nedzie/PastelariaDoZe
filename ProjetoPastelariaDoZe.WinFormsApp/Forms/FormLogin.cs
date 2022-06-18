using ProjetoPastelariaDoZe.DAO.Arquivamento;
using ProjetoPastelariaDoZe.DAO.ModuloFuncionario;
using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using System.Configuration;
using System.Data;

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

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new();

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new(provider, connectionString);

            Funcionario funcionario = new Funcionario
            {
                Numero = 0,
                CPF = textBoxNome.Text,
                Senha = Funcoes.Sha256Hash(textBoxSenha.Text)
            };

            try
            {
                DataTable linhas = dao.ValidaLogin(funcionario);

                foreach (DataRow row in linhas!.Rows)
                {
                    Program.estaLogado = true;
                    Program.idLogado = Convert.ToInt32(row[0]);
                    Program.nomeLogado = row[1].ToString()!;
                    Program.grupoLogado = Convert.ToInt32(row[5].ToString());

                    ClassLog.SalvaLog("INFO", Program.idLogado, $"Login realizado por {textBoxNome.Text}");

                    this.Close();
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClassLog.SalvaLog("ERRO", Program.idLogado, $"Login {ex.Message}");
            }
        }
    }
}