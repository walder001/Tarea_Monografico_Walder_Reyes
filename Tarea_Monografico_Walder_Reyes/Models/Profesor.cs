using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tarea_Monografico_Walder_Reyes.Controllers.Base;

namespace Tarea_Monografico_Walder_Reyes.Models
{
    public class Profesor 
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNaciemiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Ocupacion { get; set; }
        public string TipoDeSangre { get; set; }
        public string Nacionalidad { get; set; }
        public string Religion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Carrera { get; set; }
        public string TituloCarreraGrado { get; set; }
        public string MayorGradoAcademico { get; set; }
        public string CategoriaProfesoral { get; set; }
        public string Facultad { get; set; }
        public string AsignaturaImpartidas { get; set; }
        public string Observaciones { get; set; }
      /*  public DateTime Creado { get; set; }
        public DateTime Modificado { get; set; }

        public bool Inactivo { get; set; }*/

        public Profesor()
        {
            Id = 1;
            Codigo = "0929";
            Cedula = "402-2846058-6";
            FechaNaciemiento = DateTime.Now;
            FechaIngreso = DateTime.Now;
            Nombre = "Walder";
            Apellido = "Reyes";
            Sexo = 'M';
            EstadoCivil = "Soltero";
            Ocupacion = "Estudiente";
            TipoDeSangre = "O+";
            Nacionalidad = "Domicana";
            Religion = "Catolica";
            Telefono = "809-123-1232";
            Email = "walderreyes34@gmail.com";
            Direccion = "Ensanche Libertad";
            Carrera = "Sistemas";
            TituloCarreraGrado = "Ingeniero";
            MayorGradoAcademico = "Ingenieria";
            CategoriaProfesoral = "Permanente";
            Facultad = "Ingenieria";
            AsignaturaImpartidas = "Programacion";
            Observaciones = "Excelente erstudiente.";


    }

        public Profesor(int id, string codigo, string cedula, DateTime fechaNaciemiento, DateTime fechaIngreso, string nombre, string apellido, char sexo, string estadoCivil, string ocupacion, string tipoDeSangre, string nacionalidad, string religion, string telefono, string email, string direccion, string carrera, string tituloCarreraGrado, string mayorGradoAcademico, string categoriaProfesoral, string facultad, string asignaturaImpartidas, string observaciones)
        {
            Id = id;
            Codigo = codigo ?? throw new ArgumentNullException(nameof(codigo));
            Cedula = cedula ?? throw new ArgumentNullException(nameof(cedula));
            FechaNaciemiento = fechaNaciemiento;
            FechaIngreso = fechaIngreso;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            Sexo = sexo;
            EstadoCivil = estadoCivil ?? throw new ArgumentNullException(nameof(estadoCivil));
            Ocupacion = ocupacion ?? throw new ArgumentNullException(nameof(ocupacion));
            TipoDeSangre = tipoDeSangre ?? throw new ArgumentNullException(nameof(tipoDeSangre));
            Nacionalidad = nacionalidad ?? throw new ArgumentNullException(nameof(nacionalidad));
            Religion = religion ?? throw new ArgumentNullException(nameof(religion));
            Telefono = telefono ?? throw new ArgumentNullException(nameof(telefono));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            Carrera = carrera ?? throw new ArgumentNullException(nameof(carrera));
            TituloCarreraGrado = tituloCarreraGrado ?? throw new ArgumentNullException(nameof(tituloCarreraGrado));
            MayorGradoAcademico = mayorGradoAcademico ?? throw new ArgumentNullException(nameof(mayorGradoAcademico));
            CategoriaProfesoral = categoriaProfesoral ?? throw new ArgumentNullException(nameof(categoriaProfesoral));
            Facultad = facultad ?? throw new ArgumentNullException(nameof(facultad));
            AsignaturaImpartidas = asignaturaImpartidas ?? throw new ArgumentNullException(nameof(asignaturaImpartidas));
            Observaciones = observaciones ?? throw new ArgumentNullException(nameof(observaciones));
        }
    }
}
