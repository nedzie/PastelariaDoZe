using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using System.Configuration;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    public partial class FormConfiguracoes : Form
    {
        /// <summary>
        /// Construtor da classe Configuracoes
        /// </summary>
        public FormConfiguracoes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            Funcoes.EventoFocoCampos(this);

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formConfiguracoes.Text");
            comboBoxIdiomas.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");

            ConfigurarUserControl();

            ConfigurarBD();
        }

        

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            
        }
        private void ButtonSair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarUserControl()
        {
            UserControlControleUsuarioGeral opcoes = new();
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            opcoes.Dock = DockStyle.Bottom;
            this.Controls.Add(opcoes);
            opcoes.buttonSair.Click += ButtonSair_Click;
            opcoes.buttonSalvar.Click += ButtonSalvar_Click;
        }

        private void ConfigurarBD()
        {
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["BD"];

            comboBoxProvedores.Text = connectionStringSettings.ProviderName;
            comboBoxConnectionStrings.Text = connectionStringSettings.ConnectionString;
            //textBoxConnectionString.Text = connectionStringSettings.ConnectionString;
        }

        private void buttonSalvarIdioma_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxIdiomas.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();

            if (checkBoxReiniciar.Checked)
            {
                _ = MessageBox.Show(Properties.Resources.ResourceManager.GetString("MessageBox.Text"));

                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Environment.Exit(0);
            }
        }

        private void buttonSalvarBD_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvedores.SelectedItem.ToString();
            if (comboBoxConnectionStrings.SelectedItem != null)
                config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = comboBoxConnectionStrings.SelectedItem.ToString();
            else
                config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = comboBoxConnectionStrings.Text;

            config.Save(ConfigurationSaveMode.Modified, true);

            ConfigurationManager.RefreshSection("connectionStrings");

            this.Close();

            var deuCerto = Funcoes.ValidaConexaoDB();

            if(deuCerto)
                _ = MessageBox.Show("Alterou BD");
        }

        private void buttonLocalizar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogLog = new();

            saveFileDialogLog.Filter = "Arquivo|*.txt";
            saveFileDialogLog.Title = "Seleciona o local para salvar";
            saveFileDialogLog.FileName = "LOG.TXT";

            saveFileDialogLog.ShowDialog();

            if(saveFileDialogLog.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialogLog.OpenFile();
                fs.Close();
            }

            textBoxLocalLog.Text = saveFileDialogLog.FileName.ToString();
        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("LocalLog");
            config.AppSettings.Settings.Add("LocalLog", textBoxLocalLog.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}