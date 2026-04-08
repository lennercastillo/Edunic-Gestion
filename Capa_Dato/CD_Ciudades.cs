using Capa_Entidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Capa_Dato
{
    public class CD_Ciudades
    {
        ConexionDB conexion = new ConexionDB();

        public List<CE_Ciudad> SelectAll()
        {
            List<CE_Ciudad> lista = new List<CE_Ciudad>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_SelectAllCountries", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new CE_Ciudad
                    {
                        CountryId = Convert.ToInt32(dr["countryId"]),
                        CountryName = dr["countryName"].ToString(),
                        CountryCode = dr["countryCode"].ToString(),
                        CountryStatusId = Convert.ToInt32(dr["countryStatusId"])
                    });
                }
            }
            return lista;
        }

        public void Insert(CE_Ciudad ciudad)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_InsertCountry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@countryName", ciudad.CountryName);
                cmd.Parameters.AddWithValue("@countryCode", ciudad.CountryCode);
                cmd.Parameters.AddWithValue("@countryStatusId", ciudad.CountryStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int countryId)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_DeleteCountry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@countryId", countryId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
