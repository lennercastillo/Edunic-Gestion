using Capa_Dato;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Negocio
{
    public class CN_Cursos
    {
        CD_Cursos datos = new CD_Cursos();

        public List<CE_Cursos> SelectAll()
        {
            return datos.SelectAll();
        }

        public void Insert(CE_Cursos curso)
        {
            if (string.IsNullOrEmpty(curso.CourseName))
                throw new Exception("El nombre del curso es obligatorio.");

            if (string.IsNullOrEmpty(curso.CourseDescription))
                throw new Exception("La descripción del curso es obligatoria.");

            datos.Insert(curso);
        }

        public void Update(CE_Cursos curso)
        {
            if (string.IsNullOrEmpty(curso.CourseName))
                throw new Exception("El nombre del curso es obligatorio.");

            if (string.IsNullOrEmpty(curso.CourseDescription))
                throw new Exception("La descripción del curso es obligatoria.");

            datos.Update(curso);
        }

        public void Delete(int courseId)
        {
            if (courseId <= 0)
                throw new Exception("El curso no es válido.");

            datos.Delete(courseId);
        }
    }
}
