using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Security.Cryptography;
using System.Text;

namespace ProjetoPastelariaDoZe.WinFormsApp.Compartilhado
{
    /// <summary>
    /// Classe Funções, onde estarão os métodos que realizam determinada tarefa dentro da aplicação.
    /// </summary>
    public class Funcoes
    {
        /// <summary>
        /// Ajusta automaticamente os textos/placeholders dos itens dos formulários
        /// </summary>
        /// <param name="container">Define qual a classe base</param>
        public static void AjustaResourcesForm(Control container)
        {
            foreach (Control c in container.Controls)
            {
                AjustaResourcesForm(c);
                ComponentResourceManager resources = new(typeof(Properties.Resources));
                resources.ApplyResources(c, c.Name);
            }
        }
        /// <summary>
        /// De forma recursiva, varre todos os componentes do Control informado,
        /// adicionando nos tipos informados os eventos Enter e Leave,
        /// e vinculando  aos manipuladores
        /// </summary>
        /// <param name="container">Informa o container inicial
        /// geralmente 'this' para pegar todos os campos da tela, ou então, por exemplo, o nome do 'panel' ou 'usercontrol'</param>
        public static void EventoFocoCampos(Control container)
        {
            foreach (Control c in container.Controls)
            {
                EventoFocoCampos(c); //Recursividade
                switch (c)
                {
                    case TextBoxBase:
                    case ComboBox:
                    case RadioButton:
                    case CheckBox:
                        //case ButtonBase: Fica muito louco
                        c.Enter += new EventHandler(CampoEventoEnter!);
                        c.Leave += new EventHandler(CampoEventoLeave!);
                        break;
                }
            }
        }
        /// <summary>
        /// Altera a cor do BackColor quando campo ganha foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">O evento que foi capturado</param>
        /// <example>textBoxUsuario.Enter += new System.EventHandler(Funcoes.CampoEventoEnter);</example>
        public static void CampoEventoEnter(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt) // MaskedBox, TextBox
                txt.BackColor = Color.LightCyan;
            else if (sender is ComboBox cb)
                cb.BackColor = Color.LightCyan;
            else if (sender is RadioButton rb)
                rb.ForeColor = Color.LightCyan;
            else if (sender is ButtonBase btn)
                btn.BackColor = Color.LightCyan;
        }
        /// <summary>
        /// Altera a do do BackColor quando o campo perde foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">O evento que foi capturado</param>
        /// <example>textBoxUsuario.Leave += new System.EventHandler(Funcoes.CampoEventoLeave);</example>
        public static void CampoEventoLeave(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt) // MaskedBox, TextBox
                txt.BackColor = Color.LightGray;
            else if (sender is ComboBox cb)
                cb.BackColor = Color.LightGray;
            else if (sender is RadioButton rb)
                rb.ForeColor = Color.LightGray;
            else if (sender is ButtonBase btn)
                btn.BackColor = Color.LightGray;
        }
         
        /// <summary>
        /// Tratar eventos de teclado, no caso tecla ENTER funcionando como TAB e tecla ESC para fechar
        /// </summary>
        /// <remarks>KeyPreview do formulário para 'true'</remarks>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example>No construtor do formulário:
        /// this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);</example>
        public static void FormEventoKeyDown(object sender, KeyEventArgs e)
        {
            Control x = (Control)sender; // Cast | Obtém o control que mandou o evento, x.FindForm recebe o evento onde x foi gerado
            Form form = x.FindForm();
            if (e.KeyCode == Keys.Enter) // Se a tecla pressionada for 'Enter'
            {
                e.SuppressKeyPress = true;
                form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);
            }
            else if(e.KeyCode == Keys.Escape) // Se foi pressionado 'Esc'
            {
                form.Close(); // Feche
            }
        }

        private static void RetornarMascaraMoeda(object sender, EventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }
        private static void TirarMascaraMoeda(object sender, EventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        private static void ApenasValorNumericoMoeda(object sender, KeyPressEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = txt.Text.Contains(',');
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="txt"></param>
        public static void AplicaMascaraMoeda(TextBoxBase txt)
        {
            txt.Enter += TirarMascaraMoeda!;
            txt.Leave += RetornarMascaraMoeda!;
            txt.KeyPress += ApenasValorNumericoMoeda!;
        }

        /// <summary>
        /// Método da classe funções para criptografar a senha dos clientes
        /// </summary>
        /// <param name="senha"></param>
        /// <returns></returns>
        public static string Sha256Hash(string senha)
        {
            var hash = new StringBuilder();
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                for (int i = 0; i < data.Length; i++)
                {
                    hash.Append(data[i].ToString("x2"));
                }
            }
            return hash.ToString();
        }
         
        /// <summary>
        /// Médodo da classe funções para validar a conexão com Banco de Dados escolhido
        /// </summary>
        public static bool ValidaConexaoDB()
        {
            DbProviderFactory factory;
            try
            {
                factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["BD"].ProviderName);
                using var conexao = factory.CreateConnection();
                conexao!.ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
                using var comando = factory.CreateCommand();
                comando!.Connection = conexao;
                conexao.Open();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new FormConfiguracoes().ShowDialog();
                ValidaConexaoDB();
                return false;
            }
        }
        /// <summary>
        /// Método responsável por converter as imagens dos produtos para byte arr, que serão salvos num banco de dados
        /// </summary>
        /// <param name="img">Imagem selecionada</param>
        /// <returns></returns>
        public static byte[] ConverterImagemParaByteArray(Image img)
        {
            MemoryStream ms = new();
            if(img != null)
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        /// <summary>
        /// Método responsável por converter as informações contidas num byte arr de volta para imagem
        /// </summary>
        /// <param name="data">byte[] com as informações</param>
        /// <returns></returns>
        public static Image? ConverterByteArrayParaImagem(byte[] data)
        {
            try
            {
                ImageConverter ic = new();

                return ic.ConvertFrom(data) as Image;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Método auxiliar que cria um pequeno inputBox para ser informada a quantia de consumo de determinado produto
        /// </summary>
        /// <param name="titulo">Título do form</param>
        /// <param name="texto">Texto contido no form</param>
        /// <param name="valor">Esse ainda tô vendo pra que serve</param>
        /// <returns></returns>
        public static DialogResult InputBox(string titulo, string texto, ref string valor)
        {
            Form form = new();
            Label label = new();
            TextBox textBox = new();
            Button buttonOk = new();
            Button buttonCancel = new();

            form.Text = titulo;
            label.Text = texto;
            textBox.Text = valor;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;

            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            valor = textBox.Text;

            return dialogResult;
        }
    }
}