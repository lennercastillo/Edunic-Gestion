using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidad
{
    public class CE_Horarios
    {
        public int ScheduleId { get; set; }
        public int ScheduleCourseId { get; set; }
        public int ScheduleTeacherId { get; set; }
        public int? ScheduleClassroomId { get; set; }
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }
        public int ScheduleStatusId { get; set; }

        
        public string CourseName { get; set; }
        public string TeacherFullName { get; set; }
        public string ClassroomName { get; set; }
    }
}
