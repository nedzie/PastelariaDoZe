using ProjetoPastelariaDoZe.DAO.ModuloComanda;
using ProjetoPastelariaDoZe.DAO.ModuloProduto;
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
        ProdutoDAO? cdao;
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
            ConfigurarDAO();
            AtualizarTelaAreaComandas();

            this.Load += buttonPesquisar_Click!;
        }

        private void ConfigurarUserControl()
        {
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
            opcoes.buttonSair.Click += ButtonSair_Click;
        }

        private void ConfigurarDAO()
        {
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new(provider, connectionString);
            cdao = new(provider, connectionString);
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
                    MessageBox.Show("ERRO!!! Comanda " + textBoxNumeroComanda.Text + " já esta aberta!!!");
                else
                    MessageBox.Show("Comanda aberta com sucesso!");
                    AtualizarTelaAreaComandas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaAreaComandas()
        {
            var comanda = new Comanda
            {
                StatusComanda = 0
            };
            try
            {
                DataTable linhas = dao!.ListarComandas(comanda);

                dataGridViewComandasAbertas.AutoGenerateColumns = true;
                dataGridViewComandasAbertas.DataSource = linhas;
                dataGridViewComandasAbertas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaItensComanda(int idComanda)
        {
            var comandaProdutos = new ComandaProdutos
            {
                IdComanda = idComanda
            };

            try
            {
                DataTable linhas = dao!.ListaItensComanda(comandaProdutos);

                dataGridViewItensComanda.AutoGenerateColumns = true;
                dataGridViewItensComanda.DataSource = linhas;
                dataGridViewItensComanda.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            var produto = new Produto
            {
                Numero = 0,
                Nome = textBoxProduto.Text
            };
            try
            {
                DataTable linhas = cdao!.SelectDBProvider(produto);

                dataGridViewProdutos.Columns.Clear();
                dataGridViewProdutos.AutoGenerateColumns = true;
                dataGridViewProdutos.DataSource = linhas;
                dataGridViewProdutos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRowComanda = dataGridViewComandasAbertas.Rows[dataGridViewComandasAbertas.SelectedCells[0].RowIndex];
                int idComanda = Convert.ToInt32(selectedRowComanda.Cells[0].Value);
                int numeroComanda = Convert.ToInt32(selectedRowComanda.Cells[1].Value);

                DataGridViewRow selectedRowProduto = dataGridViewProdutos.Rows[dataGridViewProdutos.SelectedCells[0].RowIndex];
                int idProduto = Convert.ToInt32(selectedRowProduto.Cells[0].Value);
                string nomeProduto = Convert.ToString(selectedRowProduto.Cells[1].Value)!;
                double valorProduto = Convert.ToDouble(selectedRowProduto.Cells[3].Value);

                string value = "1";
                if (Funcoes.InputBox("Adicionar " + nomeProduto + " na Comanda: " + numeroComanda, "Quantidade:", ref value) == DialogResult.OK)
                {
                    var comandaProdutos = new ComandaProdutos
                    {
                        IdComanda = idComanda,
                        IdProduto = idProduto,
                        Quantidade = Convert.ToInt32(value),
                        ValorUnitario = valorProduto,
                        IdFuncionario = Program.idLogado
                    };
                    try
                    {
                        dao!.AddItem(comandaProdutos);
                        AtualizarTelaItensComanda(comandaProdutos.IdComanda);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridViewComandasAbertas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewComandasAbertas.SelectedCells.Count > 0)
            {
                //pega a linha selecionada
                DataGridViewRow selectedRow =
                dataGridViewComandasAbertas.Rows[dataGridViewComandasAbertas.SelectedCells[0].RowIndex];
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                int idComanda = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizarTelaItensComanda(idComanda);
            }
        }

        private void dataGridViewItensComanda_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRowComanda = dataGridViewComandasAbertas.Rows[dataGridViewComandasAbertas.SelectedCells[0].RowIndex];
                int idComanda = Convert.ToInt32(selectedRowComanda.Cells[0].Value);
                int numeroComanda = Convert.ToInt32(selectedRowComanda.Cells[1].Value);

                DataGridViewRow selectedRowComandaItens = dataGridViewItensComanda.Rows[dataGridViewItensComanda.SelectedCells[0].RowIndex];
                int idComandaProduto = Convert.ToInt32(selectedRowComandaItens.Cells[0].Value);
                string nomeProduto = Convert.ToString(selectedRowComandaItens.Cells[1].Value)!;
                string qtdaProduto = Convert.ToString(selectedRowComandaItens.Cells[2].Value)!;
                double valorProduto = Convert.ToDouble(selectedRowComandaItens.Cells[3].Value);

                if (Funcoes.InputBox("Editar " + nomeProduto + " na Comanda: " + numeroComanda, "Quantidade:", ref qtdaProduto) == DialogResult.OK)
                {
                    var comandaProdutos = new ComandaProdutos
                    {
                        IdComandaProduto = idComandaProduto,
                        Quantidade = Convert.ToInt32(qtdaProduto),
                        IdFuncionario = Program.idLogado
                    };
                    try
                    {
                        dao!.EditarItemComanda(comandaProdutos);
                        AtualizarTelaItensComanda(idComanda);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}