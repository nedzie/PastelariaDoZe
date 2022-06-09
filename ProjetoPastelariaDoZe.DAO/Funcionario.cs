using ProjetoPastelariaDoZe.DAO.Compartilhado;
using System.Data;
using System.Data.Common;

namespace ProjetoPastelariaDoZe.DAO
{
    public class Funcionario
    {
        /// <summary>
        /// O número (id) de cada funcionário
        /// </summary>
        public int Numero { get; set; }
        /// <summary>
        /// Nome do funcionário
        /// </summary>
        public string? Nome { get; set; }

        /// <summary>
        /// CPF do funcionário
        /// </summary>
        public string? CPF { get; set; }

        /// <summary>
        /// Matrícula do funcionário
        /// </summary>
        public string? Matricula { get; set; }

        /// <summary>
        /// Telefone do funcionário
        /// </summary>
        public string? Telefone { get; set; }

        /// <summary>
        /// Senha do funcionário
        /// </summary>
        public string? Senha { get; set; }

        /// <summary>
        /// Grupo do funcionário
        /// </summary>
        public int Grupo { get; set; }

        public Funcionario(int num = 0, string nome = "", string cpf = "", string matricula = "", string tel = "", string senha = "", int grupo = 0)
        {
            this.Numero = num;
            this.Nome = nome;
            this.CPF = cpf;
            this.Matricula = matricula;
            this.Telefone = tel;
            this.Senha = senha;
            this.Grupo = grupo;
        }
    }

    public class FuncionarioDAO : EntidadeBase
    {
        private readonly DbProviderFactory? factory;
        private string? Provider { get; set; }
        private string? StringConexao { get; set; }
        /// <summary>
        /// Construtor vazio da classe FuncionarioDAO
        /// </summary>
        public FuncionarioDAO()
        {

        }
        public FuncionarioDAO(string provider, string stringConexao)
        {
            this.Provider = provider;
            this.StringConexao = stringConexao;
            this.factory = DbProviderFactories.GetFactory(Provider);
        }

        public void InserirDBProvider(Funcionario funcionario)
        {
            using var conexao = factory!.CreateConnection(); // Conexão com o BD
            conexao!.ConnectionString = StringConexao; // Informa a ConnectionString, o caminho para o BD
            using var comando = factory.CreateCommand(); // Cria o comando para o BD
            comando!.Connection = conexao; // Atribui a conexão

            ConfigurarParametrosFuncionario(funcionario, comando);

            conexao.Open();

            comando.CommandText =
                @"INSERT INTO
                        TB_FUNCIONARIO
                            (
                            NOME,
                            CPF,
                            MATRICULA,
                            TELEFONE,
                            SENHA,
                            GRUPO
                            )
                        VALUES
                            (
                            @NOME,
                            @CPF,
                            @MATRICULA,
                            @TELEFONE,
                            @SENHA,
                            @GRUPO
                            )";

            var linhas = comando.ExecuteNonQuery();
        }

        public override DataTable SelectDBProvider(object funcionario)
        {
            using var conexao = factory!.CreateConnection(); // Conexão com o BD
            conexao!.ConnectionString = StringConexao; // Informa a ConnectionString, o caminho para o BD
            using var comando = factory.CreateCommand(); // Cria o comando para o BD
            comando!.Connection = conexao; // Atribui a conexão

            conexao.Open();

            Funcionario aux = (Funcionario)funcionario;

            string auxSqlFiltro = "";

            if (aux.Numero > 0)
                auxSqlFiltro = " WHERE id_funcionario = " + aux.Numero;

            comando.CommandText =
                @"SELECT
                    ID_FUNCIONARIO AS Id,
                    NOME AS Nome,
                    CPF AS CPF,
                    TELEFONE AS Telefone,
                    MATRICULA AS Matricula,
                    GRUPO AS Grupo
                FROM
                    TB_FUNCIONARIO" + auxSqlFiltro + " ORDER BY ID";

            var sdr = comando.ExecuteReader();

            DataTable linhas = new();

            linhas.Load(sdr);

            return linhas;
        }

        private static void ConfigurarParametrosFuncionario(Funcionario funcionario, DbCommand comando)
        {
            var nome = comando.CreateParameter();
            nome.ParameterName = "@NOME";
            nome.Value = funcionario.Nome;
            comando.Parameters.Add(nome);

            var cpf = comando.CreateParameter();
            cpf.ParameterName = "@CPF";
            cpf.Value = funcionario.CPF;
            comando.Parameters.Add(cpf);

            var telefone = comando.CreateParameter();
            telefone.ParameterName = "@TELEFONE";
            telefone.Value = funcionario.Telefone;
            comando.Parameters.Add(telefone);

            var matricula = comando.CreateParameter();
            matricula.ParameterName = "@MATRICULA";
            matricula.Value = funcionario.Matricula;
            comando.Parameters.Add(matricula);

            var senha = comando.CreateParameter();
            senha.ParameterName = "@SENHA";
            senha.Value = funcionario.Senha;
            comando.Parameters.Add(senha);

            var grupo = comando.CreateParameter();
            grupo.ParameterName = "@GRUPO";
            grupo.Value = funcionario.Grupo;
            comando.Parameters.Add(grupo);
        }
    }
}