using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidad
{
    public class CE_Registros
    {
        public int RegistrationId { get; set; }
        public int RegistrationStudentId { get; set; }
        public int RegistrationCourseId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int RegistrationStatusId { get; set; }

        
        public string StudentFullName { get; set; }
        public string CourseName { get; set; }
    }
}
