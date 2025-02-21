namespace App.Demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpFecInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.cboTipoConsulta = new System.Windows.Forms.ComboBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.dgvResultadoConsulta = new System.Windows.Forms.DataGridView();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtDocIdentidad = new System.Windows.Forms.TextBox();
            this.txtCodAtencion = new System.Windows.Forms.TextBox();
            this.IDCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTraeData = new System.Windows.Forms.Button();
            this.btnProcesarPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecInicio
            // 
            this.dtpFecInicio.Location = new System.Drawing.Point(3, 191);
            this.dtpFecInicio.Name = "dtpFecInicio";
            this.dtpFecInicio.Size = new System.Drawing.Size(250, 27);
            this.dtpFecInicio.TabIndex = 0;
            this.dtpFecInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Location = new System.Drawing.Point(3, 224);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(250, 27);
            this.dtpFecFin.TabIndex = 1;
            this.dtpFecFin.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // cboSede
            // 
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(263, 194);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(151, 28);
            this.cboSede.TabIndex = 2;
            this.cboSede.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboTipoConsulta
            // 
            this.cboTipoConsulta.FormattingEnabled = true;
            this.cboTipoConsulta.Location = new System.Drawing.Point(263, 228);
            this.cboTipoConsulta.Name = "cboTipoConsulta";
            this.cboTipoConsulta.Size = new System.Drawing.Size(151, 28);
            this.cboTipoConsulta.TabIndex = 3;
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(263, 262);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(151, 28);
            this.cboTipoPago.TabIndex = 4;
            // 
            // dgvResultadoConsulta
            // 
            this.dgvResultadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoConsulta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvResultadoConsulta.Location = new System.Drawing.Point(0, 313);
            this.dgvResultadoConsulta.Name = "dgvResultadoConsulta";
            this.dgvResultadoConsulta.RowHeadersWidth = 51;
            this.dgvResultadoConsulta.RowTemplate.Height = 29;
            this.dgvResultadoConsulta.Size = new System.Drawing.Size(1235, 360);
            this.dgvResultadoConsulta.TabIndex = 5;
            this.dgvResultadoConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultadoConsulta_CellContentClick);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(436, 195);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(125, 27);
            this.txtPaciente.TabIndex = 7;
            // 
            // txtDocIdentidad
            // 
            this.txtDocIdentidad.Location = new System.Drawing.Point(438, 231);
            this.txtDocIdentidad.Name = "txtDocIdentidad";
            this.txtDocIdentidad.Size = new System.Drawing.Size(125, 27);
            this.txtDocIdentidad.TabIndex = 8;
            this.txtDocIdentidad.TextChanged += new System.EventHandler(this.txtDocIdentidad_TextChanged);
            // 
            // txtCodAtencion
            // 
            this.txtCodAtencion.Location = new System.Drawing.Point(436, 264);
            this.txtCodAtencion.Name = "txtCodAtencion";
            this.txtCodAtencion.Size = new System.Drawing.Size(125, 27);
            this.txtCodAtencion.TabIndex = 9;
            // 
            // IDCita
            // 
            this.IDCita.DataPropertyName = "IDCita";
            this.IDCita.HeaderText = "IDCita";
            this.IDCita.MinimumWidth = 6;
            this.IDCita.Name = "IDCita";
            this.IDCita.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDCita";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDCita";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "IDCita";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDCita";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDCita";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // btnTraeData
            // 
            this.btnTraeData.Location = new System.Drawing.Point(1029, 23);
            this.btnTraeData.Name = "btnTraeData";
            this.btnTraeData.Size = new System.Drawing.Size(131, 43);
            this.btnTraeData.TabIndex = 10;
            this.btnTraeData.Text = "Trae Data";
            this.btnTraeData.UseVisualStyleBackColor = true;
            this.btnTraeData.Click += new System.EventHandler(this.btnTraeData_Click);
            // 
            // btnProcesarPago
            // 
            this.btnProcesarPago.Location = new System.Drawing.Point(26, 12);
            this.btnProcesarPago.Name = "btnProcesarPago";
            this.btnProcesarPago.Size = new System.Drawing.Size(131, 43);
            this.btnProcesarPago.TabIndex = 11;
            this.btnProcesarPago.Text = "Procesar Pago";
            this.btnProcesarPago.UseVisualStyleBackColor = true;
            this.btnProcesarPago.Click += new System.EventHandler(this.btnProcesarPago_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 673);
            this.Controls.Add(this.btnProcesarPago);
            this.Controls.Add(this.btnTraeData);
            this.Controls.Add(this.txtCodAtencion);
            this.Controls.Add(this.txtDocIdentidad);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.dgvResultadoConsulta);
            this.Controls.Add(this.cboTipoPago);
            this.Controls.Add(this.cboTipoConsulta);
            this.Controls.Add(this.cboSede);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpFecInicio;
        private DateTimePicker dtpFecFin;
        private ComboBox cboSede;
        private ComboBox cboTipoConsulta;
        private ComboBox cboTipoPago;
        private DataGridView dgvResultadoConsulta;
        private TextBox txtPaciente;
        private TextBox txtDocIdentidad;
        private TextBox txtCodAtencion;
        private DataGridViewTextBoxColumn IDCita;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button btnTraeData;
        private Button btnProcesarPago;
    }
}