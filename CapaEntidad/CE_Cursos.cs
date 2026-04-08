using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidad
{
    public class CE_Cursos
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public DateTime CourseCreationDate { get; set; }
        public DateTime? CourseModificationDate { get; set; }
        public int CourseStatusId { get; set; }
    }
}
