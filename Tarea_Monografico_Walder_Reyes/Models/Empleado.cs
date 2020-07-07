using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_Monografico_Walder_Reyes.Models
{
    public class Empleado
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
        public int SalarioMensual { get; set; }
        public string Departamento { get; set; }
        public string NombreEmergencia{ get; set; }
        public string TelefonoEmergencia { get; set; }
        public string AFP { get; set; }
        public string ARS { get; set; }
        public string Observaciones { get; set; }

        public Empleado()
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
            SalarioMensual = 25000;
            Departamento = "Sistemas";
            NombreEmergencia = "Juan";
            TelefonoEmergencia = "809-123-2321";
            AFP ="Reservas";
            ARS = "Humano";
            Observaciones = "Excelente erstudiente.";
        }

        public Empleado(int id, string codigo, string cedula, DateTime fechaNaciemiento, DateTime fechaIngreso, string nombre, string apellido, char sexo, string estadoCivil, string ocupacion, string tipoDeSangre, string nacionalidad, string religion, string telefono, string email, string direccion, int salarioMensual, string departamento, string nombreEmergencia, string telefonoEmergencia, string aFP, string aRS, string observaciones)
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
            SalarioMensual = salarioMensual;
            Departamento = departamento ?? throw new ArgumentNullException(nameof(departamento));
            NombreEmergencia = nombreEmergencia ?? throw new ArgumentNullException(nameof(nombreEmergencia));
            TelefonoEmergencia = telefonoEmergencia ?? throw new ArgumentNullException(nameof(telefonoEmergencia));
            AFP = aFP ?? throw new ArgumentNullException(nameof(aFP));
            ARS = aRS ?? throw new ArgumentNullException(nameof(aRS));
            Observaciones = observaciones ?? throw new ArgumentNullException(nameof(observaciones));
        }
    }
}
