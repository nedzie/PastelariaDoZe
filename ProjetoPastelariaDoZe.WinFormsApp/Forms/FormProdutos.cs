using FluentValidation.Results;
using ProjetoPastelariaDoZe.DAO;
using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using ProjetoPastelariaDoZe.WinFormsApp.Validadores.ModuloProduto;
using System.Configuration;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe auxiliar Produtos
    /// </summary>
    public partial class FormProdutos : Form
    {
        /// <summary>
        /// Instância DAO dentro da classe FormProdutos
        /// </summary>
        public readonly ProdutoDAO? dao;

        private Produto? _produto;
        /// <summary>
        /// Atributo "Produto" para povoar a tela de cadastro de produto
        /// </summary>
        public Produto? Produto
        {
            get { return _produto; }
            set
            {
                try
                {
                    if (value != null)
                    {
                        _produto = value!;
                        textBoxID.Text = _produto!.Numero.ToString();
                        textBoxNome.Text = _produto!.Nome;
                        textBoxDescricaoProduto.Text = _produto!.Descricao;
                        textBoxValorUnitario.Text = _produto!.ValorUn.ToString();
                        pictureBoxImagem.Image = Funcoes.ConverterByteArrayParaImagem((byte[])_produto.Foto!);
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
        /// Construtor da classe Produtos
        /// </summary>
        public FormProdutos()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formProdutos.Text");
            UserControlControleUsuarioGeral opcoes = new()
            {
                Dock = DockStyle.Bottom
            };
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);

            Funcoes.AplicaMascaraMoeda(textBoxValorUnitario);
            this.Controls.Add(opcoes);
            opcoes.buttonSalvar.Click += ButtonSalvar_Click;
            opcoes.buttonEditar.Click += ButtonEditar_Click;
            opcoes.buttonExcluir.Click += ButtonExcluir_Click;
            opcoes.buttonSair.Click += ButtonSair_Click;

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new(provider, connectionString);
        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            Produto produto = new();

            ConfigurarParametrosInsercao(produto);

            ValidadorProduto vp = new();

            ValidationResult vr = vp.Validate(produto);

            if (!vr.IsValid)
                MessageBox.Show(vr.ToString());
            else
            {
                try
                {
                    dao!.InserirDBProvider(produto);

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
            Produto produto = new();

            ConfigurarParametrosEdicao(produto);

            ValidadorProduto vp = new();

            ValidationResult vr = vp.Validate(produto);

            if (!vr.IsValid)
                MessageBox.Show(vr.ToString());
            else
            {
                try
                {
                    dao!.EditarDBProvider(produto);

                    MessageBox.Show("Deu boa");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonExcluir_Click(object? sender, EventArgs e)
        {
            Produto produto = new();

            ConfigurarParametrosExclusao(produto);

            try
            {
                dao!.ExcluirDBProvider(produto);

                MessageBox.Show("Excluída essa desgraça");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfigurarParametrosInsercao(Produto produto)
        {
            produto.Numero = 0;
            produto.Nome = textBoxNome.Text;
            if (textBoxDescricaoProduto.Text != null)
                produto.Descricao = textBoxDescricaoProduto.Text;
            if (textBoxValorUnitario.Text != string.Empty) 
                produto.ValorUn = Convert.ToDecimal(RemoverMascaras(textBoxValorUnitario.Text));

            produto.Foto = Funcoes.ConverterImagemParaByteArray(pictureBoxImagem.Image);
        }

        private string RemoverMascaras(string text)
        {
            return text.Replace("R$", "").Replace("$", "").Replace("₱", "").Replace("£", "").Replace("€", "");
        }

        private void ConfigurarParametrosEdicao(Produto produto)
        {
            produto.Numero = Convert.ToInt32(textBoxID.Text);
            produto.Nome = textBoxNome.Text;
            if (textBoxDescricaoProduto.Text != null)
                produto.Descricao = textBoxDescricaoProduto.Text;
            if (textBoxValorUnitario.Text != string.Empty)
                produto.ValorUn = Convert.ToDecimal(textBoxValorUnitario.Text);
            produto.Foto = Funcoes.ConverterImagemParaByteArray(pictureBoxImagem.Image);
        }
        /// <summary>
        /// ddd
        /// </summary>
        /// <param name="produto"></param>
        public void ConfigurarParametrosExclusao(Produto produto)
        {
            produto.Numero = Convert.ToInt32(textBoxID.Text);
        }

        private void pictureBoxImagem_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Title = "Imagem do produto"; //Trocar para outras culturas
            openFileDialogImagem.Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.icon;*.JFIF";

            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagem.Image = Image.FromFile(openFileDialogImagem.FileName);

                pictureBoxImagem.Image = new Bitmap(pictureBoxImagem.Image, new Size(130, 98));

                pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void ButtonSair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}