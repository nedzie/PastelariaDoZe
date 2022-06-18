using ProjetoPastelariaDoZe.DAO.Arquivamento;
using ProjetoPastelariaDoZe.DAO.Compartilhado;
using ProjetoPastelariaDoZe.DAO.ModuloCliente;
using ProjetoPastelariaDoZe.DAO.ModuloFuncionario;
using ProjetoPastelariaDoZe.DAO.ModuloProduto;
using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using System.ComponentModel;
using System.Data;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe auxiliar Inicio
    /// </summary>
    public partial class FormInicio : Form
    {
        EntidadeBase? dao;
        /// <summary>
        /// Construtor da classe Inicio
        /// </summary>
        public FormInicio()
        {
            InitializeComponent();

            ClassLog.SalvaLog("ABERTURA");

            AjustarTelaLogin();

            Funcoes.AjustaResourcesForm(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formInicio.Text");

            ConfigurarAcoesBotoes();

            ComponentResourceManager resources = new(typeof(Properties.Resources));
            foreach (ToolStripItem c in contextMenuStripInicio.Items)
            {
                resources.ApplyResources(c, c.Name);
            }
            foreach (ToolStripItem c in contextMenuStripSystemTray.Items)
            {
                resources.ApplyResources(c, c.Name);
            }

            dao = new();
        }

        private void ConfigurarAcoesBotoes()
        {
            toolStripMenuItemLogin.Click += new EventHandler(buttonLogin_Click!);
            toolStripMenuItemFuncionarios.Click += new EventHandler(buttonFuncionarios_Click!);
            toolStripMenuItemClientes.Click += new EventHandler(buttonClientes_Click!);
            toolStripMenuItemProdutos.Click += new EventHandler(buttonProdutos_Click!);
            toolStripMenuItemConfiguracoes.Click += new EventHandler(buttonConfiguracoes_Click!);
            toolStripMenuItemSobre.Click += new EventHandler(buttonSobre_Click!);
            toolStripMenuItemSair.Click += ToolStripMenuItemSystemTraySair_Click;

            toolStripMenuItemSystemTrayAbrir.Click += ToolStripMenuItemSystemTrayAbrir_Click;
            toolStripMenuItemSystemTraySair.Click += ToolStripMenuItemSystemTraySair_Click;
            toolStripMenuItemSystemTraySobre.Click += new EventHandler(buttonSobre_Click!);

            buttonSair.Click += ToolStripMenuItemSystemTraySair_Click;
        }

        private void ToolStripMenuItemSystemTraySair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemSystemTrayAbrir_Click(object? sender, EventArgs e)
        {
            this.Show();
        }
        private void notifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fechar fechar = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            if (fechar.ShowDialog() == DialogResult.No)
                e.Cancel = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            login.ShowDialog(); // Modal
            AjustarTelaLogin();
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            Opcao o = new();

            var res = o.ShowDialog();

            FormFuncionario funcionarios = new();
            {
                StartPosition = FormStartPosition.CenterScreen;
            };

            if (res == DialogResult.OK)
            {
                funcionarios.ShowDialog(); // Modal
                AtualizarTela(funcionarios.dao);
            }
            else if (res == DialogResult.Yes)
                AtualizarTela(funcionarios.dao);
        }
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            Opcao o = new();

            var res = o.ShowDialog();

            FormCliente clientes = new FormCliente
            {
                StartPosition = FormStartPosition.CenterScreen
            };

            if (res == DialogResult.OK)
            {
                clientes.ShowDialog();
                AtualizarTela(clientes.dao);
            }
            else if (res == DialogResult.Yes)
                AtualizarTela(clientes.dao);

        }
        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            Opcao o = new();

            var res = o.ShowDialog();

            FormProdutos produtos = new FormProdutos
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            if (res == DialogResult.OK)
            {
                produtos.ShowDialog();
                AtualizarTela(produtos.dao!);
            }
            else if (res == DialogResult.Yes)
                AtualizarTela(produtos.dao!);
        }

        private void buttonComandas_Click(object sender, EventArgs e)
        {
            FormComandas comanda = new();
            this.Opacity = 0;
            comanda.ShowDialog();
            this.Opacity = 100;
        }

        private void buttonConfiguracoes_Click(object sender, EventArgs e)
        {
            FormConfiguracoes configuracoes = new();
            configuracoes.Show(); // Janela normal
        }
        private void buttonSobre_Click(object sender, EventArgs e)
        {
            FormSobre sobre = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            sobre.ShowDialog();
        }

        private void Inicio_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
                notifyIconSystemTray.BalloonTipText = Properties.Resources.ResourceManager.GetString("BalloonTipText.Text");
                notifyIconSystemTray.BalloonTipTitle = Properties.Resources.ResourceManager.GetString("BalloonTipTitle.Text");
                notifyIconSystemTray.ShowBalloonTip(1000);

            }
            else if (FormWindowState.Normal == this.WindowState)
                notifyIconSystemTray.Visible = false;
        }

        /// <summary>
        /// Código para povoar a tela principal com as informações escolhidas. <br></br>
        /// </summary>
        /// <param name="objetoDAO">Objeto em questão</param>
        private void AtualizarTela(object objetoDAO)
        {
            Funcionario funcionario = new Funcionario
            {
                Numero = 0
            };

            Cliente cliente = new Cliente
            {
                Numero = 0
            };

            Produto produto = new Produto
            {
                Numero = 0
            };
            var tipo = objetoDAO.GetType();

            switch (tipo.Name)
            {
                case "FuncionarioDAO":
                    dao = (FuncionarioDAO)objetoDAO;
                    break;
                case "ClienteDAO":
                    dao = (ClienteDAO)objetoDAO;
                    break;
                case "ProdutoDAO":
                    dao = (ProdutoDAO)objetoDAO;
                    break;
            }

            try
            {
                DataTable linhas = new();
                switch (tipo.Name)
                {
                    case "FuncionarioDAO":
                        linhas = dao!.SelectDBProvider(funcionario);
                        break;
                    case "ClienteDAO":
                        linhas = dao!.SelectDBProvider(cliente);
                        break;
                    case "ProdutoDAO":
                        linhas = dao!.SelectDBProvider(produto);
                        break;
                }

                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            buttonPesquisar.Enabled = true;
            textBoxProcurarNome.Enabled = true;
        }

        private void dataGridViewDados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = 0;
            DataGridViewRow selectedRow = new();
            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                id = Convert.ToInt32(selectedRow.Cells[0].Value);
            }

            var qtdeRows = dataGridViewDados.ColumnCount;

            switch (qtdeRows)
            {
                case 5: // Produto
                    Produto p = RecriarProdutoDaGrid(id, selectedRow);
                    EditarProduto(p);
                    break;
                case 6: //Funcionário
                    Funcionario f = RecriarFuncionarioDaGrid(id, selectedRow);
                    EditarFuncionario(f);
                    break;
                case 7: // Cliente 
                    Cliente c = RecriarClienteDaGrid(id, selectedRow);
                    EditarCliente(c);
                    break;
            }
        }

        private void EditarProduto(Produto prod)
        {
            FormProdutos telaProd = new FormProdutos
            {
                StartPosition = FormStartPosition.CenterScreen,
                Produto = prod
            };

            telaProd.ShowDialog();

            AtualizarTela(telaProd.dao!);
        }
        private void EditarFuncionario(Funcionario func)
        {
            FormFuncionario telaFunc = new FormFuncionario
            {
                StartPosition = FormStartPosition.CenterScreen,
                Funcionario = func
            };

            telaFunc.ShowDialog();

            AtualizarTela(telaFunc.dao);
        }

        private void EditarCliente(Cliente cli)
        {
            FormCliente telaCli = new FormCliente
            {
                StartPosition = FormStartPosition.CenterParent,
                Cliente = cli
            };

            telaCli.ShowDialog();

            AtualizarTela(telaCli.dao);
        }

        private static Produto RecriarProdutoDaGrid(int id, DataGridViewRow selectedRow)
        {
            return new()
            {
                Numero = id,
                Nome = Convert.ToString(selectedRow.Cells[1].Value),
                Descricao = Convert.ToString(selectedRow.Cells[2].Value),
                ValorUn = Convert.ToDecimal(selectedRow.Cells[3].Value),
                Foto = (byte[])selectedRow.Cells[4].Value
            };
        }

        private Funcionario RecriarFuncionarioDaGrid(int id, DataGridViewRow selectedRow)
        {
            return new()
            {
                Numero = id,
                Nome = Convert.ToString(selectedRow.Cells[1].Value),
                CPF = Convert.ToString(selectedRow.Cells[2].Value),
                Telefone = Convert.ToString(selectedRow.Cells[3].Value),
                Matricula = Convert.ToString(selectedRow.Cells[4].Value),
                Grupo = Convert.ToInt32(selectedRow.Cells[5].Value)
            };
        }

        private Cliente RecriarClienteDaGrid(int id, DataGridViewRow selectedRow)
        {
            if (selectedRow.Cells[2].Value == DBNull.Value && selectedRow.Cells[3].Value == DBNull.Value)
            {
                return new()
                {
                    Numero = id,
                    Nome = selectedRow.Cells[1].Value.ToString()
                };
            }
            if (selectedRow.Cells[2].Value == DBNull.Value)
            {
                return new()
                {
                    Numero = id,
                    Nome = selectedRow.Cells[1].Value.ToString(),
                    CNPJ = selectedRow.Cells[3].Value.ToString(),
                    Telefone = selectedRow.Cells[4].Value.ToString(),
                    MarcaFiado = Convert.ToInt32(selectedRow.Cells[5].Value),
                    DiaDoFiado = Convert.ToInt32(selectedRow.Cells[6].Value)
                };
            }
            else
                return new()
                {
                    Numero = id,
                    Nome = selectedRow.Cells[1].Value.ToString(),
                    CPF = selectedRow.Cells[2].Value.ToString(),
                    Telefone = selectedRow.Cells[4].Value.ToString(),
                    MarcaFiado = Convert.ToInt32(selectedRow.Cells[5].Value),
                    DiaDoFiado = Convert.ToInt32(selectedRow.Cells[6].Value)
                };
        }

        private void AjustarTelaLogin()
        {
            if (!Program.estaLogado) // false
            {
                buttonInicio.Enabled = Program.estaLogado;
                buttonCaixa.Enabled = Program.estaLogado;
                buttonFuncionarios.Enabled = Program.estaLogado;
                buttonComandas.Enabled = Program.estaLogado;
                buttonClientes.Enabled = Program.estaLogado;
                buttonProdutos.Enabled = Program.estaLogado;
                buttonConfiguracoes.Enabled = Program.estaLogado;
            }
            else
            {
                labelNome.Text = Program.nomeLogado;
                labelGroup.Text = Program.grupoLogado == 1 ? "Admin" : "Balcão";

                if (Program.grupoLogado == 1)
                {
                    buttonInicio.Enabled = Program.estaLogado;
                    buttonCaixa.Enabled = Program.estaLogado;
                    buttonFuncionarios.Enabled = Program.estaLogado;
                    buttonComandas.Enabled = Program.estaLogado;
                    buttonClientes.Enabled = Program.estaLogado;
                    buttonProdutos.Enabled = Program.estaLogado;
                    buttonConfiguracoes.Enabled = Program.estaLogado;
                }
                else
                {
                    buttonInicio.Enabled = Program.estaLogado;
                    buttonCaixa.Enabled = !Program.estaLogado;
                    buttonFuncionarios.Enabled = !Program.estaLogado;
                    buttonComandas.Enabled = Program.estaLogado;
                    buttonClientes.Enabled = !Program.estaLogado;
                    buttonProdutos.Enabled = !Program.estaLogado;
                    buttonConfiguracoes.Enabled = !Program.estaLogado;
                }
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            var qtdeRows = dataGridViewDados.ColumnCount;

            switch (qtdeRows)
            {
                case 5: // Produto
                    Produto p = new Produto
                    {
                        Numero = 0
                    };
                    AtualizarTelaBusca(p);
                    break;
                case 6: //Funcionário
                    Funcionario f = new Funcionario
                    {
                        Numero = 0
                    };
                    AtualizarTelaBusca(f);
                    break;
                case 7: // Cliente 
                    Cliente c = new Cliente
                    {
                        Numero = 0
                    };
                    AtualizarTelaBusca(c);
                    break;
            }
        }
        /// <summary>
        /// Método auxiliar
        /// </summary>
        /// <param name="objeto"></param>
        public void AtualizarTelaBusca(object objeto)
        {
            Funcionario funcionario = new Funcionario
            {
                Numero = 0,
                Nome = textBoxProcurarNome.Text
            };

            Cliente cliente = new Cliente
            {
                Numero = 0,
                Nome = textBoxProcurarNome.Text
            };

            Produto produto = new Produto
            {
                Numero = 0,
                Nome = textBoxProcurarNome.Text
            };

            DataTable linhas = new();

            var oQueEh = objeto.GetType();

            try
            {
                switch (oQueEh.Name)
                {
                    case "Funcionario":
                        linhas = dao!.SelectDBProvider(funcionario);
                        break;
                    case "Cliente":
                        linhas = dao!.SelectDBProvider(cliente);
                        break;
                    case "Produto":
                        linhas = dao!.SelectDBProvider(produto);
                        break;
                }

                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}