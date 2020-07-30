using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_Monografico_Walder_Reyes.Models;

namespace Tarea_Monografico_Walder_Reyes.Repositorio.Base
{
    public class RepoWrapper : IRepoWrapper
    {
        private readonly AppDbContext _repoContext;

        private IEstudianteRepo _estudiente;
        private IProfesorRepo _profesor;
        private IEmpleadoRepo _empleado;


        public RepoWrapper(AppDbContext repoContext)
        {
            _repoContext = repoContext;
        }
        public IEstudianteRepo Estudiante
        {
            get
            {
                if (_estudiente == null)
                {
                    _estudiente = new EstudienteRepo(_repoContext);
                }

                return _estudiente;
            }
        }

        //Hacer lo mismo que con Marca
        public IProfesorRepo Profesor
        {
            get
            {
                if (_profesor == null)
                {
                    _profesor = new ProfesorRepo(_repoContext);


                }

                return _profesor;
            }
        }
        public IEmpleadoRepo Empleado
        {
            get
            {
                if (_empleado == null)
                {
                    _empleado = new EmpleadoRepo(_repoContext);
                 }

                return _empleado;
            }
        }
      
    }
}
