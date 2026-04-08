using Capa_Dato;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Negocio
{
    public class CN_Profesores
    {
        
            CD_Profesores datos = new CD_Profesores();

            public List<CE_Profesores> SelectAll()
            {
                return datos.SelectAll();
            }

            public void Insert(CE_Profesores profesor)
            {
                if (string.IsNullOrEmpty(profesor.TeacherFullName))
                    throw new Exception("El nombre del profesor es obligatorio.");

                if (string.IsNullOrEmpty(profesor.TeacherEmail))
                    throw new Exception("El email del profesor es obligatorio.");

                if (!profesor.TeacherEmail.Contains("@"))
                    throw new Exception("El email no tiene un formato válido.");

                if (profesor.TeacherBirthDay == DateTime.MinValue)
                    throw new Exception("La fecha de nacimiento es obligatoria.");

                datos.Insert(profesor);
            }

            public void Update(CE_Profesores profesor)
            {
                if (string.IsNullOrEmpty(profesor.TeacherFullName))
                    throw new Exception("El nombre del profesor es obligatorio.");

                if (string.IsNullOrEmpty(profesor.TeacherEmail))
                    throw new Exception("El email del profesor es obligatorio.");

                if (!profesor.TeacherEmail.Contains("@"))
                    throw new Exception("El email no tiene un formato válido.");

                datos.Update(profesor);
            }

            public void Delete(int teacherId)
            {
                if (teacherId <= 0)
                    throw new Exception("El profesor no es válido.");

                datos.Delete(teacherId);
            }
        }
}
