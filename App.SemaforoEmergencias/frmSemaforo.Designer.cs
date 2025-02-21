namespace App.SemaforoEmergencias
{
    partial class frmSemaforo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSemaforo));
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.LbTCasa = new System.Windows.Forms.Label();
            this.LbTHospitalizados = new System.Windows.Forms.Label();
            this.LbTFallecidos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.LbTReferidos = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.BtnCasa = new CustomControls.RJControls.RJButton();
            this.BtnHospitalizacion = new CustomControls.RJControls.RJButton();
            this.BtnFallecido = new CustomControls.RJControls.RJButton();
            this.BtnReferido = new CustomControls.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Topico";
            columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Atención";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prioridad";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Destino";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tiempo";
            this.columnHeader5.Width = 105;
            // 
            // ListView1
            // 
            this.ListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView1.BackColor = System.Drawing.SystemColors.Info;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListView1.FullRowSelect = true;
            this.ListView1.Location = new System.Drawing.Point(10, 82);
            this.ListView1.Margin = new System.Windows.Forms.Padding(2);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.RightToLeftLayout = true;
            this.ListView1.Size = new System.Drawing.Size(479, 151);
            this.ListView1.TabIndex = 1;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // LbTCasa
            // 
            this.LbTCasa.AutoSize = true;
            this.LbTCasa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbTCasa.Location = new System.Drawing.Point(100, 7);
            this.LbTCasa.Name = "LbTCasa";
            this.LbTCasa.Size = new System.Drawing.Size(31, 15);
            this.LbTCasa.TabIndex = 2;
            this.LbTCasa.Text = "Casa";
            // 
            // LbTHospitalizados
            // 
            this.LbTHospitalizados.AutoSize = true;
            this.LbTHospitalizados.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbTHospitalizados.Location = new System.Drawing.Point(148, 7);
            this.LbTHospitalizados.Name = "LbTHospitalizados";
            this.LbTHospitalizados.Size = new System.Drawing.Size(85, 15);
            this.LbTHospitalizados.TabIndex = 3;
            this.LbTHospitalizados.Text = "Hospitalizados";
            // 
            // LbTFallecidos
            // 
            this.LbTFallecidos.AutoSize = true;
            this.LbTFallecidos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbTFallecidos.Location = new System.Drawing.Point(249, 7);
            this.LbTFallecidos.Name = "LbTFallecidos";
            this.LbTFallecidos.Size = new System.Drawing.Size(59, 15);
            this.LbTFallecidos.TabIndex = 4;
            this.LbTFallecidos.Text = "Fallecidos";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Snow;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Snow;
            this.rjButton1.BorderColor = System.Drawing.Color.Red;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.Red;
            this.rjButton1.Location = new System.Drawing.Point(396, 22);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(97, 33);
            this.rjButton1.TabIndex = 12;
            this.rjButton1.Text = "↓ Lista ↓";
            this.rjButton1.TextColor = System.Drawing.Color.Red;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // LbTReferidos
            // 
            this.LbTReferidos.AutoSize = true;
            this.LbTReferidos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbTReferidos.Location = new System.Drawing.Point(325, 7);
            this.LbTReferidos.Name = "LbTReferidos";
            this.LbTReferidos.Size = new System.Drawing.Size(56, 15);
            this.LbTReferidos.TabIndex = 13;
            this.LbTReferidos.Text = "Referidos";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTimer.Location = new System.Drawing.Point(16, 62);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(37, 15);
            this.lbTimer.TabIndex = 15;
            this.lbTimer.Text = "label1";
            // 
            // BtnCasa
            // 
            this.BtnCasa.BackColor = System.Drawing.Color.Green;
            this.BtnCasa.BackgroundColor = System.Drawing.Color.Green;
            this.BtnCasa.BorderColor = System.Drawing.Color.Black;
            this.BtnCasa.BorderRadius = 10;
            this.BtnCasa.BorderSize = 2;
            this.BtnCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCasa.FlatAppearance.BorderSize = 0;
            this.BtnCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCasa.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCasa.ForeColor = System.Drawing.Color.White;
            this.BtnCasa.Location = new System.Drawing.Point(90, 22);
            this.BtnCasa.Name = "BtnCasa";
            this.BtnCasa.Size = new System.Drawing.Size(59, 33);
            this.BtnCasa.TabIndex = 16;
            this.BtnCasa.Text = "0";
            this.BtnCasa.TextColor = System.Drawing.Color.White;
            this.BtnCasa.UseVisualStyleBackColor = false;
            this.BtnCasa.Click += new System.EventHandler(this.BtnCasa_Click);
            // 
            // BtnHospitalizacion
            // 
            this.BtnHospitalizacion.BackColor = System.Drawing.Color.Red;
            this.BtnHospitalizacion.BackgroundColor = System.Drawing.Color.Red;
            this.BtnHospitalizacion.BorderColor = System.Drawing.Color.Black;
            this.BtnHospitalizacion.BorderRadius = 10;
            this.BtnHospitalizacion.BorderSize = 2;
            this.BtnHospitalizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHospitalizacion.FlatAppearance.BorderSize = 0;
            this.BtnHospitalizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHospitalizacion.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHospitalizacion.ForeColor = System.Drawing.Color.White;
            this.BtnHospitalizacion.Location = new System.Drawing.Point(164, 22);
            this.BtnHospitalizacion.Name = "BtnHospitalizacion";
            this.BtnHospitalizacion.Size = new System.Drawing.Size(59, 33);
            this.BtnHospitalizacion.TabIndex = 17;
            this.BtnHospitalizacion.Text = "0";
            this.BtnHospitalizacion.TextColor = System.Drawing.Color.White;
            this.BtnHospitalizacion.UseVisualStyleBackColor = false;
            this.BtnHospitalizacion.Click += new System.EventHandler(this.BtnHospitalizacion_Click);
            // 
            // BtnFallecido
            // 
            this.BtnFallecido.BackColor = System.Drawing.Color.Black;
            this.BtnFallecido.BackgroundColor = System.Drawing.Color.Black;
            this.BtnFallecido.BorderColor = System.Drawing.Color.Black;
            this.BtnFallecido.BorderRadius = 10;
            this.BtnFallecido.BorderSize = 2;
            this.BtnFallecido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFallecido.FlatAppearance.BorderSize = 0;
            this.BtnFallecido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFallecido.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFallecido.ForeColor = System.Drawing.Color.White;
            this.BtnFallecido.Location = new System.Drawing.Point(259, 22);
            this.BtnFallecido.Name = "BtnFallecido";
            this.BtnFallecido.Size = new System.Drawing.Size(59, 33);
            this.BtnFallecido.TabIndex = 18;
            this.BtnFallecido.Text = "0";
            this.BtnFallecido.TextColor = System.Drawing.Color.White;
            this.BtnFallecido.UseVisualStyleBackColor = false;
            this.BtnFallecido.Click += new System.EventHandler(this.BtnFallecido_Click);
            // 
            // BtnReferido
            // 
            this.BtnReferido.BackColor = System.Drawing.Color.Blue;
            this.BtnReferido.BackgroundColor = System.Drawing.Color.Blue;
            this.BtnReferido.BorderColor = System.Drawing.Color.Black;
            this.BtnReferido.BorderRadius = 10;
            this.BtnReferido.BorderSize = 2;
            this.BtnReferido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReferido.FlatAppearance.BorderSize = 0;
            this.BtnReferido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReferido.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReferido.ForeColor = System.Drawing.Color.White;
            this.BtnReferido.Location = new System.Drawing.Point(332, 22);
            this.BtnReferido.Name = "BtnReferido";
            this.BtnReferido.Size = new System.Drawing.Size(59, 33);
            this.BtnReferido.TabIndex = 19;
            this.BtnReferido.Text = "0";
            this.BtnReferido.TextColor = System.Drawing.Color.White;
            this.BtnReferido.UseVisualStyleBackColor = false;
            this.BtnReferido.Click += new System.EventHandler(this.BtnReferido_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::App.SemaforoEmergencias.Properties.Resources.MUÑECO_TCUIDA;
            this.pictureBox1.Location = new System.Drawing.Point(29, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Actualizar";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHora.Location = new System.Drawing.Point(426, 62);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(41, 14);
            this.lbHora.TabIndex = 22;
            this.lbHora.Text = "label1";
            // 
            // frmSemaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(496, 244);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnReferido);
            this.Controls.Add(this.BtnFallecido);
            this.Controls.Add(this.BtnHospitalizacion);
            this.Controls.Add(this.BtnCasa);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.LbTReferidos);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.LbTFallecidos);
            this.Controls.Add(this.LbTHospitalizados);
            this.Controls.Add(this.LbTCasa);
            this.Controls.Add(this.ListView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSemaforo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Semaforo de Emergencias - CSF";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView ListView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label LbTCasa;
        private Label LbTHospitalizados;
        private Label LbTFallecidos;
        private System.Windows.Forms.Timer timer1;
        private CustomControls.RJControls.RJButton rjButton1;
        private Label LbTReferidos;
        private Label lbTimer;
        private CustomControls.RJControls.RJButton BtnCasa;
        private CustomControls.RJControls.RJButton BtnHospitalizacion;
        private CustomControls.RJControls.RJButton BtnFallecido;
        private CustomControls.RJControls.RJButton BtnReferido;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbHora;
    }
}