using Capa_Entidad;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Capa_Dato
{
    public class CD_Horarios
    {
        ConexionDB conexion = new ConexionDB();

        public List<CE_Horarios> SelectAll()
        {
            List<CE_Horarios> lista = new List<CE_Horarios>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_SelectAllSchedules", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new CE_Horarios
                    {
                        ScheduleId = Convert.ToInt32(dr["scheduleId"]),
                        ScheduleCourseId = Convert.ToInt32(dr["scheduleCourseId"]),
                        ScheduleTeacherId = Convert.ToInt32(dr["scheduleTeacherId"]),
                        ScheduleClassroomId = dr["scheduleClassroomId"] == DBNull.Value ? (int?)null : Convert.ToInt32(dr["scheduleClassroomId"]),
                        ScheduleStartDate = Convert.ToDateTime(dr["scheduleStartDate"]),
                        ScheduleEndDate = Convert.ToDateTime(dr["scheduleEndDate"]),
                        ScheduleStatusId = Convert.ToInt32(dr["scheduleStatusId"]),
                        CourseName = dr["courseName"].ToString(),
                        TeacherFullName = dr["teacherFullName"].ToString(),
                        ClassroomName = dr["classroomName"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Insert(CE_Horarios horario)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_InsertSchedule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@scheduleCourseId", horario.ScheduleCourseId);
                cmd.Parameters.AddWithValue("@scheduleTeacherId", horario.ScheduleTeacherId);
                cmd.Parameters.AddWithValue("@scheduleClassroomId", horario.ScheduleClassroomId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@scheduleStartDate", horario.ScheduleStartDate);
                cmd.Parameters.AddWithValue("@scheduleEndDate", horario.ScheduleEndDate);
                cmd.Parameters.AddWithValue("@scheduleStatusId", horario.ScheduleStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(CE_Horarios horario)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_UpdateSchedule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@scheduleId", horario.ScheduleId);
                cmd.Parameters.AddWithValue("@scheduleCourseId", horario.ScheduleCourseId);
                cmd.Parameters.AddWithValue("@scheduleTeacherId", horario.ScheduleTeacherId);
                cmd.Parameters.AddWithValue("@scheduleClassroomId", horario.ScheduleClassroomId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@scheduleStartDate", horario.ScheduleStartDate);
                cmd.Parameters.AddWithValue("@scheduleEndDate", horario.ScheduleEndDate);
                cmd.Parameters.AddWithValue("@scheduleStatusId", horario.ScheduleStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int scheduleId)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_DeleteSchedule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@scheduleId", scheduleId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
