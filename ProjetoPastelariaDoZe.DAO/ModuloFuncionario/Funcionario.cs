using ProjetoPastelariaDoZe.DAO.Arquivamento;
using ProjetoPastelariaDoZe.DAO.Compartilhado;
using System.Data;
using System.Data.Common;

namespace ProjetoPastelariaDoZe.DAO.ModuloFuncionario
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
            Numero = num;
            Nome = nome;
            CPF = cpf;
            Matricula = matricula;
            Telefone = tel;
            Senha = senha;
            Grupo = grupo;
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
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public void InserirDBProvider(Funcionario funcionario)
        {
            using var conexao = factory!.CreateConnection(); // Conexão com o BD
            conexao!.ConnectionString = StringConexao; // Informa a ConnectionString, o caminho para o BD
            using var comando = factory.CreateCommand(); // Cria o comando para o BD
            comando!.Connection = conexao; // Atribui a conexão

            ConfigurarParametrosInserir(funcionario, comando);

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

            ClassLog.SalvaLog("SQL", 0, "Inserção de funcionário", comando);
        }

        public void EditarDBProvider(Funcionario funcionario)
        {
            using var conexao = factory!.CreateConnection(); // Conexão com o BD
            conexao!.ConnectionString = StringConexao; // Informa a ConnectionString, o caminho para o BD
            using var comando = factory.CreateCommand(); // Cria o comando para o BD
            comando!.Connection = conexao; // Atribui a conexão

            ConfigurarParametrosEditar(funcionario, comando);

            conexao.Open();

            comando.CommandText =
                @"UPDATE TB_FUNCIONARIO
                        SET
                            NOME = @NOME,
                            CPF = @CPF,
                            MATRICULA = @MATRICULA,
                            TELEFONE = @TELEFONE,
                            GRUPO = @GRUPO
                        WHERE
                            ID_FUNCIONARIO = @IDFUNCIONARIO";

            var linhas = comando.ExecuteNonQuery();

            ClassLog.SalvaLog("SQL", 0, "Edição de funcionário", comando);
        }
        public void ExcluirDBProvider(Funcionario funcionario)
        {
            using var conexao = factory!.CreateConnection(); // Conexão com o BD
            conexao!.ConnectionString = StringConexao; // Informa a ConnectionString, o caminho para o BD
            using var comando = factory.CreateCommand(); // Cria o comando para o BD
            comando!.Connection = conexao; // Atribui a conexão

            ConfigurarParametrosExcluir(funcionario, comando);

            conexao.Open();

            comando.CommandText =
                @"DELETE 
                    FROM TB_FUNCIONARIO
                    WHERE ID_FUNCIONARIO = @IDFUNCIONARIO";
            var linhas = comando.ExecuteNonQuery();

            ClassLog.SalvaLog("SQL", 0, "Exclusão de funcionário", comando);
        }

        private static void ConfigurarParametrosInserir(Funcionario funcionario, DbCommand comando)
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

        private void ConfigurarParametrosEditar(Funcionario funcionario, DbCommand comando)
        {
            var id = comando.CreateParameter();
            id.ParameterName = "@IDFUNCIONARIO";
            id.Value = funcionario.Numero;
            comando.Parameters.Add(id);

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

            var grupo = comando.CreateParameter();
            grupo.ParameterName = "@GRUPO";
            grupo.Value = funcionario.Grupo;
            comando.Parameters.Add(grupo);
        }

        private void ConfigurarParametrosExcluir(Funcionario funcionario, DbCommand comando)
        {
            var id = comando.CreateParameter();
            id.ParameterName = "@IDFUNCIONARIO";
            id.Value = funcionario.Numero;
            comando.Parameters.Add(id);
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

            if (aux.Nome != null)
            {
                if (aux.Nome!.Length > 0)
                    auxSqlFiltro = " WHERE NOME like '%" + aux.Nome + "%' ";
            }

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

        public DataTable ValidaLogin(Funcionario funcionario)
        {
            using var conexao = factory!.CreateConnection(); // Conexão com o BD
            conexao!.ConnectionString = StringConexao; // Informa a ConnectionString, o caminho para o BD
            using var comando = factory.CreateCommand(); // Cria o comando para o BD
            comando!.Connection = conexao; // Atribui a conexão

            var cpf = comando.CreateParameter();
            cpf.ParameterName = "@CPF";
            cpf.Value = funcionario.CPF;
            comando.Parameters.Add(cpf);

            var senha = comando.CreateParameter();
            senha.ParameterName = "@SENHA";
            senha.Value = funcionario.Senha;
            comando.Parameters.Add(senha);

            conexao.Open();

            comando.CommandText =
                @"SELECT
                        ID_FUNCIONARIO AS ID,
                        NOME AS NOME,
                        CPF AS CPF,
                        TELEFONE AS TELEFONE,
                        MATRICULA AS MATRICULA,
                        GRUPO AS GRUPO
                    FROM
                        TB_FUNCIONARIO
                    WHERE
                        CPF = @CPF AND SENHA = @SENHA";

            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);

            return linhas;

        }
    }
}