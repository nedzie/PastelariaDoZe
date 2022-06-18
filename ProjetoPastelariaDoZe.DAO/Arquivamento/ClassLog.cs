using System.Configuration;
using System.Data.Common;

namespace ProjetoPastelariaDoZe.DAO.Arquivamento
{
    public class ClassLog
    {
        static readonly string espacos = "  |  ";
        //Via CONTROLER
        public static void SalvaLog(string tipo, int idLogado, string log)
        {
            TextWriter arquivo = File.AppendText(ConfigurationManager.AppSettings.Get("LocalLog")!);

            arquivo.WriteLine($"{DateTime.Now}{espacos}{tipo}{espacos}{idLogado}{espacos}{log}");
            arquivo.Close();
        }

        public static void SalvaLog(string tipo, int idLogado, string log, DbCommand comando)
        {
            TextWriter arquivo = File.AppendText(ConfigurationManager.AppSettings.Get("LocalLog")!);

            string auxSql = " SQL: " + comando.CommandText + " {";
            for (int i = 0; i < comando.Parameters.Count; i++)
                auxSql += comando.Parameters[i].Value + ", ";

            auxSql += " }";

            arquivo.WriteLine($"{DateTime.Now}{espacos}{tipo}{espacos}{idLogado}{espacos}{log}{espacos}{auxSql}");
            arquivo.Close();
        }

        public static void SalvaLog(string tipo)
        {
            TextWriter arquivo = File.AppendText(ConfigurationManager.AppSettings.Get("LocalLog")!);

            arquivo.WriteLine($"{DateTime.Now}{espacos}{tipo}");
            arquivo.Close();
        }
    }
}
