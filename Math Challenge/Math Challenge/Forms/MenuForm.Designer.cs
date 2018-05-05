namespace Math_Challenge {
    partial class Menu {
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
            this.Sumar = new System.Windows.Forms.Button();
            this.Restar = new System.Windows.Forms.Button();
            this.Mixto = new System.Windows.Forms.Button();
            this.Records = new System.Windows.Forms.Button();
            this.Instrucciones = new System.Windows.Forms.Button();
            this.LinkRepositorio = new System.Windows.Forms.LinkLabel();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sumar
            // 
            this.Sumar.Location = new System.Drawing.Point(21, 113);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(115, 38);
            this.Sumar.TabIndex = 0;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseVisualStyleBackColor = true;
            this.Sumar.Click += new System.EventHandler(this.Sumar_Click);
            // 
            // Restar
            // 
            this.Restar.Location = new System.Drawing.Point(154, 113);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(115, 38);
            this.Restar.TabIndex = 1;
            this.Restar.Text = "Restar";
            this.Restar.UseVisualStyleBackColor = true;
            this.Restar.Click += new System.EventHandler(this.Restar_Click);
            // 
            // Mixto
            // 
            this.Mixto.Location = new System.Drawing.Point(154, 169);
            this.Mixto.Name = "Mixto";
            this.Mixto.Size = new System.Drawing.Size(115, 38);
            this.Mixto.TabIndex = 2;
            this.Mixto.Text = "Mixto";
            this.Mixto.UseVisualStyleBackColor = true;
            this.Mixto.Click += new System.EventHandler(this.Mixto_Click);
            // 
            // Records
            // 
            this.Records.Location = new System.Drawing.Point(21, 223);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(248, 38);
            this.Records.TabIndex = 3;
            this.Records.Text = "Records";
            this.Records.UseVisualStyleBackColor = true;
            this.Records.Click += new System.EventHandler(this.Records_Click);
            // 
            // Instrucciones
            // 
            this.Instrucciones.Location = new System.Drawing.Point(21, 59);
            this.Instrucciones.Name = "Instrucciones";
            this.Instrucciones.Size = new System.Drawing.Size(248, 38);
            this.Instrucciones.TabIndex = 4;
            this.Instrucciones.Text = "Instrucciones";
            this.Instrucciones.UseVisualStyleBackColor = true;
            this.Instrucciones.Click += new System.EventHandler(this.Instrucciones_Click);
            // 
            // LinkRepositorio
            // 
            this.LinkRepositorio.AutoSize = true;
            this.LinkRepositorio.Location = new System.Drawing.Point(109, 34);
            this.LinkRepositorio.Name = "LinkRepositorio";
            this.LinkRepositorio.Size = new System.Drawing.Size(73, 13);
            this.LinkRepositorio.TabIndex = 5;
            this.LinkRepositorio.TabStop = true;
            this.LinkRepositorio.Text = "Código fuente";
            this.LinkRepositorio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRepositorio_LinkClicked);
            // 
            // Multiplicar
            // 
            this.Multiplicar.Location = new System.Drawing.Point(21, 169);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(115, 38);
            this.Multiplicar.TabIndex = 6;
            this.Multiplicar.Text = "Multiplicar";
            this.Multiplicar.UseVisualStyleBackColor = true;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.LinkRepositorio);
            this.Controls.Add(this.Instrucciones);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.Mixto);
            this.Controls.Add(this.Restar);
            this.Controls.Add(this.Sumar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menú - Math Challenge by Yony!";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sumar;
        private System.Windows.Forms.Button Restar;
        private System.Windows.Forms.Button Mixto;
        private System.Windows.Forms.Button Records;
        private System.Windows.Forms.Button Instrucciones;
        private System.Windows.Forms.LinkLabel LinkRepositorio;
        private System.Windows.Forms.Button Multiplicar;
    }
}

