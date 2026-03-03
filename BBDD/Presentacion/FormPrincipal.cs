using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBDD.Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // 1. Creamos la instancia del formulario de países
            FormPaises fPaises = new FormPaises();

            // 2. Configuramos para que se integre en la pestaña
            fPaises.TopLevel = false;
            fPaises.FormBorderStyle = FormBorderStyle.None;
            fPaises.Dock = DockStyle.Fill;

            // 3. Lo añadimos a la TabPage "Paises" que ya tienes definida
            this.Paises.Controls.Add(fPaises);
            fPaises.Show();
        }

        private void Paises_Click(object sender, EventArgs e)
        {
            // 1. Limpiamos la pestaña por si ya tiene algo
            this.Paises.Controls.Clear();

            // 2. Creamos la instancia de tu formulario de países
            FormPaises fPaises = new FormPaises();

            // 3. Configuración "Ninja" para que se pegue al hueco
            fPaises.TopLevel = false;
            fPaises.FormBorderStyle = FormBorderStyle.None;
            fPaises.Dock = DockStyle.Fill;

            // 4. Lo metemos en la TabPage "Paises"
            this.Paises.Controls.Add(fPaises);
            fPaises.Show();
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            // Limpiamos la pestaña por si acaso ya habias dado click antes
            this.Empleados.Controls.Clear();

            // Creamos la interfaz de empleados
            FormEmpleados fEmpleados = new FormEmpleados();
            fEmpleados.TopLevel = false;
            fEmpleados.FormBorderStyle = FormBorderStyle.None;
            fEmpleados.Dock = DockStyle.Fill;

            // Lo enchufamos a la pestaña
            this.Empleados.Controls.Add(fEmpleados);
            fEmpleados.Show();
        }
    }
}
