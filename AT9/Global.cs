using System.Data.SqlClient;

namespace AT9
{
    class Global
    {
        public SqlConnection
          banque_connexion = new SqlConnection(@"data source = .\SQLEXPRESS;database=banque;Integrated Security=True");

    }
}
