using Capa_Dato;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Negocio
{
    public class CN_Horarios
    {
        CD_Horarios datos = new CD_Horarios();

        public List<CE_Horarios> SelectAll()
        {
            return datos.SelectAll();
        }

        public void Insert(CE_Horarios horario)
        {
            if (horario.ScheduleCourseId <= 0)
                throw new Exception("Debe seleccionar un curso válido.");

            if (horario.ScheduleTeacherId <= 0)
                throw new Exception("Debe seleccionar un profesor válido.");

            if (horario.ScheduleStartDate == DateTime.MinValue)
                throw new Exception("La fecha de inicio es obligatoria.");

            if (horario.ScheduleEndDate == DateTime.MinValue)
                throw new Exception("La fecha de fin es obligatoria.");

            if (horario.ScheduleEndDate <= horario.ScheduleStartDate)
                throw new Exception("La fecha de fin debe ser mayor a la fecha de inicio.");

            datos.Insert(horario);
        }

        public void Update(CE_Horarios horario)
        {
            if (horario.ScheduleId <= 0)
                throw new Exception("El horario no es válido.");

            if (horario.ScheduleEndDate <= horario.ScheduleStartDate)
                throw new Exception("La fecha de fin debe ser mayor a la fecha de inicio.");

            datos.Update(horario);
        }

        public void Delete(int scheduleId)
        {
            if (scheduleId <= 0)
                throw new Exception("El horario no es válido.");

            datos.Delete(scheduleId);
        }
    }
}
