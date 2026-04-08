using Capa_Entidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Capa_Dato
{
    public class CD_Estados
    {
        ConexionDB conexion = new ConexionDB();

        public List<CE_Estados> SelectAll()
        {
            List<CE_Estados> lista = new List<CE_Estados>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_SelectAllStatus", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new CE_Estados
                    {
                        StatusId = Convert.ToInt32(dr["statusId"]),
                        StatusName = dr["statusName"].ToString(),
                        StatusDescription = dr["statusDescription"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}

