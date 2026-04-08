namespace BBDD.Presentacion
{
    partial class FormInformes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTipoInforme = new Label();
            cmbTipoInforme = new ComboBox();
            lblOficinas = new Label();
            cmbOficinas = new ComboBox();
            lblEmpleados = new Label();
            cmbEmpleados = new ComboBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            btnGenerar = new Button();
            dgvResultados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // lblTipoInforme
            // 
            lblTipoInforme.AutoSize = true;
            lblTipoInforme.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipoInforme.Location = new Point(12, 15);
            lblTipoInforme.Name = "lblTipoInforme";
            lblTipoInforme.Size = new Size(125, 20);
            lblTipoInforme.TabIndex = 0;
            lblTipoInforme.Text = "Tipo de informe:";
            // 
            // cmbTipoInforme
            // 
            cmbTipoInforme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoInforme.FormattingEnabled = true;
            cmbTipoInforme.Location = new Point(140, 12);
            cmbTipoInforme.Name = "cmbTipoInforme";
            cmbTipoInforme.Size = new Size(380, 28);
            cmbTipoInforme.TabIndex = 0;
            cmbTipoInforme.SelectedIndexChanged += cmbTipoInforme_SelectedIndexChanged;
            // 
            // lblOficinas
            // 
            lblOficinas.AutoSize = true;
            lblOficinas.Location = new Point(12, 58);
            lblOficinas.Name = "lblOficinas";
            lblOficinas.Size = new Size(59, 20);
            lblOficinas.TabIndex = 1;
            lblOficinas.Text = "Oficina:";
            // 
            // cmbOficinas
            // 
            cmbOficinas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOficinas.FormattingEnabled = true;
            cmbOficinas.Location = new Point(140, 55);
            cmbOficinas.Name = "cmbOficinas";
            cmbOficinas.Size = new Size(220, 28);
            cmbOficinas.TabIndex = 1;
            cmbOficinas.SelectedIndexChanged += cmbOficinas_SelectedIndexChanged;
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Location = new Point(12, 58);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(80, 20);
            lblEmpleados.TabIndex = 2;
            lblEmpleados.Text = "Empleado:";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(140, 55);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(220, 28);
            cmbEmpleados.TabIndex = 2;
            cmbEmpleados.SelectedIndexChanged += cmbEmpleados_SelectedIndexChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(380, 58);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(72, 20);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Mes/Año:";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(460, 55);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.ShowUpDown = true;
            dtpFecha.Size = new Size(120, 27);
            dtpFecha.TabIndex = 3;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(620, 52);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(150, 32);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar informe";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.BackgroundColor = SystemColors.Window;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(12, 100);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(776, 290);
            dgvResultados.TabIndex = 5;
            dgvResultados.CellContentClick += dgvResultados_CellContentClick;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(lblTipoInforme);
            Controls.Add(cmbTipoInforme);
            Controls.Add(lblOficinas);
            Controls.Add(cmbOficinas);
            Controls.Add(lblEmpleados);
            Controls.Add(cmbEmpleados);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(btnGenerar);
            Controls.Add(dgvResultados);
            Name = "FormInformes";
            Text = "Informes";
            Load += FormInformes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoInforme;
        private ComboBox cmbTipoInforme;
        private Label lblOficinas;
        private ComboBox cmbOficinas;
        private Label lblEmpleados;
        private ComboBox cmbEmpleados;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Button btnGenerar;
        private DataGridView dgvResultados;
    }
}