using Capa_Dato;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Negocio
{
    public class CN_Calificaciones
    {
        CD_Calificaciones datos = new CD_Calificaciones();

        public List<CE_Calificaciones> SelectAll()
        {
            return datos.SelectAll();
        }

        public void Insert(CE_Calificaciones calificacion)
        {
            if (calificacion.CalificationRegistrationId <= 0)
                throw new Exception("Debe seleccionar un registro válido.");

            if (calificacion.CalificationScore < 0 || calificacion.CalificationScore > 100)
                throw new Exception("La calificación debe estar entre 0 y 100.");

            datos.Insert(calificacion);
        }

        public void Update(CE_Calificaciones calificacion)
        {
            if (calificacion.CalificationId <= 0)
                throw new Exception("La calificación no es válida.");

            if (calificacion.CalificationScore < 0 || calificacion.CalificationScore > 100)
                throw new Exception("La calificación debe estar entre 0 y 100.");

            datos.Update(calificacion);
        }

        public void Delete(int calificationId)
        {
            if (calificationId <= 0)
                throw new Exception("La calificación no es válida.");

            datos.Delete(calificationId);
        }
    }
}
