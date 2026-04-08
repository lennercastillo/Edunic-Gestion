using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidad
{
    public class CE_Calificaciones
    {
        public int CalificationId { get; set; }
        public int CalificationRegistrationId { get; set; }
        public decimal CalificationScore { get; set; }
        public DateTime CalificationDate { get; set; }
        public int CalificationStatusId { get; set; }

        
        public string StudentFullName { get; set; }
        public string CourseName { get; set; }
    }
}
