using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPastelariaDoZe.DAO.ModuloComanda
{
    public class Comanda
    {
        public int IdComanda { get; set; }
        public string NumeroComanda { get; set; }
        public DateTime DataHora { get; set; }
        public int StatusComanda { get; set; }


        public int IdCliente { get; set; }
        public int IdFuncionario { get; set; }
        public DateTime DataAssinaturaFiado { get; set; }
        public int StatusPagamento { get; set; }
        public Comanda(int idComanda = 0, string numeroComanda = "", DateTime dataHora = default, int statusComanda = 0, int
        idCliente = 0, int idFuncionario = 0, DateTime dataAssinaturaFiado = default, int statusPagamento = 0)
        {
            IdComanda = idComanda;
            NumeroComanda = numeroComanda;
            DataHora = dataHora;
            StatusComanda = statusComanda;
            IdCliente = idCliente;
            IdFuncionario = idFuncionario;
            DataAssinaturaFiado = dataAssinaturaFiado;
            StatusPagamento = statusPagamento;
        }

        public override string ToString()
        {
            return NumeroComanda;
        }
    }

    public class ComandaDAO
    {
        private readonly DbProviderFactory? factory;
        private string? Provider { get; set; }
        private string? StringConexao { get; set; }

        public ComandaDAO(string? provider, string? connectionString)
        {
            Provider = provider;
            StringConexao = connectionString;
            factory = DbProviderFactories.GetFactory(Provider!);
        }

        public bool AbreNovaComanda(Comanda comanda)
        {
            using var conexao = factory!.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetros (@campo e valor)
            var numeroComanda = comando.CreateParameter();
            numeroComanda.ParameterName = "@numeroComanda";
            numeroComanda.Value = comanda.NumeroComanda;
            comando.Parameters.Add(numeroComanda);

            var dataHora = comando.CreateParameter();
            dataHora.ParameterName = "@dataHora";
            dataHora.Value = comanda.DataHora;
            comando.Parameters.Add(dataHora);

            var statusComanda = comando.CreateParameter();
            statusComanda.ParameterName = "@statusComanda";
            statusComanda.Value = comanda.StatusComanda;
            comando.Parameters.Add(statusComanda);

            conexao.Open();
            // antes de abrir a comanda validar se ela já não esta aberta
            comando.CommandText =
                @"SELECT 
                        ID_COMANDA 
                    FROM 
                        TB_COMANDA 
                    WHERE 
                        STATUS_COMANDA = @STATUSCOMANDA AND COMANDA = @NUMEROCOMANDA";

            DataTable qtdaComandas = new();

            qtdaComandas.Load(comando.ExecuteReader());

            if (qtdaComandas.Rows.Count > 0)
                return false;
            else
            {
                comando.CommandText =
                    @"INSERT 
                        INTO 
                            TB_COMANDA
                                (COMANDA, DATA_HORA, STATUS_COMANDA) 
                            VALUES 
                                (@NUMEROCOMANDA, @DATAHORA, @STATUSCOMANDA)";

                var linhas = comando.ExecuteNonQuery();
                return true;
            }
        }

        public void AddItem(ComandaProdutos comandaProdutos)
        {
            using var conexao = factory!.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão

            var idComanda = comando.CreateParameter();
            idComanda.ParameterName = "@IDCOMANDA";
            idComanda.Value = comandaProdutos.IdComanda;
            comando.Parameters.Add(idComanda);

            var idProduto = comando.CreateParameter();
            idProduto.ParameterName = "@IDPRODUTO";
            idProduto.Value = comandaProdutos.IdProduto;
            comando.Parameters.Add(idProduto);

            var quantidade = comando.CreateParameter();
            quantidade.ParameterName = "@QUANTIDADE";
            quantidade.Value = comandaProdutos.Quantidade;
            comando.Parameters.Add(quantidade);

            var valorUnitario = comando.CreateParameter();
            valorUnitario.ParameterName = "@VALORUNITARIO";
            valorUnitario.Value = comandaProdutos.ValorUnitario;
            comando.Parameters.Add(valorUnitario);

            var idFuncionario = comando.CreateParameter();
            idFuncionario.ParameterName = "@IDFUNCIONARIO";
            idFuncionario.Value = comandaProdutos.IdFuncionario;
            comando.Parameters.Add(idFuncionario);

            conexao.Open();

            comando.CommandText =
            @"INSERT INTO 
                TB_COMANDA_PRODUTO
                    (
                        COMANDA_ID, 
                        PRODUTO_ID, 
                        QUANTIDADE, 
                        VALOR_UNITARIO, 
                        FUNCIONARIO_ID
                    )
                VALUES 
                    (
                        @IDCOMANDA, 
                        @IDPRODUTO, 
                        @QUANTIDADE, 
                        @VALORUNITARIO, 
                        @IDFUNCIONARIO
                    )";

            var linhas = comando.ExecuteNonQuery();
        }

        public DataTable ListarComandas(Comanda comanda)
        {
            using var conexao = factory!.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetros (@campo e valor)
            var statusComanda = comando.CreateParameter();
            statusComanda.ParameterName = "@statusComanda";
            statusComanda.Value = comanda.StatusComanda;
            comando.Parameters.Add(statusComanda);
            conexao.Open();
            comando.CommandText =
            @"SELECT 
                ID_COMANDA AS ID, 
                COMANDA AS COMANDA, 
                DATA_HORA AS DATA, 
                STATUS_COMANDA AS STATUS 
            FROM 
                TB_COMANDA 
            WHERE 
                STATUS_COMANDA = @STATUSCOMANDA";

            var sdr = comando.ExecuteReader();

            DataTable linhas = new();
            linhas.Load(sdr);

            return linhas;
        }

        public DataTable ListaItensComanda(ComandaProdutos comandaProdutos)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetros (@campo e valor)
            var idComanda = comando.CreateParameter();
            idComanda.ParameterName = "@idComanda";
            idComanda.Value = comandaProdutos.IdComanda;
            comando.Parameters.Add(idComanda);
            conexao.Open();
            comando.CommandText =
            @"SELECT 
                CP.ID_COMANDA_PRODUTO AS ID, 

                P.NOME AS NOME, 

                CP.QUANTIDADE AS QUANTIDADE,
                CP.VALOR_UNITARIO AS UNITÁRIO, 

                F.NOME AS FUNCIONÁRIO
            FROM TB_COMANDA_PRODUTO CP
                INNER JOIN TB_PRODUTO P ON CP.PRODUTO_ID = P.ID_PRODUTO
                INNER JOIN TB_FUNCIONARIO F ON CP.FUNCIONARIO_ID = F.ID_FUNCIONARIO
            WHERE 
                CP.COMANDA_ID = @IDCOMANDA;";

            var sdr = comando.ExecuteReader();

            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }

    public class ComandaProdutos
    {
        public int IdComandaProduto { get; set; }
        public int IdComanda { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public int IdFuncionario { get; set; }

        public ComandaProdutos(int idComandaProduto = 0, int idComanda = 0, int
        idProduto = 0, int quantidade = 0, double valorUnitario = 0, int idFuncionario
        = 0)
        {
            IdComandaProduto = idComandaProduto;
            IdComanda = idComanda;
            IdProduto = idProduto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            IdFuncionario = idFuncionario;
        }
    }
}
