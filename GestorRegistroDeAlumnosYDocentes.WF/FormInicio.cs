using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorRegistroDeAlumnosYDocentes.WF
{
    public partial class FormInicio : Form
    {
        private List<Persona> listaPersonal = new List<Persona>();

        public FormInicio()
        {
            InitializeComponent();
            cmbRol.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) || 
                string.IsNullOrWhiteSpace(txtNombre.Text) || 
                string.IsNullOrWhiteSpace(txtCarrera.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listaPersonal.Any(p => p.Matricula == txtMatricula.Text))
            {
                MessageBox.Show("La matrícula ya existe en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Persona nuevaPersona;

            if (cmbRol.SelectedItem.ToString() == "Alumno")
            {
                nuevaPersona = new Alumno(
                    txtMatricula.Text,
                    txtNombre.Text,
                    txtCarrera.Text,
                    txtSemestre.Text,
                    txtCorreo.Text
                );
            }
            else
            {
                nuevaPersona = new Docente(
                    txtMatricula.Text,
                    txtNombre.Text,
                    txtCarrera.Text,
                    txtCorreo.Text
                );
            }

            listaPersonal.Add(nuevaPersona);
            ActualizarLista();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstPersonal.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una persona de la lista para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Persona personaSeleccionada = (Persona)lstPersonal.SelectedItem;
            listaPersonal.Remove(personaSeleccionada);
            
            ActualizarLista();
        }

        private void btnProcesarSeleccionado_Click(object sender, EventArgs e)
        {
            if (lstPersonal.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar a alguien de la lista primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Recuperamos el objeto seleccionado
            Persona personaSeleccionada = (Persona)lstPersonal.SelectedItem;

            // 1. Demostración de Polimorfismo con Método Abstracto
            string asistencia = personaSeleccionada.CalcularAsistencia();

            // 2. Demostración de Polimorfismo con Interfaz (Casting)
            IImprimible imprimible = (IImprimible)personaSeleccionada;
            string ficha = imprimible.GenerarFicha();

            // Mostrar ambos resultados para comprobar el comportamiento dinámico
            MessageBox.Show($"{ficha}\n\n--- CONTROL DE ASISTENCIA ---\n{asistencia}", 
                "Procesamiento de " + personaSeleccionada.Rol);
        }

        private void ActualizarLista()
        {
            lstPersonal.DataSource = null;
            lstPersonal.DataSource = listaPersonal;
        }

        private void LimpiarCampos()
        {
            txtMatricula.Clear();
            txtNombre.Clear();
            txtCarrera.Clear();
            txtSemestre.Clear();
            txtCorreo.Clear();
            cmbRol.SelectedIndex = 0;
            txtMatricula.Focus();
        }
    }
}
