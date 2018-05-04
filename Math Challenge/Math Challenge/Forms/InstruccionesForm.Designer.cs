namespace Math_Challenge {
    partial class Instrucciones {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instrucciones));
            this.Info = new System.Windows.Forms.Label();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Info.Location = new System.Drawing.Point(33, 26);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(226, 147);
            this.Info.TabIndex = 0;
            this.Info.Text = resources.GetString("Info.Text");
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(36, 190);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(223, 43);
            this.Volver.TabIndex = 1;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Instrucciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Instrucciones";
            this.Text = "Instrucciones - Math Challenge by Yony!";
            this.Load += new System.EventHandler(this.Instrucciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Button Volver;
    }
}