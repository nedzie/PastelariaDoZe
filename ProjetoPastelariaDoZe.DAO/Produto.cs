using ProjetoPastelariaDoZe.DAO.Arquivamento;
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
        /// <summary>
        /// Construtor conringa
        /// </summary>
        public ProdutoDAO()
        {

        }
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

            ConfigurarParametrosInserir(produto, comando);

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

            ClassLog.SalvaLog("SQL", 0, "Inserção de produto", comando);
        }

        public void EditarDBProvider(Produto produto)
        {
            using var conexao = factory!.CreateConnection(); // Conexão com o BD
            conexao!.ConnectionString = StringConexao; // Informa a ConnectionString, o caminho para o BD
            using var comando = factory.CreateCommand(); // Cria o comando para o BD
            comando!.Connection = conexao; // Atribui a conexão

            ConfigurarParametrosEditar(produto, comando);

            conexao.Open();

            comando.CommandText =
                @"UPDATE TB_PRODUTO
                        SET
                            NOME = @NOME,
                            DESCRICAO = @DESCRICAO,
                            VALOR_UNITARIO = @VALORUN,
                            FOTO = @FOTO
                        WHERE
                            ID_PRODUTO = @IDPRODUTO";

            var linhas = comando.ExecuteNonQuery();

            ClassLog.SalvaLog("SQL", 0, "Edição de produto", comando);
        }

        public void ExcluirDBProvider(Produto produto)
        {
            using var conexao = factory!.CreateConnection(); // Conexão com o BD
            conexao!.ConnectionString = StringConexao; // Informa a ConnectionString, o caminho para o BD
            using var comando = factory.CreateCommand(); // Cria o comando para o BD
            comando!.Connection = conexao; // Atribui a conexão

            ConfigurarParametrosExcluir(produto, comando);

            conexao.Open();

            comando.CommandText =
                @"DELETE 
                    FROM TB_PRODUTO
                    WHERE ID_PRODUTO = @IDPRODUTO";
            var linhas = comando.ExecuteNonQuery();

            ClassLog.SalvaLog("SQL", 0, "Exclusão de produto", comando);
        }

        private void ConfigurarParametrosInserir(Produto produto, DbCommand comando)
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

        private void ConfigurarParametrosEditar(Produto produto, DbCommand comando)
        {
            var id = comando.CreateParameter();
            id.ParameterName = "@IDPRODUTO";
            id.Value = produto.Numero;
            comando.Parameters.Add(id);

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

        private void ConfigurarParametrosExcluir(Produto produto, DbCommand comando)
        {
            var id = comando.CreateParameter();
            id.ParameterName = "@IDPRODUTO";
            id.Value = produto.Numero;
            comando.Parameters.Add(id);
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
                auxSqlFiltro = " WHERE ID_PRODUTO = " + aux.Numero;

            if (aux.Nome != null)
            {
                if (aux.Nome!.Length > 0)
                    auxSqlFiltro = " WHERE NOME like '%" + aux.Nome + "%' ";
            }

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
