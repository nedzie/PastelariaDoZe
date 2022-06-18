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
    }
}
