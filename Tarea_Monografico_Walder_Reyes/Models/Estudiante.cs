﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_Monografico_Walder_Reyes.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        public string Matricula { get; set; }
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
        public string NombreDePadre { get; set; }
        public string NombreDeMadre { get; set; }
        public string Direccion { get; set; }
        public string TipoColegio { get; set; }
        public string Carrera { get; set; }
        public string Observaciones { get; set; }

        public Estudiante()
        {
            Id = 1;
            Matricula = "2016-0929";
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
            NombreDePadre = "Luis";
            NombreDeMadre = "Dolores";
            Direccion = "Ensanche Libertad";
            TipoColegio = "Publico";
            Carrera = "Ingenieria en sistemas";
            Observaciones = "Excelente erstudiente.";

                
        }

        public Estudiante(int id, string matricula, string cedula, DateTime fechaNaciemiento, DateTime fechaIngreso, string nombre, string apellido, char sexo, string estadoCivil, string ocupacion, string tipoDeSangre, string nacionalidad, string religion, string telefono, string email, string nombreDePadre, string nombreDeMadre, string direccion, string tipoColegio, string carrera, string observaciones)
        {
            Id = id;
            Matricula = matricula ?? throw new ArgumentNullException(nameof(matricula));
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
            NombreDePadre = nombreDePadre ?? throw new ArgumentNullException(nameof(nombreDePadre));
            NombreDeMadre = nombreDeMadre ?? throw new ArgumentNullException(nameof(nombreDeMadre));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            TipoColegio = tipoColegio ?? throw new ArgumentNullException(nameof(tipoColegio));
            Carrera = carrera ?? throw new ArgumentNullException(nameof(carrera));
            Observaciones = observaciones ?? throw new ArgumentNullException(nameof(observaciones));
        }
    }
}
