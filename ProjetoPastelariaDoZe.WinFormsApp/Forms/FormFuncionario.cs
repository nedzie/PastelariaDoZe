using FluentValidation.Results;
using ProjetoPastelariaDoZe.DAO;
using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using ProjetoPastelariaDoZe.WinFormsApp.Validadores.ModuloFuncionario;
using System.Configuration;

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

        private Funcionario? _funcionario;
        /// <summary>
        /// 
        /// </summary>
        public Funcionario Funcionario
        {
            get { return _funcionario!; }
            set
            {
                _funcionario = value;
                textBoxID.Text = _funcionario.Numero.ToString();
                textBoxNome.Text = _funcionario.Nome;
                maskedTextBoxCPF.Text = _funcionario.CPF;
                textBoxMatricula.Text = _funcionario.Matricula;
                maskedTextBoxTelefone.Text = _funcionario.Telefone;
                textBoxSenha.Text = String.Empty;
                if (_funcionario.Grupo == 1)
                    radioButtonAdmin.Checked = true;
                else
                    radioButtonBalcao.Checked = true;
            }
        }
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
            opcoes.buttonEditar.Click += ButtonEditar_Click;
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

        private void ButtonEditar_Click(object? sender, EventArgs e)
        {
            Funcionario funcionario = new();

            ConfigurarAtributos(funcionario);

            ValidadorFuncionarioEditar vf = new();

            ValidationResult vr = vf.Validate(funcionario);

            if (!vr.IsValid)
                MessageBox.Show(vr.ToString());
            else
            {
                try
                {
                    dao.EditarDBProvider(funcionario);

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
            if (!string.IsNullOrEmpty(textBoxID.Text))
                funcionario.Numero = Convert.ToInt32(textBoxID.Text);
            funcionario.Nome = textBoxNome.Text;
            funcionario.Matricula = textBoxMatricula.Text;
            funcionario.CPF = maskedTextBoxCPF.Text;
            funcionario.Telefone = maskedTextBoxTelefone.Text;
            if(!string.IsNullOrEmpty(textBoxSenha.Text))
                funcionario.Senha = Funcoes.Sha256Hash(textBoxSenha.Text);
            funcionario.Grupo = (radioButtonAdmin.Checked) ? 1 : 2; // Se .Checked == true, Grupo=1, senão, Grupo=2;
        }
    }
}