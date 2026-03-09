namespace BBDD.Presentacion
{
    partial class FormNominas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtIBANEmpleado = new TextBox();
            labbel_tabla = new Label();
            cmbPaises = new ComboBox();
            Pais_labbel = new Label();
            lstEmpleados = new ListBox();
            CLEAN_botton = new Button();
            DELETE_botton = new Button();
            UPDATE_botton = new Button();
            ADD_botton = new Button();
            IBAN = new Label();
            Id_Empleado_Labbel = new Label();
            txtNameEmpleado = new TextBox();
            label1 = new Label();
            txtIDEmpleado = new TextBox();
            SuspendLayout();
            // 
            // txtIBANEmpleado
            // 
            txtIBANEmpleado.Location = new Point(520, 177);
            txtIBANEmpleado.Name = "txtIBANEmpleado";
            txtIBANEmpleado.Size = new Size(182, 27);
            txtIBANEmpleado.TabIndex = 41;
            // 
            // labbel_tabla
            // 
            labbel_tabla.AccessibleName = "ID";
            labbel_tabla.AutoSize = true;
            labbel_tabla.BorderStyle = BorderStyle.FixedSingle;
            labbel_tabla.Location = new Point(51, 37);
            labbel_tabla.Name = "labbel_tabla";
            labbel_tabla.Size = new Size(49, 22);
            labbel_tabla.TabIndex = 40;
            labbel_tabla.Text = "Tabla:";
            // 
            // cmbPaises
            // 
            cmbPaises.FormattingEnabled = true;
            cmbPaises.Location = new Point(520, 227);
            cmbPaises.Name = "cmbPaises";
            cmbPaises.Size = new Size(151, 28);
            cmbPaises.TabIndex = 39;
            // 
            // Pais_labbel
            // 
            Pais_labbel.AutoSize = true;
            Pais_labbel.BorderStyle = BorderStyle.FixedSingle;
            Pais_labbel.Location = new Point(452, 233);
            Pais_labbel.Name = "Pais_labbel";
            Pais_labbel.Size = new Size(36, 22);
            Pais_labbel.TabIndex = 38;
            Pais_labbel.Text = "Pais";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(51, 62);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(319, 344);
            lstEmpleados.TabIndex = 37;
            // 
            // CLEAN_botton
            // 
            CLEAN_botton.Location = new Point(618, 359);
            CLEAN_botton.Name = "CLEAN_botton";
            CLEAN_botton.Size = new Size(94, 29);
            CLEAN_botton.TabIndex = 36;
            CLEAN_botton.Text = "LIMPIAR";
            CLEAN_botton.UseVisualStyleBackColor = true;
            // 
            // DELETE_botton
            // 
            DELETE_botton.Location = new Point(470, 359);
            DELETE_botton.Name = "DELETE_botton";
            DELETE_botton.Size = new Size(94, 29);
            DELETE_botton.TabIndex = 35;
            DELETE_botton.Text = "ELIMINAR";
            DELETE_botton.UseVisualStyleBackColor = true;
            // 
            // UPDATE_botton
            // 
            UPDATE_botton.Location = new Point(618, 300);
            UPDATE_botton.Name = "UPDATE_botton";
            UPDATE_botton.Size = new Size(105, 29);
            UPDATE_botton.TabIndex = 34;
            UPDATE_botton.Text = "ACTUALIZAR";
            UPDATE_botton.UseVisualStyleBackColor = true;
            // 
            // ADD_botton
            // 
            ADD_botton.Location = new Point(470, 300);
            ADD_botton.Name = "ADD_botton";
            ADD_botton.Size = new Size(94, 29);
            ADD_botton.TabIndex = 33;
            ADD_botton.Text = "AÑADIR";
            ADD_botton.UseVisualStyleBackColor = true;
            // 
            // IBAN
            // 
            IBAN.AutoSize = true;
            IBAN.BorderStyle = BorderStyle.FixedSingle;
            IBAN.Location = new Point(415, 177);
            IBAN.Name = "IBAN";
            IBAN.Size = new Size(75, 22);
            IBAN.TabIndex = 32;
            IBAN.Text = "Pago Año";
            // 
            // Id_Empleado_Labbel
            // 
            Id_Empleado_Labbel.AutoSize = true;
            Id_Empleado_Labbel.BorderStyle = BorderStyle.FixedSingle;
            Id_Empleado_Labbel.Location = new Point(389, 119);
            Id_Empleado_Labbel.Name = "Id_Empleado_Labbel";
            Id_Empleado_Labbel.Size = new Size(101, 22);
            Id_Empleado_Labbel.TabIndex = 31;
            Id_Empleado_Labbel.Text = "ID Empleado:";
            Id_Empleado_Labbel.Click += label2_Click;
            // 
            // txtNameEmpleado
            // 
            txtNameEmpleado.Location = new Point(520, 116);
            txtNameEmpleado.Name = "txtNameEmpleado";
            txtNameEmpleado.Size = new Size(182, 27);
            txtNameEmpleado.TabIndex = 30;
            // 
            // label1
            // 
            label1.AccessibleName = "ID";
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(459, 62);
            label1.Name = "label1";
            label1.Size = new Size(29, 22);
            label1.TabIndex = 29;
            label1.Text = "ID:";
            // 
            // txtIDEmpleado
            // 
            txtIDEmpleado.Location = new Point(520, 59);
            txtIDEmpleado.Name = "txtIDEmpleado";
            txtIDEmpleado.Size = new Size(182, 27);
            txtIDEmpleado.TabIndex = 28;
            // 
            // FormNominas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIBANEmpleado);
            Controls.Add(labbel_tabla);
            Controls.Add(cmbPaises);
            Controls.Add(Pais_labbel);
            Controls.Add(lstEmpleados);
            Controls.Add(CLEAN_botton);
            Controls.Add(DELETE_botton);
            Controls.Add(UPDATE_botton);
            Controls.Add(ADD_botton);
            Controls.Add(IBAN);
            Controls.Add(Id_Empleado_Labbel);
            Controls.Add(txtNameEmpleado);
            Controls.Add(label1);
            Controls.Add(txtIDEmpleado);
            Name = "FormNominas";
            Text = "FormNominas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIBANEmpleado;
        private Label labbel_tabla;
        private ComboBox cmbPaises;
        private Label Pais_labbel;
        private ListBox lstEmpleados;
        private Button CLEAN_botton;
        private Button DELETE_botton;
        private Button UPDATE_botton;
        private Button ADD_botton;
        private Label IBAN;
        private Label Id_Empleado_Labbel;
        private TextBox txtNameEmpleado;
        private Label label1;
        private TextBox txtIDEmpleado;
    }
}