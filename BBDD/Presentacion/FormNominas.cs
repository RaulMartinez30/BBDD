using BBDD.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBDD.Presentacion
{
    public partial class FormNominas : Form
    {
        public FormNominas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int anioSeleccionado = dateTimePicker1.Value.Year;
                int mesSeleccionado = dateTimePicker1.Value.Month;


                DateTime fechaSeleccionada = new DateTime(anioSeleccionado, mesSeleccionado, 1);
                DateTime fechaActual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                if (fechaSeleccionada >= fechaActual)
                {
                    MessageBox.Show("Bro, el mes seleccionado tiene que ser en el pasado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                Nominas aux = new Nominas();
                // Tendrás que crear este método en Nominas.cs
                if (aux.CheckIfNominaExists(anioSeleccionado, mesSeleccionado))
                {
                    MessageBox.Show("Ya se ha generado previamente la información para este año-mes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int generadas = aux.GenerarNominasMes(anioSeleccionado, mesSeleccionado);

                if (generadas > 0)
                {
                    MessageBox.Show($"¡Se han generado {generadas} nóminas de locos para la fecha {mesSeleccionado}/{anioSeleccionado}!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nadie ha currado este mes, no se generó ninguna nómina.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error chungo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
