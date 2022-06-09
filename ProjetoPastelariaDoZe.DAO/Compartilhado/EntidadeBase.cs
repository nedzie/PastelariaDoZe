using System.Data;

namespace ProjetoPastelariaDoZe.DAO.Compartilhado
{
    public class EntidadeBase
    {
        public virtual DataTable SelectDBProvider(object registro)
        {
            return null!;
        }
    }
}
