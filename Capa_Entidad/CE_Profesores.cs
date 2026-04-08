using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidad
{
    public class CE_Profesores
    {
        public int TeacherId { get; set; }
        public string TeacherFullName { get; set; }
        public string TeacherEmail { get; set; }
        public string TeacherPhoneNumber { get; set; }
        public DateTime TeacherBirthDay { get; set; }
        public DateTime TeacherCreationDate { get; set; }
        public DateTime? TeacherModificationDate { get; set; }
        public int TeacherStatusId { get; set; }
    }
}
