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
            this.JugadorLabel = new System.Windows.Forms.Label();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.AclaracioRecordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sumar
            // 
            this.Sumar.Location = new System.Drawing.Point(21, 103);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(115, 35);
            this.Sumar.TabIndex = 1;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseVisualStyleBackColor = true;
            this.Sumar.Click += new System.EventHandler(this.Sumar_Click);
            // 
            // Restar
            // 
            this.Restar.Location = new System.Drawing.Point(154, 103);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(115, 35);
            this.Restar.TabIndex = 2;
            this.Restar.Text = "Restar";
            this.Restar.UseVisualStyleBackColor = true;
            this.Restar.Click += new System.EventHandler(this.Restar_Click);
            // 
            // Mixto
            // 
            this.Mixto.Location = new System.Drawing.Point(154, 144);
            this.Mixto.Name = "Mixto";
            this.Mixto.Size = new System.Drawing.Size(115, 37);
            this.Mixto.TabIndex = 4;
            this.Mixto.Text = "Mixto";
            this.Mixto.UseVisualStyleBackColor = true;
            this.Mixto.Click += new System.EventHandler(this.Mixto_Click);
            // 
            // Records
            // 
            this.Records.BackColor = System.Drawing.Color.PapayaWhip;
            this.Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Records.Location = new System.Drawing.Point(21, 192);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(248, 35);
            this.Records.TabIndex = 5;
            this.Records.Text = "Records";
            this.Records.UseVisualStyleBackColor = false;
            this.Records.Click += new System.EventHandler(this.Records_Click);
            // 
            // Instrucciones
            // 
            this.Instrucciones.BackColor = System.Drawing.Color.PapayaWhip;
            this.Instrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instrucciones.Location = new System.Drawing.Point(21, 62);
            this.Instrucciones.Name = "Instrucciones";
            this.Instrucciones.Size = new System.Drawing.Size(248, 35);
            this.Instrucciones.TabIndex = 0;
            this.Instrucciones.Text = "Instrucciones";
            this.Instrucciones.UseVisualStyleBackColor = false;
            this.Instrucciones.Click += new System.EventHandler(this.Instrucciones_Click);
            // 
            // LinkRepositorio
            // 
            this.LinkRepositorio.AutoSize = true;
            this.LinkRepositorio.Location = new System.Drawing.Point(111, 251);
            this.LinkRepositorio.Name = "LinkRepositorio";
            this.LinkRepositorio.Size = new System.Drawing.Size(73, 13);
            this.LinkRepositorio.TabIndex = 6;
            this.LinkRepositorio.TabStop = true;
            this.LinkRepositorio.Text = "Código fuente";
            this.LinkRepositorio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRepositorio_LinkClicked);
            // 
            // Multiplicar
            // 
            this.Multiplicar.Location = new System.Drawing.Point(21, 144);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(115, 37);
            this.Multiplicar.TabIndex = 3;
            this.Multiplicar.Text = "Multiplicar";
            this.Multiplicar.UseVisualStyleBackColor = true;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // JugadorLabel
            // 
            this.JugadorLabel.AutoSize = true;
            this.JugadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JugadorLabel.Location = new System.Drawing.Point(17, 9);
            this.JugadorLabel.Name = "JugadorLabel";
            this.JugadorLabel.Size = new System.Drawing.Size(119, 20);
            this.JugadorLabel.TabIndex = 7;
            this.JugadorLabel.Text = "Tu nombre =>";
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameTextBox.Location = new System.Drawing.Point(155, 9);
            this.PlayerNameTextBox.MaxLength = 10;
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(114, 22);
            this.PlayerNameTextBox.TabIndex = 7;
            this.PlayerNameTextBox.Text = "Jugador";
            this.PlayerNameTextBox.TextChanged += new System.EventHandler(this.PlayerNameTextBox_TextChanged);
            // 
            // AclaracioRecordLabel
            // 
            this.AclaracioRecordLabel.AutoSize = true;
            this.AclaracioRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AclaracioRecordLabel.Location = new System.Drawing.Point(18, 34);
            this.AclaracioRecordLabel.Name = "AclaracioRecordLabel";
            this.AclaracioRecordLabel.Size = new System.Drawing.Size(216, 13);
            this.AclaracioRecordLabel.TabIndex = 7;
            this.AclaracioRecordLabel.Text = "(Tus records se guardaran con este nombre)";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.AclaracioRecordLabel);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Controls.Add(this.JugadorLabel);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
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
        private System.Windows.Forms.Label JugadorLabel;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.Label AclaracioRecordLabel;
    }
}

