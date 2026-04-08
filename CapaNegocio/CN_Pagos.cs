using Capa_Dato;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Negocio
{
    public class CN_Pagos
    {
        CD_Pagos datos = new CD_Pagos();

        public List<CE_Pagos> SelectAll()
        {
            return datos.SelectAll();
        }

        public void Insert(CE_Pagos pago)
        {
            if (pago.PaymentStudentId <= 0)
                throw new Exception("Debe seleccionar un estudiante válido.");

            if (pago.PaymentAmount <= 0)
                throw new Exception("El monto del pago debe ser mayor a 0.");

            datos.Insert(pago);
        }

        public void Update(CE_Pagos pago)
        {
            if (pago.PaymentId <= 0)
                throw new Exception("El pago no es válido.");

            if (pago.PaymentAmount <= 0)
                throw new Exception("El monto del pago debe ser mayor a 0.");

            datos.Update(pago);
        }
        
        public void Delete(int paymentId)
        {
            if (paymentId <= 0)
                throw new Exception("El pago no es válido.");

            datos.Delete(paymentId);
        }
    }
}
