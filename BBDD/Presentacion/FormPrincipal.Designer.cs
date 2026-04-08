namespace BBDD.Presentacion
{
    partial class FormPrincipal
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
            TablaControlForm = new TabControl();
            Paises = new TabPage();
            Empleados = new TabPage();
            Oficina = new TabPage();
            Posicion = new TabPage();
            Nominas = new TabPage();
            fileSystemWatcher1 = new FileSystemWatcher();
            Informes = new TabPage();
            TablaControlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // TablaControlForm
            // 
            TablaControlForm.Controls.Add(Paises);
            TablaControlForm.Controls.Add(Empleados);
            TablaControlForm.Controls.Add(Oficina);
            TablaControlForm.Controls.Add(Posicion);
            TablaControlForm.Controls.Add(Nominas);
            TablaControlForm.Controls.Add(Informes);
            TablaControlForm.Location = new Point(1, 2);
            TablaControlForm.Name = "TablaControlForm";
            TablaControlForm.SelectedIndex = 0;
            TablaControlForm.Size = new Size(803, 448);
            TablaControlForm.TabIndex = 0;
            TablaControlForm.SelectedIndexChanged += TablaControlForm_SelectedIndexChanged;
            // 
            // Paises
            // 
            Paises.Location = new Point(4, 29);
            Paises.Name = "Paises";
            Paises.Padding = new Padding(3);
            Paises.Size = new Size(795, 415);
            Paises.TabIndex = 0;
            Paises.Text = "Paises";
            Paises.UseVisualStyleBackColor = true;
            // 
            // Empleados
            // 
            Empleados.Location = new Point(4, 29);
            Empleados.Name = "Empleados";
            Empleados.Padding = new Padding(3);
            Empleados.Size = new Size(795, 415);
            Empleados.TabIndex = 1;
            Empleados.Text = "Empleados";
            Empleados.UseVisualStyleBackColor = true;
            // 
            // Oficina
            // 
            Oficina.Location = new Point(4, 29);
            Oficina.Name = "Oficina";
            Oficina.Size = new Size(795, 415);
            Oficina.TabIndex = 2;
            Oficina.Text = "Oficina";
            Oficina.UseVisualStyleBackColor = true;
            // 
            // Posicion
            // 
            Posicion.Location = new Point(4, 29);
            Posicion.Name = "Posicion";
            Posicion.Size = new Size(795, 415);
            Posicion.TabIndex = 3;
            Posicion.Text = "Posición";
            Posicion.UseVisualStyleBackColor = true;
            // 
            // Nominas
            // 
            Nominas.Location = new Point(4, 29);
            Nominas.Name = "Nominas";
            Nominas.Size = new Size(795, 415);
            Nominas.TabIndex = 4;
            Nominas.Text = "Nominas";
            Nominas.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Informes
            // 
            Informes.Location = new Point(4, 29);
            Informes.Name = "Informes";
            Informes.Size = new Size(795, 415);
            Informes.TabIndex = 5;
            Informes.Text = "Informes";
            Informes.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TablaControlForm);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            TablaControlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TablaControlForm;
        private TabPage Paises;
        private TabPage Empleados;
        private TabPage Oficina;
        private FileSystemWatcher fileSystemWatcher1;
        private TabPage Posicion;
        private TabPage Nominas;
        private TabPage Informes;
    }
}