using Capa_Entidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Capa_Dato
{
    public class CD_Usuarios
    {
        ConexionDB conexion = new ConexionDB();

        public List<CE_Usuarios> SelectAll()
        {
            List<CE_Usuarios> lista = new List<CE_Usuarios>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_SelectAllUsers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new CE_Usuarios
                    {
                        UserId = Convert.ToInt32(dr["userId"]),
                        UserFullName = dr["userFullName"].ToString(),
                        UserEmail = dr["userEmail"].ToString(),
                        UserPhoneNumber = dr["userPhoneNumber"].ToString(),
                        UserCountryId = Convert.ToInt32(dr["userCountryId"]),
                        UserGenderId = dr["userGenderId"].ToString(),
                        UserBirthday = Convert.ToDateTime(dr["userBirthDay"]),
                        UserCreationDate = Convert.ToDateTime(dr["userCreationDate"]),
                        UserStatusId = Convert.ToBoolean(dr["userStatusId"])
                    });
                }
            }
            return lista;
        }

        public void Insert(CE_Usuarios usuario)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_InsertUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userFullName", usuario.UserFullName);
                cmd.Parameters.AddWithValue("@userPassword", usuario.UserPassword);
                cmd.Parameters.AddWithValue("@userEmail", usuario.UserEmail);
                cmd.Parameters.AddWithValue("@userPhoneNumber", usuario.UserPhoneNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@userCountryId", usuario.UserCountryId);
                cmd.Parameters.AddWithValue("@userGenderId", usuario.UserGenderId);
                cmd.Parameters.AddWithValue("@userBirthDay", usuario.UserBirthday);
                cmd.Parameters.AddWithValue("@userCreatorId", usuario.UserCreatorId);
                cmd.Parameters.AddWithValue("@userStatusId", usuario.UserStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int userId)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_DeleteUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userId", userId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public CE_Usuarios Login(string userName, string password)
        {
            CE_Usuarios usuario = null;
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_GENERAL.sp_LoginUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@userPassword", password);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    usuario = new CE_Usuarios
                    {
                        UserId = Convert.ToInt32(dr["userId"]),
                        UserFullName = dr["userFullName"].ToString(),
                        UserName = dr["userName"].ToString(),
                        UserStatusId = Convert.ToBoolean(dr["userStatusId"])
                    };
                }
                return usuario;
            }
        }
    }
}
