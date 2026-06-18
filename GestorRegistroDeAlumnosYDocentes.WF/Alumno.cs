using System;

namespace GestorRegistroDeAlumnosYDocentes.WF
{
    public class Alumno : Persona
    {
        public string Promedio { get; set; }

        public Alumno(string matricula, string nombre, string carrera, string semestre, string correo, string promedio = "N/A") 
            : base("Alumno", matricula, nombre, carrera, semestre, correo)
        {
            Promedio = promedio;
        }

        public override string CalcularAsistencia()
        {
            return "Asistencia calculada en base a créditos y materias inscritas (Requisito: 85%).";
        }

        public override string GenerarFicha()
        {
            return $"FICHA DE ALUMNO\nMatrícula: {Matricula}\nNombre: {NombreCompleto}\nPromedio: {Promedio}";
        }
    }
}
