using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Capa_Dato
{
    public class ConexionDB
    {
        private string cadenaConexion = "Data Source=LAPTOP\\MSSQLSERVER01;Initial Catalog=DB_ACADEMYGESTION;Integrated Security=True;Trust Server Certificate=True";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
