namespace CapaPresentacion
{
    partial class frmAcademico_OrdenDeMatricula
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IDValor = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.CBIdentificacion = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.TBAlumno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TBValor = new System.Windows.Forms.TextBox();
            this.TBAño = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TBOrden = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TBIdentificacion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IDValor);
            this.groupBox1.Controls.Add(this.btnExaminar);
            this.groupBox1.Controls.Add(this.CBIdentificacion);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.TBAlumno);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TBIdentificacion);
            this.groupBox1.Controls.Add(this.TBValor);
            this.groupBox1.Controls.Add(this.TBAño);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TBOrden);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A&&J Academico - Ordenes de Matricula";
            // 
            // IDValor
            // 
            this.IDValor.Location = new System.Drawing.Point(117, 144);
            this.IDValor.Name = "IDValor";
            this.IDValor.Size = new System.Drawing.Size(42, 23);
            this.IDValor.TabIndex = 36;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.White;
            this.btnExaminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.btnExaminar;
            this.btnExaminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Location = new System.Drawing.Point(297, 80);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(30, 23);
            this.btnExaminar.TabIndex = 35;
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // CBIdentificacion
            // 
            this.CBIdentificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBIdentificacion.FormattingEnabled = true;
            this.CBIdentificacion.Items.AddRange(new object[] {
            "-",
            "I.E.",
            "R.C.",
            "T.I."});
            this.CBIdentificacion.Location = new System.Drawing.Point(94, 51);
            this.CBIdentificacion.Name = "CBIdentificacion";
            this.CBIdentificacion.Size = new System.Drawing.Size(42, 23);
            this.CBIdentificacion.TabIndex = 33;
            this.CBIdentificacion.SelectedIndexChanged += new System.EventHandler(this.CBIdentificacion_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(227, 138);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 32);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseDown);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Alumno";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(11, 138);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 32);
            this.btnNuevo.TabIndex = 31;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseDown);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            this.btnNuevo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseMove);
            // 
            // TBAlumno
            // 
            this.TBAlumno.Location = new System.Drawing.Point(94, 22);
            this.TBAlumno.Name = "TBAlumno";
            this.TBAlumno.Size = new System.Drawing.Size(233, 23);
            this.TBAlumno.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Alumno";
            // 
            // TBValor
            // 
            this.TBValor.Location = new System.Drawing.Point(94, 80);
            this.TBValor.Name = "TBValor";
            this.TBValor.Size = new System.Drawing.Size(121, 23);
            this.TBValor.TabIndex = 23;
            this.TBValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBAño
            // 
            this.TBAño.Location = new System.Drawing.Point(221, 80);
            this.TBAño.Name = "TBAño";
            this.TBAño.Size = new System.Drawing.Size(70, 23);
            this.TBAño.TabIndex = 24;
            this.TBAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "Identificacion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Orden";
            // 
            // TBOrden
            // 
            this.TBOrden.Location = new System.Drawing.Point(94, 109);
            this.TBOrden.Name = "TBOrden";
            this.TBOrden.Size = new System.Drawing.Size(233, 23);
            this.TBOrden.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "Identificacion";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 15);
            this.label18.TabIndex = 28;
            this.label18.Text = "Valor a Pagar";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 15);
            this.label19.TabIndex = 29;
            this.label19.Text = "Valor a Pagar";
            // 
            // TBIdentificacion
            // 
            this.TBIdentificacion.Location = new System.Drawing.Point(142, 51);
            this.TBIdentificacion.Name = "TBIdentificacion";
            this.TBIdentificacion.Size = new System.Drawing.Size(185, 23);
            this.TBIdentificacion.TabIndex = 22;
            // 
            // frmTesoreria_OrdenDeMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 203);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmTesoreria_OrdenDeMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financiera - Orden de Matricula";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTesoreria_OrdenDeMatricula_FormClosing);
            this.Load += new System.EventHandler(this.frmFinanciera_OrdenDeMatricula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBIdentificacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox TBAlumno;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox TBValor;
        public System.Windows.Forms.TextBox TBAño;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TBOrden;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox IDValor;
        private System.Windows.Forms.TextBox TBIdentificacion;
    }
}