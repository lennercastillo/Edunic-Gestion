using Capa_Entidad;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Capa_Dato
{
    public class CD_Registros
    {
        ConexionDB conexion = new ConexionDB();

        public List<CE_Registros> SelectAll()
        {
            List<CE_Registros> lista = new List<CE_Registros>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_SelectAllRegistrations", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new CE_Registros
                    {
                        RegistrationId = Convert.ToInt32(dr["registrationId"]),
                        RegistrationStudentId = Convert.ToInt32(dr["registrationStudentId"]),
                        RegistrationCourseId = Convert.ToInt32(dr["registrationCourseId"]),
                        RegistrationDate = Convert.ToDateTime(dr["registrationDate"]),
                        RegistrationStatusId = Convert.ToInt32(dr["registrationStatusId"]),
                        StudentFullName = dr["studentFullName"].ToString(),
                        CourseName = dr["courseName"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Insert(CE_Registros matricula)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_InsertRegistration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@registrationStudentId", matricula.RegistrationStudentId);
                cmd.Parameters.AddWithValue("@registrationCourseId", matricula.RegistrationCourseId);
                cmd.Parameters.AddWithValue("@registrationStatusId", matricula.RegistrationStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(CE_Registros matricula)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_UpdateRegistrationStatus", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@registrationId", matricula.RegistrationId);
                cmd.Parameters.AddWithValue("@newStatusId", matricula.RegistrationStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int registrationId)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_DeleteRegistration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@registrationId", registrationId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
