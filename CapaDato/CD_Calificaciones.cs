using Capa_Entidad;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Capa_Dato
{
    public class CD_Calificaciones
    {
        ConexionDB conexion = new ConexionDB();

        public List<CE_Calificaciones> SelectAll()
        {
            List<CE_Calificaciones> lista = new List<CE_Calificaciones>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_SelectAllCalifications", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new CE_Calificaciones
                    {
                        CalificationId = Convert.ToInt32(dr["calificationId"]),
                        CalificationRegistrationId = Convert.ToInt32(dr["calificationRegistrationId"]),
                        CalificationScore = Convert.ToDecimal(dr["calificationScore"]),
                        CalificationDate = Convert.ToDateTime(dr["calificationDate"]),
                        CalificationStatusId = Convert.ToInt32(dr["calificationStatusId"]),
                        StudentFullName = dr["studentFullName"].ToString(),
                        CourseName = dr["courseName"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Insert(CE_Calificaciones calificacion)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_InsertCalification", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@calificationRegistrationId", calificacion.CalificationRegistrationId);
                cmd.Parameters.AddWithValue("@calificationScore", calificacion.CalificationScore);
                cmd.Parameters.AddWithValue("@calificationStatusId", calificacion.CalificationStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(CE_Calificaciones calificacion)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_UpdateCalificationScore", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@calificationId", calificacion.CalificationId);
                cmd.Parameters.AddWithValue("@newScore", calificacion.CalificationScore);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int calificationId)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_DeleteCalification", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@calificationId", calificationId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
