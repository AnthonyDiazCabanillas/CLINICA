namespace App.Clinica.Cita
{
    partial class frmDatosReserva
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocIdentidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.dgvResultadoConsulta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDocIdentidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFecFin);
            this.groupBox1.Controls.Add(this.dtpFecInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPaciente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboSede);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1096, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(816, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(161, 47);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Doc. Identidad";
            // 
            // txtDocIdentidad
            // 
            this.txtDocIdentidad.Location = new System.Drawing.Point(581, 68);
            this.txtDocIdentidad.Name = "txtDocIdentidad";
            this.txtDocIdentidad.Size = new System.Drawing.Size(125, 27);
            this.txtDocIdentidad.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hasta";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(816, 35);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(141, 27);
            this.dtpFecFin.TabIndex = 11;
            // 
            // dtpFecInicio
            // 
            this.dtpFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecInicio.Location = new System.Drawing.Point(581, 35);
            this.dtpFecInicio.Name = "dtpFecInicio";
            this.dtpFecInicio.Size = new System.Drawing.Size(143, 27);
            this.dtpFecInicio.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de cita";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(104, 71);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(328, 27);
            this.txtPaciente.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sede";
            // 
            // cboSede
            // 
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(104, 37);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(328, 28);
            this.cboSede.TabIndex = 3;
            // 
            // dgvResultadoConsulta
            // 
            this.dgvResultadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultadoConsulta.Location = new System.Drawing.Point(0, 150);
            this.dgvResultadoConsulta.Name = "dgvResultadoConsulta";
            this.dgvResultadoConsulta.RowHeadersWidth = 51;
            this.dgvResultadoConsulta.RowTemplate.Height = 29;
            this.dgvResultadoConsulta.Size = new System.Drawing.Size(1096, 542);
            this.dgvResultadoConsulta.TabIndex = 6;
            // 
            // frmDatosReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 692);
            this.Controls.Add(this.dgvResultadoConsulta);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDatosReserva";
            this.Text = "frmDatosReserva";
            this.Load += new System.EventHandler(this.frmDatosReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cboSede;
        private TextBox txtPaciente;
        private Label label3;
        private DateTimePicker dtpFecInicio;
        private Label label4;
        private DateTimePicker dtpFecFin;
        private TextBox txtDocIdentidad;
        private Label label5;
        private DataGridView dgvResultadoConsulta;
        private Button btnBuscar;
    }
}