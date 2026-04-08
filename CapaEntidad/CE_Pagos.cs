using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidad
{
    public class CE_Pagos
    {
        public int PaymentId { get; set; }
        public int PaymentStudentId { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentStatusId { get; set; }

        
        public string StudentFullName { get; set; }
    }
}
