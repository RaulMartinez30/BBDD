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

        private void TablaControlForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            // --- Lógica para PAÍSES ---
            if (TablaControlForm.SelectedTab == Paises)
            {
                if (Paises.Controls.Count == 0)
                {
                    FormPaises f = new FormPaises();
                    CargarFormEnTab(f, Paises);
                }
            }
            // --- Lógica para EMPLEADOS ---
            else if (TablaControlForm.SelectedTab == Empleados)
            {
                if (Empleados.Controls.Count == 0)
                {
                    FormEmpleados f = new FormEmpleados();
                    CargarFormEnTab(f, Empleados);
                }
            }
            // --- Lógica para OFICINA ---
            else if (TablaControlForm.SelectedTab == Oficina)
            {
                if (Oficina.Controls.Count == 0)
                {
                    FormOficina f = new FormOficina();
                    CargarFormEnTab(f, Oficina);
                }
            }
            // --- Lógica para POSICIÓN ---
            else if (TablaControlForm.SelectedTab == Posicion)
            {
                if (Posicion.Controls.Count == 0)
                {
                    FormPosicion f = new FormPosicion();
                    CargarFormEnTab(f, Posicion);
                }
            }
            // --- Lógica para NOMINAS ---
            else if (TablaControlForm.SelectedTab == Nominas)
            {
                if (Nominas.Controls.Count == 0)
                {
                    FormNominas f = new FormNominas();
                    CargarFormEnTab(f, Nominas);
                }
            }
            else if (TablaControlForm.SelectedTab == Informes) // Asegurate de que la pestaña se llama Informes en el diseñador
            {
                if (Informes.Controls.Count == 0)
                {
                    FormInformes f = new FormInformes();
                    CargarFormEnTab(f, Informes);
                }
            }
            // En FormPrincipal.cs, dentro de TablaControlForm_SelectedIndexChanged
            else if (TablaControlForm.SelectedTab == Oficina)
            {
                if (Oficina.Controls.Count == 0)
                {
                    FormOficina f = new FormOficina();
                    CargarFormEnTab(f, Oficina);
                }
                else
                {
                    // Si ya está cargado, buscamos el formulario y refrescamos los combos
                    foreach (Control c in Oficina.Controls)
                    {
                        if (c is FormOficina fOfi)
                        {
                            fOfi.cargarPaises(); // ¡Y listo! Actualizado sin reiniciar
                        }
                    }
                }
            }
        }

        // Método auxiliar para no escribir lo mismo 4 veces (Limpieza nivel pro)
        private void CargarFormEnTab(Form formularioHijo, TabPage pestañaDestino)
        {
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pestañaDestino.Controls.Add(formularioHijo);
            formularioHijo.Show();
        }


    }
}
