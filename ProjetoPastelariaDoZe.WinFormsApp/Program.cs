using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using System.Configuration;
using System.Data.Common;
using System.Globalization;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Abertura para BD
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);
            #endregion
            
            string? aux = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") : ""; // ? > Pode ser null |

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(aux!); // var! > Pode ser null
            Thread.CurrentThread.CurrentCulture = new CultureInfo(aux!);


            ApplicationConfiguration.Initialize();
            Funcoes.ValidaConexaoDB();
            Application.Run(new FormInicio());
        }
    }
}