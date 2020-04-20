using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.ejercicio2
{
    class Datos
    {
        public SqlConnection LeerCadena()
        {
            SqlConnection connection = new SqlConnection("Data Source= sql5047.site4now.net; Initial Catalog=DB_A5A766_sebastiantecsup; User ID=DB_A5A766_sebastiantecsup_admin; Password=T3csup3720;");
            return connection;
        }

        public SqlDataReader ListaClientes()
        {
            try
            {
                SqlConnection cn = LeerCadena();
                SqlCommand cmd = new SqlCommand("USP_ListaCLientes");
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
