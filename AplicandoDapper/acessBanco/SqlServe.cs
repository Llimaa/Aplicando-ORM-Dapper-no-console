
using System.Data.SqlClient;


namespace AplicandoDapper.acessBanco
{
    public class SqlServe
    {
       public SqlConnection ConexaoBanco()
        {
            return new SqlConnection(@"server=MARCOS-PC\SQLEXPRESS; database=Escola; User Id =root; Password=123;");
        }
    }
}
