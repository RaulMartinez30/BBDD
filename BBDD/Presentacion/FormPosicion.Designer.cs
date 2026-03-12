namespace BBDD.Presentacion
{
    partial class FormPosicion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtIDPosicion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNamePosicion = new TextBox();
            label3 = new Label();
            ADD_botton = new Button();
            UPDATE_botton = new Button();
            DELETE_botton = new Button();
            CLEAN_botton = new Button();
            lstPosicion = new ListBox();
            numYearSalary = new NumericUpDown();
            labbel_tabla = new Label();
            cmbEmpleados = new ComboBox();
            label_emp = new Label();
            cmbOficinas = new ComboBox();
            label_ofi = new Label();
            label_inicio = new Label();
            dtpStartDate = new DateTimePicker();
            label_fin = new Label();
            dtpEndDate = new DateTimePicker();
            chkActual = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numYearSalary).BeginInit();
            SuspendLayout();
            // 
            // labbel_tabla
            // 
            labbel_tabla.AutoSize = true;
            labbel_tabla.BorderStyle = BorderStyle.FixedSingle;
            labbel_tabla.Location = new Point(33, 25);
            labbel_tabla.Name = "labbel_tabla";
            labbel_tabla.Size = new Size(49, 22);
            labbel_tabla.Text = "Tabla:";
            // 
            // lstPosicion
            // 
            lstPosicion.FormattingEnabled = true;
            lstPosicion.Location = new Point(33, 50);
            lstPosicion.Name = "lstPosicion";
            lstPosicion.Size = new Size(319, 344);
            lstPosicion.SelectedIndexChanged += lstPosicion_SelectedIndexChanged;
            // 
            // label1 (ID)
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(455, 50);
            label1.Name = "label1";
            label1.Size = new Size(29, 22);
            label1.Text = "ID:";
            // 
            // txtIDPosicion
            // 
            txtIDPosicion.Location = new Point(505, 47);
            txtIDPosicion.Name = "txtIDPosicion";
            txtIDPosicion.Size = new Size(182, 27);
            txtIDPosicion.ReadOnly = true;
            // 
            // label_emp (Empleado)
            // 
            label_emp.AutoSize = true;
            label_emp.BorderStyle = BorderStyle.FixedSingle;
            label_emp.Location = new Point(404, 90);
            label_emp.Name = "label_emp";
            label_emp.Text = "Empleado:";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.Location = new Point(505, 87);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(182, 28);
            cmbEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // label_ofi (Oficina)
            // 
            label_ofi.AutoSize = true;
            label_ofi.BorderStyle = BorderStyle.FixedSingle;
            label_ofi.Location = new Point(423, 130);
            label_ofi.Name = "label_ofi";
            label_ofi.Text = "Oficina:";
            // 
            // cmbOficinas
            // 
            cmbOficinas.Location = new Point(505, 127);
            cmbOficinas.Name = "cmbOficinas";
            cmbOficinas.Size = new Size(182, 28);
            cmbOficinas.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // label2 (Puesto)
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(425, 170);
            label2.Name = "label2";
            label2.Text = "Puesto:";
            // 
            // txtNamePosicion
            // 
            txtNamePosicion.Location = new Point(505, 167);
            txtNamePosicion.Name = "txtNamePosicion";
            txtNamePosicion.Size = new Size(182, 27);
            // 
            // label3 (Salario)
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(425, 210);
            label3.Name = "label3";
            label3.Text = "Salario:";
            // 
            // numYearSalary
            // 
            numYearSalary.Location = new Point(505, 207);
            numYearSalary.Name = "numYearSalary";
            numYearSalary.Size = new Size(182, 27);
            numYearSalary.DecimalPlaces = 2;
            numYearSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // label_inicio (Inicio)
            // 
            label_inicio.AutoSize = true;
            label_inicio.BorderStyle = BorderStyle.FixedSingle;
            label_inicio.Location = new Point(433, 250);
            label_inicio.Name = "label_inicio";
            label_inicio.Text = "Inicio:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(505, 247);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(182, 27);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            // 
            // label_fin (Fin)
            // 
            label_fin.AutoSize = true;
            label_fin.BorderStyle = BorderStyle.FixedSingle;
            label_fin.Location = new Point(450, 290);
            label_fin.Name = "label_fin";
            label_fin.Text = "Fin:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(505, 287);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(182, 27);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Enabled = false;
            // 
            // chkActual
            // 
            chkActual.Location = new Point(505, 320);
            chkActual.Name = "chkActual";
            chkActual.Text = "Puesto actual";
            chkActual.Checked = true;
            chkActual.Size = new Size(150, 24);
            chkActual.CheckedChanged += chkActual_CheckedChanged;
            // 
            // ADD_botton
            // 
            ADD_botton.Location = new Point(420, 350); 
            ADD_botton.Name = "ADD_botton";
            ADD_botton.Size = new Size(100, 29);
            ADD_botton.Text = "AÑADIR";
            ADD_botton.Click += ADD_botton_Click;
            // 
            // UPDATE_botton
            // 
            UPDATE_botton.Location = new Point(570, 350); 
            UPDATE_botton.Name = "UPDATE_botton";
            UPDATE_botton.Size = new Size(110, 29);
            UPDATE_botton.Text = "ACTUALIZAR";
            UPDATE_botton.Click += UPDATE_botton_Click;
            // 
            // DELETE_botton
            // 
            DELETE_botton.Location = new Point(420, 390); 
            DELETE_botton.Name = "DELETE_botton";
            DELETE_botton.Size = new Size(100, 29);
            DELETE_botton.Text = "ELIMINAR";
            DELETE_botton.Click += DELETE_botton_Click;
            // 
            // CLEAN_botton
            // 
            CLEAN_botton.Location = new Point(570, 390); 
            CLEAN_botton.Name = "CLEAN_botton";
            CLEAN_botton.Size = new Size(110, 29);
            CLEAN_botton.Text = "LIMPIAR";
            CLEAN_botton.Click += CLEAN_botton_Click;
            // 
            // FormPosicion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 440); 
            Controls.Add(chkActual);
            Controls.Add(label_fin);
            Controls.Add(dtpEndDate);
            Controls.Add(label_inicio);
            Controls.Add(dtpStartDate);
            Controls.Add(label_ofi);
            Controls.Add(cmbOficinas);
            Controls.Add(label_emp);
            Controls.Add(cmbEmpleados);
            Controls.Add(labbel_tabla);
            Controls.Add(numYearSalary);
            Controls.Add(lstPosicion);
            Controls.Add(CLEAN_botton);
            Controls.Add(DELETE_botton);
            Controls.Add(UPDATE_botton);
            Controls.Add(ADD_botton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNamePosicion);
            Controls.Add(label1);
            Controls.Add(txtIDPosicion);
            Name = "FormPosicion";
            Text = "Gestión de Posiciones";
            Load += FormPosicion_Load;
            ((System.ComponentModel.ISupportInitialize)numYearSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIDPosicion;
        private Label label1;
        private Label label2;
        private TextBox txtNamePosicion;
        private Label label3;
        private Button ADD_botton;
        private Button UPDATE_botton;
        private Button DELETE_botton;
        private Button CLEAN_botton;
        private ListBox lstPosicion;
        private NumericUpDown numYearSalary;
        private Label labbel_tabla;
        private ComboBox cmbEmpleados;
        private Label label_emp;
        private ComboBox cmbOficinas;
        private Label label_ofi;
        private Label label_inicio;
        private DateTimePicker dtpStartDate;
        private Label label_fin;
        private DateTimePicker dtpEndDate;
        private CheckBox chkActual;
    }
}