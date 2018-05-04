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
            this.RecordSuma = new System.Windows.Forms.Label();
            this.InfoRecordSuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RecordSuma
            // 
            this.RecordSuma.AutoSize = true;
            this.RecordSuma.Location = new System.Drawing.Point(22, 40);
            this.RecordSuma.Name = "RecordSuma";
            this.RecordSuma.Size = new System.Drawing.Size(40, 13);
            this.RecordSuma.TabIndex = 0;
            this.RecordSuma.Text = "Suma: ";
            // 
            // InfoRecordSuma
            // 
            this.InfoRecordSuma.AutoSize = true;
            this.InfoRecordSuma.Location = new System.Drawing.Point(68, 40);
            this.InfoRecordSuma.Name = "InfoRecordSuma";
            this.InfoRecordSuma.Size = new System.Drawing.Size(142, 13);
            this.InfoRecordSuma.TabIndex = 1;
            this.InfoRecordSuma.Text = "Pepe Pompin, 15 respuestas";
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.InfoRecordSuma);
            this.Controls.Add(this.RecordSuma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RecordForm";
            this.Text = "Menú - Math Challenge by Yony!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecordSuma;
        private System.Windows.Forms.Label InfoRecordSuma;
    }
}