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

        private Cliente? _cliente;
        /// <summary>
        /// 
        /// </summary>
        public Cliente? Cliente
        {
            get { return _cliente; }
            set
            {
                try
                {
                    if (value != null)
                    {
                        _cliente = value;

                        textBoxID.Text = _cliente.Numero.ToString();

                        if (_cliente.MarcaFiado == null)
                        {
                            textBoxNome.Text = _cliente.Nome;
                            radioButtonFiadoNao.Checked = true;
                        }
                        else
                        {
                            textBoxNome.Text = _cliente.Nome;
                            radioButtonFiadoSim.Checked = true;
                            maskedTextBoxTelefone.Text = _cliente.Telefone;
                            if (string.IsNullOrEmpty(_cliente.CPF))
                            {
                                maskedTextBoxCNPJ.Text = _cliente.CNPJ;
                                radioButtonJuridica.Checked = true;
                            }
                            else if (string.IsNullOrEmpty(_cliente.CNPJ))
                            {
                                maskedTextBoxCPF.Text = _cliente.CPF;
                                radioButtonFisica.Checked = true;
                            }
                        }
                    }
                    textBoxNome.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
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

            ConfigurarUserControl();

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new(provider, connectionString);
        }

        private void ConfigurarUserControl()
        {
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;
            Size = new Size(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
            opcoes.buttonSair.Click += ButtonSair_Click;
            opcoes.buttonEditar.Click += ButtonEditar_Click;
            opcoes.buttonExcluir.Click += ButtonExcluir_Click;
            opcoes.buttonSalvar.Click += ButtonSalvar_Click;
        }
        

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            Cliente cliente = new();
            ValidadorClienteFiadoCPF validadorFiadoCPF = new();
            ValidadorClienteFiadoCNPJ validadorFiadoCNPJ = new();
            ValidadorClienteComum validadorVista = new();

            ConfigurarParametrosInsercao(cliente);

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
        private void ButtonEditar_Click(object? sender, EventArgs e)
        {
            Cliente cliente = new();
            ValidadorClienteFiadoCPF validadorFiadoCPF = new();
            ValidadorClienteFiadoCNPJ validadorFiadoCNPJ = new();
            ValidadorClienteComum validadorVista = new();

            ConfigurarParametrosEdicao(cliente);

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
                    dao.EditarDBProvider(cliente);
                    MessageBox.Show("Deu boa");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonExcluir_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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

        private void ConfigurarParametrosInsercao(Cliente cliente)
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

        private void ConfigurarParametrosEdicao(Cliente cliente)
        {
            cliente.Numero = Convert.ToInt32(textBoxID.Text);

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