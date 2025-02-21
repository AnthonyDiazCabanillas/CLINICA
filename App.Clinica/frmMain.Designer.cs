namespace App.Clinica
{
    partial class frmMain
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
            this.btnPagoReserva = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSiteds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPagoReserva
            // 
            this.btnPagoReserva.Location = new System.Drawing.Point(12, 12);
            this.btnPagoReserva.Name = "btnPagoReserva";
            this.btnPagoReserva.Size = new System.Drawing.Size(107, 69);
            this.btnPagoReserva.TabIndex = 0;
            this.btnPagoReserva.Text = "Pago de Reserva";
            this.btnPagoReserva.UseVisualStyleBackColor = true;
            this.btnPagoReserva.Click += new System.EventHandler(this.btnPagoReserva_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSiteds
            // 
            this.btnSiteds.Location = new System.Drawing.Point(141, 12);
            this.btnSiteds.Name = "btnSiteds";
            this.btnSiteds.Size = new System.Drawing.Size(107, 69);
            this.btnSiteds.TabIndex = 2;
            this.btnSiteds.Text = "Siteds";
            this.btnSiteds.UseVisualStyleBackColor = true;
            this.btnSiteds.Click += new System.EventHandler(this.btnSiteds_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 579);
            this.Controls.Add(this.btnSiteds);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPagoReserva);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPagoReserva;
        private Button button2;
        private Button btnSiteds;
    }
}