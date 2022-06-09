using FluentValidation.Results;
using ProjetoPastelariaDoZe.DAO;
using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using ProjetoPastelariaDoZe.WinFormsApp.Validadores.ModuloFuncionario;
using System.Configuration;
using System.Data;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe responsável pelo form Funcionários
    /// </summary>
    public partial class FormFuncionario : Form
    {
        /// <summary>
        /// Instância DAO dentro da classe FormFuncionario
        /// </summary>
        public readonly FuncionarioDAO dao;
        /// <summary>
        /// Construtor da classe Funcionários
        /// </summary>
        public FormFuncionario()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formFuncionarios.Text");
            UserControlControleUsuarioGeral opcoes = new()
            {
                Dock = DockStyle.Bottom
            };
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
            opcoes.buttonSair.Click += ButtonSair_Click;
            opcoes.buttonSalvar.Click += ButtonSalvar_Click;

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new(provider, connectionString);
        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            Funcionario funcionario = new();

            ConfigurarAtributos(funcionario);

            ValidadorFuncionario vf = new();

            ValidationResult vr = vf.Validate(funcionario);

            RemoverMascaras(funcionario);

            if (!vr.IsValid)
                MessageBox.Show(vr.ToString());
            else
            {
                try
                {
                    dao.InserirDBProvider(funcionario);

                    MessageBox.Show("Deu boa");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonSair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarAtributos(Funcionario funcionario)
        {
            funcionario.Nome = textBoxNome.Text;
            funcionario.Matricula = textBoxMatricula.Text;
            funcionario.CPF = maskedTextBoxCPF.Text;
            funcionario.Telefone = maskedTextBoxTelefone.Text;
            funcionario.Senha = Funcoes.Sha256Hash(textBoxSenha.Text);
            funcionario.Grupo = (radioButtonAdmin.Checked) ? 1 : 2; // Se .Checked == true, Grupo=1, senão, Grupo=2;
        }

        private void RemoverMascaras(Funcionario funcionario)
        {
            AjustarCPF(funcionario);
            AjustarTelefone(funcionario);
        }
        private static void AjustarTelefone(Funcionario funcionario)
        {
            funcionario.Telefone = funcionario.Telefone!.Replace('-', ' ');
            funcionario.Telefone = funcionario.Telefone.Replace('(', ' ');
            funcionario.Telefone = funcionario.Telefone.Replace(')', ' ');
            funcionario.Telefone = funcionario.Telefone.Replace(" ", "");
        }

        private static void AjustarCPF(Funcionario funcionario)
        {
            funcionario.CPF = funcionario.CPF!.Replace(".", "");
            funcionario.CPF = funcionario.CPF.Replace("-", "");
        }
    }
}