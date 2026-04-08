using Capa_Dato;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Negocio
{
    public class CN_Aulas
    {
        CD_Aulas datos = new CD_Aulas();

        public List<CE_Aulas> SelectAll()
        {
            return datos.SelectAll();
        }

        public void Insert(CE_Aulas aula)
        {
            if (string.IsNullOrEmpty(aula.ClassroomName))
                throw new Exception("El nombre del aula es obligatorio.");

            if (aula.ClassroomCapacity <= 0)
                throw new Exception("La capacidad del aula debe ser mayor a 0.");

            datos.Insert(aula);
        }

        public void Update(CE_Aulas aula)
        {
            if (aula.ClassroomId <= 0)
                throw new Exception("El aula no es válida.");

            if (string.IsNullOrEmpty(aula.ClassroomName))
                throw new Exception("El nombre del aula es obligatorio.");

            if (aula.ClassroomCapacity <= 0)
                throw new Exception("La capacidad del aula debe ser mayor a 0.");

            datos.Update(aula);
        }

        public void Delete(int classroomId)
        {
            if (classroomId <= 0)
                throw new Exception("El aula no es válida.");

            datos.Delete(classroomId);
        }
    }
}
