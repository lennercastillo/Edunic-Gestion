using Capa_Dato;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Negocio
{
    public class CN_Registros
    {
        CD_Registros datos = new CD_Registros();

        public List<CE_Registros> SelectAll()
        {
            return datos.SelectAll();
        }

        public void Insert(CE_Registros registro)
        {
            if (registro.RegistrationStudentId <= 0)
                throw new Exception("Debe seleccionar un estudiante válido.");

            if (registro.RegistrationCourseId <= 0)
                throw new Exception("Debe seleccionar un curso válido.");

            datos.Insert(registro);
        }

        public void Update(CE_Registros registro)
        {
            if (registro.RegistrationId <= 0)
                throw new Exception("El registro no es válido.");

            datos.Update(registro);
        }

        public void Delete(int registrationId)
        {
            if (registrationId <= 0)
                throw new Exception("El registro no es válido.");

            datos.Delete(registrationId);
        }
    }
}
