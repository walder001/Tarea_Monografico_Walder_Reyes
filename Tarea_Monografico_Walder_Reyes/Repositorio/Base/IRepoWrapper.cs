using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_Monografico_Walder_Reyes.Repositorio.Base
{
    public interface IRepoWrapper
    {
        //Solo colocamos las propiedades tipo get.
        IEmpleadoRepo Empleado { get; }
        IEstudianteRepo Estudiante { get; }

        IProfesorRepo Profesor { get; }


    }
}
