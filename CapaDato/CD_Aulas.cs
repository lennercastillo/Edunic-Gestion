using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Capa_Dato
{
    public class CD_Aulas
    {
        ConexionDB conexion = new ConexionDB();

        public List<CE_Aulas> SelectAll()
        {
            List<CE_Aulas> lista = new List<CE_Aulas>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_SelectAllClassrooms", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new CE_Aulas
                    {
                        ClassroomId = Convert.ToInt32(dr["classroomId"]),
                        ClassroomName = dr["classroomName"].ToString(),
                        ClassroomCapacity = Convert.ToInt32(dr["classroomCapacity"]),
                        ClassroomStatusId = Convert.ToInt32(dr["classroomStatusId"])
                    });
                }
            }
            return lista;
        }

        public void Insert(CE_Aulas aula)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_InsertClassroom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@classroomName", aula.ClassroomName);
                cmd.Parameters.AddWithValue("@classroomCapacity", aula.ClassroomCapacity);
                cmd.Parameters.AddWithValue("@classroomStatusId", aula.ClassroomStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(CE_Aulas aula)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_UpdateClassroom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@classroomId", aula.ClassroomId);
                cmd.Parameters.AddWithValue("@classroomName", aula.ClassroomName);
                cmd.Parameters.AddWithValue("@classroomCapacity", aula.ClassroomCapacity);
                cmd.Parameters.AddWithValue("@classroomStatusId", aula.ClassroomStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int classroomId)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_DeleteClassroom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@classroomId", classroomId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
