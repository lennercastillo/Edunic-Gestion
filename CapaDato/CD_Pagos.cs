using Capa_Entidad;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Capa_Dato
{
    public class CD_Pagos
    {
        ConexionDB conexion = new ConexionDB();

        public List<CE_Pagos> SelectAll()
        {
            List<CE_Pagos> lista = new List<CE_Pagos>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_SelectAllPayments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new CE_Pagos
                    {
                        PaymentId = Convert.ToInt32(dr["paymentId"]),
                        PaymentAmount = Convert.ToDecimal(dr["paymentAmount"]),
                        PaymentDate = Convert.ToDateTime(dr["paymentDate"]),
                        PaymentStatusId = Convert.ToInt32(dr["paymentStatusId"]),
                        StudentFullName = dr["studentFullName"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Insert(CE_Pagos pago)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_InsertPayment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@paymentStudentId", pago.PaymentStudentId);
                cmd.Parameters.AddWithValue("@paymentAmount", pago.PaymentAmount);
                cmd.Parameters.AddWithValue("@paymentStatusId", pago.PaymentStatusId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(CE_Pagos pago)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_UpdatePayment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@paymentId", pago.PaymentId);
                cmd.Parameters.AddWithValue("@newAmount", pago.PaymentAmount);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int paymentId)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("AGM_CATALOGS.sp_DeletePayment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@paymentId", paymentId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
