namespace BBDD.Presentacion
{
    partial class FormEmpleados
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
            lstEmpleados = new ListBox();
            CLEAN_botton = new Button();
            DELETE_botton = new Button();
            UPDATE_botton = new Button();
            ADD_botton = new Button();
            IBAN = new Label();
            label2 = new Label();
            txtNameEmpleado = new TextBox();
            label1 = new Label();
            txtIDEmpleado = new TextBox();
            Pais_labbel = new Label();
            cmbPaises = new ComboBox();
            labbel_tabla = new Label();
            txtIBANEmpleado = new TextBox();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(34, 54);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(319, 344);
            lstEmpleados.TabIndex = 21;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // CLEAN_botton
            // 
            CLEAN_botton.BackColor = Color.LightGoldenrodYellow;
            CLEAN_botton.Cursor = Cursors.Hand;
            CLEAN_botton.FlatStyle = FlatStyle.Popup;
            CLEAN_botton.Location = new Point(601, 351);
            CLEAN_botton.Name = "CLEAN_botton";
            CLEAN_botton.Size = new Size(105, 29);
            CLEAN_botton.TabIndex = 20;
            CLEAN_botton.Text = "LIMPIAR";
            CLEAN_botton.UseVisualStyleBackColor = false;
            CLEAN_botton.Click += CLEAN_botton_Click;
            // 
            // DELETE_botton
            // 
            DELETE_botton.BackColor = Color.LightCoral;
            DELETE_botton.Cursor = Cursors.Hand;
            DELETE_botton.FlatStyle = FlatStyle.Popup;
            DELETE_botton.Location = new Point(453, 351);
            DELETE_botton.Name = "DELETE_botton";
            DELETE_botton.Size = new Size(94, 29);
            DELETE_botton.TabIndex = 19;
            DELETE_botton.Text = "ELIMINAR";
            DELETE_botton.UseVisualStyleBackColor = false;
            DELETE_botton.Click += DELETE_botton_Click;
            // 
            // UPDATE_botton
            // 
            UPDATE_botton.BackColor = Color.Turquoise;
            UPDATE_botton.Cursor = Cursors.Hand;
            UPDATE_botton.FlatStyle = FlatStyle.Popup;
            UPDATE_botton.Location = new Point(601, 292);
            UPDATE_botton.Name = "UPDATE_botton";
            UPDATE_botton.Size = new Size(105, 29);
            UPDATE_botton.TabIndex = 18;
            UPDATE_botton.Text = "ACTUALIZAR";
            UPDATE_botton.UseVisualStyleBackColor = false;
            UPDATE_botton.Click += UPDATE_botton_Click;
            // 
            // ADD_botton
            // 
            ADD_botton.BackColor = Color.MediumSeaGreen;
            ADD_botton.Cursor = Cursors.Hand;
            ADD_botton.FlatStyle = FlatStyle.Popup;
            ADD_botton.Location = new Point(453, 292);
            ADD_botton.Name = "ADD_botton";
            ADD_botton.Size = new Size(94, 29);
            ADD_botton.TabIndex = 17;
            ADD_botton.Text = "AÑADIR";
            ADD_botton.UseVisualStyleBackColor = false;
            ADD_botton.Click += ADD_botton_Click;
            // 
            // IBAN
            // 
            IBAN.AutoSize = true;
            IBAN.BorderStyle = BorderStyle.FixedSingle;
            IBAN.Location = new Point(419, 169);
            IBAN.Name = "IBAN";
            IBAN.Size = new Size(52, 22);
            IBAN.TabIndex = 16;
            IBAN.Text = "IBAN: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(402, 113);
            label2.Name = "label2";
            label2.Size = new Size(69, 22);
            label2.TabIndex = 15;
            label2.Text = "Nombre:";
            // 
            // txtNameEmpleado
            // 
            txtNameEmpleado.Location = new Point(503, 108);
            txtNameEmpleado.Name = "txtNameEmpleado";
            txtNameEmpleado.Size = new Size(182, 27);
            txtNameEmpleado.TabIndex = 14;
            // 
            // label1
            // 
            label1.AccessibleName = "ID";
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(442, 54);
            label1.Name = "label1";
            label1.Size = new Size(29, 22);
            label1.TabIndex = 13;
            label1.Text = "ID:";
            // 
            // txtIDEmpleado
            // 
            txtIDEmpleado.Location = new Point(503, 51);
            txtIDEmpleado.Name = "txtIDEmpleado";
            txtIDEmpleado.Size = new Size(182, 27);
            txtIDEmpleado.TabIndex = 12;
            // 
            // Pais_labbel
            // 
            Pais_labbel.AutoSize = true;
            Pais_labbel.BorderStyle = BorderStyle.FixedSingle;
            Pais_labbel.Location = new Point(435, 225);
            Pais_labbel.Name = "Pais_labbel";
            Pais_labbel.Size = new Size(36, 22);
            Pais_labbel.TabIndex = 24;
            Pais_labbel.Text = "Pais";
            // 
            // cmbPaises
            // 
            cmbPaises.FormattingEnabled = true;
            cmbPaises.Location = new Point(503, 219);
            cmbPaises.Name = "cmbPaises";
            cmbPaises.Size = new Size(151, 28);
            cmbPaises.TabIndex = 25;
            cmbPaises.TextUpdate += cmbPaises_TextUpdate;
            // 
            // labbel_tabla
            // 
            labbel_tabla.AccessibleName = "ID";
            labbel_tabla.AutoSize = true;
            labbel_tabla.BorderStyle = BorderStyle.FixedSingle;
            labbel_tabla.Location = new Point(34, 29);
            labbel_tabla.Name = "labbel_tabla";
            labbel_tabla.Size = new Size(49, 22);
            labbel_tabla.TabIndex = 26;
            labbel_tabla.Text = "Tabla:";
            // 
            // txtIBANEmpleado
            // 
            txtIBANEmpleado.Location = new Point(503, 169);
            txtIBANEmpleado.Name = "txtIBANEmpleado";
            txtIBANEmpleado.Size = new Size(182, 27);
            txtIBANEmpleado.TabIndex = 27;
            // 
            // FormEmpleados
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
            Controls.Add(label2);
            Controls.Add(txtNameEmpleado);
            Controls.Add(label1);
            Controls.Add(txtIDEmpleado);
            Name = "FormEmpleados";
            Text = "FormEmpleados";
            Load += FormEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstEmpleados;
        private Button CLEAN_botton;
        private Button DELETE_botton;
        private Button UPDATE_botton;
        private Button ADD_botton;
        private Label IBAN;
        private Label label2;
        private TextBox txtNameEmpleado;
        private Label label1;
        private TextBox txtIDEmpleado;
        private Label Pais_labbel;
        private ComboBox cmbPaises;
        private Label labbel_tabla;
        private TextBox txtIBANEmpleado;
    }
}