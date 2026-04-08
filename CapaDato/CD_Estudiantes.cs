using Capa_Entidad;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Capa_Dato
{
    public class CD_Estudiantes
    {
        ConexionDB conexion = new ConexionDB();

        public List<CE_Estudiantes> SelectAll()
        {
            List<CE_Estudiantes> lista = new List<CE_Estudiantes>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_SelectAllStudents", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new CE_Estudiantes
                    {
                        StudentId = Convert.ToInt32(dr["studentId"]),
                        StudentFullName = dr["studentFullName"].ToString(),
                        StudentEmail = dr["studentEmail"].ToString(),
                        StudentPhoneNumber = dr["studentPhoneNumber"].ToString(),
                        StudentBirthDay = Convert.ToDateTime(dr["studentBirthDay"]),
                        StudentStatusId = Convert.ToInt32(dr["studentStatusId"])
                    });
                }
            }
            return lista;
        }

        public void Insert(CE_Estudiantes estudiante)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_InsertStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studentFullName", estudiante.StudentFullName);
                cmd.Parameters.AddWithValue("@studentEmail", estudiante.StudentEmail);
                cmd.Parameters.AddWithValue("@studentPhoneNumber", estudiante.StudentPhoneNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@studentBirthDay", estudiante.StudentBirthDay);
                cmd.Parameters.AddWithValue("@studentStatusId", estudiante.StudentStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(CE_Estudiantes estudiante)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_UpdateStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studentId", estudiante.StudentId);
                cmd.Parameters.AddWithValue("@studentFullName", estudiante.StudentFullName);
                cmd.Parameters.AddWithValue("@studentEmail", estudiante.StudentEmail);
                cmd.Parameters.AddWithValue("@studentPhoneNumber", estudiante.StudentPhoneNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@studentBirthDay", estudiante.StudentBirthDay);
                cmd.Parameters.AddWithValue("@studentStatusId", estudiante.StudentStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int studentId)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_DeleteStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studentId", studentId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}


