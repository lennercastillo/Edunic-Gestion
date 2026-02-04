using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Capa_Dato
{
    public class CD_Conexion
    {

        private string connection = "";

        public SqlConnection Abrir_conexion() 
        {

            var conexion = new SqlConnection(connection);
            if (conexion.State == System.Data.ConnectionState.Closed) 
            {
                conexion.Open();
            }

            return conexion;


        
        
        }

        public SqlConnection Cerrar_conexion()
        {
            var conexion = new SqlConnection(connection);
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }

            return conexion;

        }
    }
}
