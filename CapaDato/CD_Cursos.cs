using Capa_Entidad;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Capa_Dato
{
    public class CD_Cursos
    {
        ConexionDB conexion = new ConexionDB();

        public List<CE_Cursos> SelectAll()
        {
            List<CE_Cursos> lista = new List<CE_Cursos>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_SelectAllCourses", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new CE_Cursos
                    {
                        CourseId = Convert.ToInt32(dr["courseId"]),
                        CourseName = dr["courseName"].ToString(),
                        CourseDescription = dr["courseDescription"].ToString(),
                        CourseCreationDate = Convert.ToDateTime(dr["courseCreationDate"]),
                        CourseStatusId = Convert.ToInt32(dr["courseStatusId"])
                    });
                }
            }
            return lista;
        }

        public void Insert(CE_Cursos curso)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_InsertCourse", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@courseName", curso.CourseName);
                cmd.Parameters.AddWithValue("@courseDescription", curso.CourseDescription);
                cmd.Parameters.AddWithValue("@courseStatusId", curso.CourseStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(CE_Cursos curso)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_UpdateCourse", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@courseId", curso.CourseId);
                cmd.Parameters.AddWithValue("@courseName", curso.CourseName);
                cmd.Parameters.AddWithValue("@courseDescription", curso.CourseDescription);
                cmd.Parameters.AddWithValue("@courseStatusId", curso.CourseStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int courseId)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_DeleteCourse", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@courseId", courseId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
