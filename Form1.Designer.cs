namespace taller_punto4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblcalif1 = new System.Windows.Forms.Label();
            this.lblcalif2 = new System.Windows.Forms.Label();
            this.lblcalif3 = new System.Windows.Forms.Label();
            this.txtcalif1 = new System.Windows.Forms.TextBox();
            this.txtcalif3 = new System.Windows.Forms.TextBox();
            this.txtcalif2 = new System.Windows.Forms.TextBox();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(352, 271);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(273, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(198, 20);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "promedio de un estudiante";
            // 
            // lblcalif1
            // 
            this.lblcalif1.AutoSize = true;
            this.lblcalif1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalif1.Location = new System.Drawing.Point(232, 65);
            this.lblcalif1.Name = "lblcalif1";
            this.lblcalif1.Size = new System.Drawing.Size(103, 20);
            this.lblcalif1.TabIndex = 2;
            this.lblcalif1.Text = "calificacion 1:";
            this.lblcalif1.Click += new System.EventHandler(this.Lblcalif1_Click);
            // 
            // lblcalif2
            // 
            this.lblcalif2.AutoSize = true;
            this.lblcalif2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalif2.Location = new System.Drawing.Point(228, 115);
            this.lblcalif2.Name = "lblcalif2";
            this.lblcalif2.Size = new System.Drawing.Size(107, 20);
            this.lblcalif2.TabIndex = 3;
            this.lblcalif2.Text = "calificacion 2: ";
            // 
            // lblcalif3
            // 
            this.lblcalif3.AutoSize = true;
            this.lblcalif3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalif3.Location = new System.Drawing.Point(232, 169);
            this.lblcalif3.Name = "lblcalif3";
            this.lblcalif3.Size = new System.Drawing.Size(103, 20);
            this.lblcalif3.TabIndex = 4;
            this.lblcalif3.Text = "calificacion 3:";
            // 
            // txtcalif1
            // 
            this.txtcalif1.Location = new System.Drawing.Point(351, 67);
            this.txtcalif1.Name = "txtcalif1";
            this.txtcalif1.Size = new System.Drawing.Size(100, 20);
            this.txtcalif1.TabIndex = 5;
            // 
            // txtcalif3
            // 
            this.txtcalif3.Location = new System.Drawing.Point(352, 169);
            this.txtcalif3.Name = "txtcalif3";
            this.txtcalif3.Size = new System.Drawing.Size(100, 20);
            this.txtcalif3.TabIndex = 6;
            // 
            // txtcalif2
            // 
            this.txtcalif2.Location = new System.Drawing.Point(351, 117);
            this.txtcalif2.Name = "txtcalif2";
            this.txtcalif2.Size = new System.Drawing.Size(100, 20);
            this.txtcalif2.TabIndex = 7;
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio.Location = new System.Drawing.Point(247, 212);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(88, 20);
            this.lblpromedio.TabIndex = 8;
            this.lblpromedio.Text = "Promedio : ";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(352, 212);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(28, 13);
            this.lblresultado.TabIndex = 9;
            this.lblresultado.Text = "###";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblpromedio);
            this.Controls.Add(this.txtcalif2);
            this.Controls.Add(this.txtcalif3);
            this.Controls.Add(this.txtcalif1);
            this.Controls.Add(this.lblcalif3);
            this.Controls.Add(this.lblcalif2);
            this.Controls.Add(this.lblcalif1);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblcalif1;
        private System.Windows.Forms.Label lblcalif2;
        private System.Windows.Forms.Label lblcalif3;
        private System.Windows.Forms.TextBox txtcalif1;
        private System.Windows.Forms.TextBox txtcalif3;
        private System.Windows.Forms.TextBox txtcalif2;
        private System.Windows.Forms.Label lblpromedio;
        private System.Windows.Forms.Label lblresultado;
    }
}

