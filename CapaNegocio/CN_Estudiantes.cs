using Capa_Dato;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Negocio
{
    public class CN_Estudiantes
    {
        CD_Estudiantes datos = new CD_Estudiantes();

        public List<CE_Estudiantes> SelectAll()
        {
            return datos.SelectAll();
        }

        public void Insert(CE_Estudiantes estudiante)
        {
            if (string.IsNullOrEmpty(estudiante.StudentFullName))
                throw new Exception("El nombre del estudiante es obligatorio.");

            if (string.IsNullOrEmpty(estudiante.StudentEmail))
                throw new Exception("El email del estudiante es obligatorio.");

            if (!estudiante.StudentEmail.Contains("@"))
                throw new Exception("El email no tiene un formato válido.");

            if (estudiante.StudentBirthDay == DateTime.MinValue)
                throw new Exception("La fecha de nacimiento es obligatoria.");

            datos.Insert(estudiante);
        }

        public void Update(CE_Estudiantes estudiante)
        {
            if (string.IsNullOrEmpty(estudiante.StudentFullName))
                throw new Exception("El nombre del estudiante es obligatorio.");

            if (string.IsNullOrEmpty(estudiante.StudentEmail))
                throw new Exception("El email del estudiante es obligatorio.");

            if (!estudiante.StudentEmail.Contains("@"))
                throw new Exception("El email no tiene un formato válido.");

            datos.Update(estudiante);
        }

        public void Delete(int studentId)
        {
            if (studentId <= 0)
                throw new Exception("El estudiante no es válido.");

            datos.Delete(studentId);
        }
    }
}
