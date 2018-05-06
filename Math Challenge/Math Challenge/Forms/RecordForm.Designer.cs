namespace Math_Challenge.Forms {
    partial class RecordForm {
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
            this.InfoRecordSuma = new System.Windows.Forms.Label();
            this.Boton_Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoRecordSuma
            // 
            this.InfoRecordSuma.AutoSize = true;
            this.InfoRecordSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoRecordSuma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoRecordSuma.Location = new System.Drawing.Point(22, 40);
            this.InfoRecordSuma.Name = "InfoRecordSuma";
            this.InfoRecordSuma.Size = new System.Drawing.Size(0, 15);
            this.InfoRecordSuma.TabIndex = 1;
            // 
            // Boton_Volver
            // 
            this.Boton_Volver.Location = new System.Drawing.Point(25, 208);
            this.Boton_Volver.Name = "Boton_Volver";
            this.Boton_Volver.Size = new System.Drawing.Size(245, 42);
            this.Boton_Volver.TabIndex = 2;
            this.Boton_Volver.Text = "Volver";
            this.Boton_Volver.UseVisualStyleBackColor = true;
            this.Boton_Volver.Click += new System.EventHandler(this.Boton_Volver_Click);
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.Boton_Volver);
            this.Controls.Add(this.InfoRecordSuma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RecordForm";
            this.Text = "Records - Math Challenge by Yony!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InfoRecordSuma;
        private System.Windows.Forms.Button Boton_Volver;
    }
}