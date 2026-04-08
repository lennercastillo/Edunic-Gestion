using Capa_Dato;
using System;
using Capa_Entidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Estados
    {
        CD_Estados datos = new CD_Estados();

        public List<CE_Estados> SelectAll() 
        {
            return datos.SelectAll();
        }
    }
}
