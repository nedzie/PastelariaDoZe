using ProjetoPastelariaDoZe.DAO.Compartilhado;
using System.Data;
using System.Data.Common;

namespace ProjetoPastelariaDoZe.DAO
{
    public class Produto
    {
        public int Numero { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal ValorUn { get; set; }
        public byte[]? Foto { get; set; }


    }
    public class ProdutoDAO : EntidadeBase
    {
        private readonly DbProviderFactory? factory;
        private string? Provider { get; set; }
        private string? StringConexao { get; set; }

        public ProdutoDAO(string provider, string connectionString)
        {
            Provider = provider;
            this.StringConexao = connectionString;
            this.factory = DbProviderFactories.GetFactory(Provider);
        }


        public void InserirDBProvider(Produto produto)
        {
            using var conexao = factory!.CreateConnection(); // Conexão com o BD
            conexao!.ConnectionString = StringConexao; // Informa a ConnectionString, o caminho para o BD
            using var comando = factory.CreateCommand(); // Cria o comando para o BD
            comando!.Connection = conexao; // Atribui a conexão

            ConfigurarParametrosProduto(produto, comando);

            conexao.Open();

            comando.CommandText =
                @"INSERT INTO
                    TB_PRODUTO
                            (
                            NOME,
                            DESCRICAO,
                            VALOR_UNITARIO,
                            FOTO
                            )
                        VALUES
                            (
                            @NOME,
                            @DESCRICAO,
                            @VALORUN,
                            @FOTO
                            )";

            var linhas = comando.ExecuteNonQuery();
        }

        private void ConfigurarParametrosProduto(Produto produto, DbCommand comando)
        {
            var nome = comando.CreateParameter();
            nome.ParameterName = "@NOME";
            nome.Value = produto.Nome;
            comando.Parameters.Add(nome);

            var descricao = comando.CreateParameter();
            descricao.ParameterName = "@DESCRICAO";
            descricao.Value = string.IsNullOrEmpty(produto.Descricao) ? DBNull.Value : produto.Descricao;
            comando.Parameters.Add(descricao);

            var valorUn = comando.CreateParameter();
            valorUn.ParameterName = "@VALORUN";
            valorUn.Value = produto.ValorUn;
            comando.Parameters.Add(valorUn);

            var foto = comando.CreateParameter();
            foto.ParameterName = "@FOTO";
            foto.Value = produto.Foto;
            comando.Parameters.Add(foto);
        }

        public override DataTable SelectDBProvider(object produto)
        {
            using var conexao = factory!.CreateConnection(); // Conexão com o BD
            conexao!.ConnectionString = StringConexao; // Informa a ConnectionString, o caminho para o BD
            using var comando = factory.CreateCommand(); // Cria o comando para o BD
            comando!.Connection = conexao; // Atribui a conexão

            conexao.Open();

            Produto aux = (Produto)produto;

            string auxSqlFiltro = "";

            if (aux.Numero > 0)
                auxSqlFiltro = " WHERE id_produto = " + aux.Numero;

            comando.CommandText =
                @"SELECT
                    ID_PRODUTO AS Id,
                    NOME AS Nome,
                    DESCRICAO AS Descrição,
                    VALOR_UNITARIO AS ValorUn,
                    FOTO AS Foto
                FROM
                    TB_PRODUTO" + auxSqlFiltro + " ORDER BY ID";

            var sdr = comando.ExecuteReader();

            DataTable linhas = new();

            linhas.Load(sdr);

            return linhas;
        }
    }
}
