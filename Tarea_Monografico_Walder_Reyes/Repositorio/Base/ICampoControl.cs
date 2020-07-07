using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_Monografico_Walder_Reyes.Controllers.Base
{
    public interface ICampoControl
    {
        DateTime Creado { get; set; }
        DateTime Modificado { get; set; }
        bool Inactivo { get; set; }


    }
}
