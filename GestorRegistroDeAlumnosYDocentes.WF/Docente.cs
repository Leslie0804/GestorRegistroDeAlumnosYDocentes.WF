using System;

namespace GestorRegistroDeAlumnosYDocentes.WF
{
    public class Docente : Persona
    {
        public string Cubiculo { get; set; }

        public Docente(string matricula, string nombre, string carrera, string correo, string cubiculo = "N/A") 
            : base("Docente", matricula, nombre, carrera, "N/A", correo)
        {
            Cubiculo = cubiculo;
        }

        public override string CalcularAsistencia()
        {
            return "Asistencia calculada mediante checador biométrico de entrada y salida (Requisito: 100%).";
        }

        public override string GenerarFicha()
        {
            return $"FICHA DE DOCENTE\nNómina: {Matricula}\nNombre: {NombreCompleto}\nCubículo: {Cubiculo}";
        }
    }
}
