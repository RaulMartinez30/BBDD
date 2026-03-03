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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Instanciamos Pais para usar su lógica
                Pais p = new Pais();

                // 2. Traemos la lista de la BBDD (la misma que usas en FormPaises)
                List<Pais> lista = p.ReadAllPaises();

                // 3. Limpiamos y cargamos el ComboBox
                cmbPaises.DataSource = lista;

                // AQUÍ VIENE LO IMPORTANTE (Razonamiento crítico):
                cmbPaises.DisplayMember = "Name"; // Lo que el usuario VE (el nombre del país)
                cmbPaises.ValueMember = "Id";     // Lo que la APP USA (el código como 'ES')
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando países: " + ex.Message);
            }
        }
    }
}
