using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorRegistroDeAlumnosYDocentes.WF
{
    public abstract class Persona : IImprimible
    {
        public string Rol { get; set; }
        public string Matricula { get; set; }
        public string NombreCompleto { get; set; }
        public string Carrera { get; set; }
        public string Semestre { get; set; }
        public string Correo { get; set; }

        public Persona(string rol, string matricula, string nombreCompleto, string carrera, string semestre, string correo)
        {
            Rol = rol;
            Matricula = matricula;
            NombreCompleto = nombreCompleto;
            Carrera = carrera;
            Semestre = semestre;
            Correo = correo;
        }

        public abstract string CalcularAsistencia();

        public abstract string GenerarFicha();

        public override string ToString()
        {
            return $"[{Rol}] {Matricula} - {NombreCompleto} (Carrera: {Carrera}, Semestre: {Semestre}, Correo: {Correo})";
        }
    }
}
