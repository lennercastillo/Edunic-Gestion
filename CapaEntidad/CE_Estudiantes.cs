using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidad
{
    public class CE_Estudiantes
    {
        public int StudentId { get; set; }
        public string StudentFullName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhoneNumber { get; set; }
        public DateTime StudentBirthDay { get; set; }
        public DateTime StudentCreationDate { get; set; }
        public DateTime? StudentModificationDate { get; set; }
        public int StudentStatusId { get; set; }
    }
}
