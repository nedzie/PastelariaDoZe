using FluentValidation.Results;
using ProjetoPastelariaDoZe.DAO;
using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using ProjetoPastelariaDoZe.WinFormsApp.Validadores.ModuloCliente;
using System.Configuration;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe auxiliar Clientes
    /// </summary>
    public partial class FormCliente : Form
    {
        /// <summary>
        /// Atriburo DAO de Cliente para a tela de cadastro de cliente
        /// </summary>
        public readonly ClienteDAO dao;
        /// <summary>
        /// Construtor da classe Clientes
        /// </summary>
        public FormCliente()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formClientes.Text");
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;
            Size = new Size(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
            opcoes.buttonSair.Click += ButtonSair_Click;
            opcoes.buttonSalvar.Click += ButtonSalvar_Click;
            MaximizeBox = false;

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new(provider, connectionString);
        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            Cliente cliente = new();
            ValidadorClienteFiadoCPF validadorFiadoCPF = new();
            ValidadorClienteFiadoCNPJ validadorFiadoCNPJ = new();
            ValidadorClienteComum validadorVista = new();
            ConfigurarAtributos(cliente);

            ValidationResult vr;
            if (cliente.MarcaFiado == 1)
            {
                if (cliente.CPF != null)
                    vr = validadorFiadoCPF.Validate(cliente);
                else
                    vr = validadorFiadoCNPJ.Validate(cliente);
            }
            else
                vr = validadorVista.Validate(cliente);

            if (!vr.IsValid)
                MessageBox.Show(vr.ToString());
            else
            {
                try
                {
                    dao.InserirDBProvider(cliente);
                    MessageBox.Show("Deu boa");
                    this.Close();
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

        private void radioButtonFiadoSim_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDiaDoFiado.Enabled = true;
            textBoxNome.Enabled = true;
            radioButtonFisica.Enabled = true;
            radioButtonJuridica.Enabled = true;
            maskedTextBoxCPF.Enabled = true;
            maskedTextBoxCNPJ.Enabled = true;
            maskedTextBoxTelefone.Enabled = true;
            textBoxSenha.Enabled = true;
        }

        private void radioButtonFiadoNao_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDiaDoFiado.ResetText();
            textBoxSenha.ResetText();
            textBoxNome.Enabled = true;

            numericUpDownDiaDoFiado.Enabled = false;
            radioButtonFisica.Enabled = false;
            radioButtonJuridica.Enabled = false;
            maskedTextBoxCPF.Enabled = false;
            maskedTextBoxCNPJ.Enabled = false;
            maskedTextBoxTelefone.Enabled = false;
            textBoxSenha.Enabled = false;
        }
        private void radioButtonFisica_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxCPF.Enabled = true;
            maskedTextBoxCNPJ.Enabled = false;
            maskedTextBoxCNPJ.Clear();
            maskedTextBoxCPF.Focus();
        }

        private void radioButtonJuridica_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxCNPJ.Enabled = true;
            maskedTextBoxCPF.Enabled = false;
            maskedTextBoxCPF.Clear();
            maskedTextBoxCNPJ.Focus();
        }

        private void ConfigurarAtributos(Cliente cliente)
        {
            cliente.MarcaFiado = radioButtonFiadoSim.Checked ? 1 : 0;

            if (cliente.MarcaFiado == 1)
            {
                cliente.DiaDoFiado = Convert.ToInt32(numericUpDownDiaDoFiado.Value);

                cliente.Nome = textBoxNome.Text;

                if (radioButtonFisica.Checked)
                    cliente.CPF = maskedTextBoxCPF.Text;
                if (radioButtonJuridica.Checked)
                    cliente.CNPJ = maskedTextBoxCNPJ.Text;

                cliente.Telefone = maskedTextBoxTelefone.Text;

                cliente.Senha = Funcoes.Sha256Hash(textBoxSenha.Text);
            }
            else
                cliente.Nome = textBoxNome.Text;
        }
    }
}