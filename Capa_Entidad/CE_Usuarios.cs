using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Capa_Entidad
{
    public class CE_Usuarios
    {

        public int UserId { get; set; }
        public string? UserFullName { get; set; }

        public string? UserPassword { get; set; }

        public string? UserEmail { get; set; }

        public string? UserPhoneNumber { get; set; }

        public int UserCountryId { get; set; }

        public string? UserGenderId { get; set; }

        public DateTime UserBirthday { get; set; }

        public int UserCreatorId { get; set; }

        public DateTime UserCreationDate { get; set; }

        public int UserModificatorId { get; set; }

        public DateTime UserModificationDate { get; set; }

        public bool UserStatusId { get; set; }

    
    }
}
