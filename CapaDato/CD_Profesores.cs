using Capa_Entidad;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Capa_Dato
{
    public class CD_Profesores
    {
        ConexionDB conexion = new ConexionDB();

        public List<CE_Profesores> SelectAll()
        {
            List<CE_Profesores> lista = new List<CE_Profesores>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_SelectAllTeachers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new CE_Profesores
                    {
                        TeacherId = Convert.ToInt32(dr["teacherId"]),
                        TeacherFullName = dr["teacherFullName"].ToString(),
                        TeacherEmail = dr["teacherEmail"].ToString(),
                        TeacherPhoneNumber = dr["teacherPhoneNumber"].ToString(),
                        TeacherBirthDay = Convert.ToDateTime(dr["teacherBirthDay"]),
                        TeacherStatusId = Convert.ToInt32(dr["teacherStatusId"])
                    });
                }
            }
            return lista;
        }

        public void Insert(CE_Profesores profesor)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_InsertTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@teacherFullName", profesor.TeacherFullName);
                cmd.Parameters.AddWithValue("@teacherEmail", profesor.TeacherEmail);
                cmd.Parameters.AddWithValue("@teacherPhoneNumber", profesor.TeacherPhoneNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@teacherBirthDay", profesor.TeacherBirthDay);
                cmd.Parameters.AddWithValue("@teacherStatusId", profesor.TeacherStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(CE_Profesores profesor)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_UpdateTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@teacherId", profesor.TeacherId);
                cmd.Parameters.AddWithValue("@teacherFullName", profesor.TeacherFullName);
                cmd.Parameters.AddWithValue("@teacherEmail", profesor.TeacherEmail);
                cmd.Parameters.AddWithValue("@teacherPhoneNumber", profesor.TeacherPhoneNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@teacherBirthDay", profesor.TeacherBirthDay);
                cmd.Parameters.AddWithValue("@teacherStatusId", profesor.TeacherStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int teacherId)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_DeleteTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@teacherId", teacherId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
