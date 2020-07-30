using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_Monografico_Walder_Reyes.Controllers.Base;
using Tarea_Monografico_Walder_Reyes.Models;
using Tarea_Monografico_Walder_Reyes.Repositorio.Base;


namespace Tarea_Monografico_Walder_Reyes.Repositorio
{
    public class ProfesorRepo : RepoBase<Profesor>, IProfesorRepo
    {
        private readonly AppDbContext _context;
        public ProfesorRepo(AppDbContext context) : base(context)
        {
            _context = context;

        }
    }
}
