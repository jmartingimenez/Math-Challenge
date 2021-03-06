﻿namespace Math_Challenge.Forms {
    partial class OperacionForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperacionForm));
            this.OperacionLabel = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Tiempo = new System.Windows.Forms.Label();
            this.IconoMasContador = new System.Windows.Forms.Label();
            this.ContadorRespuestas = new System.Windows.Forms.Label();
            this.msjDerrota = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.MensajeFelicitaciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OperacionLabel
            // 
            this.OperacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperacionLabel.Location = new System.Drawing.Point(12, 136);
            this.OperacionLabel.Name = "OperacionLabel";
            this.OperacionLabel.Size = new System.Drawing.Size(199, 62);
            this.OperacionLabel.TabIndex = 0;
            this.OperacionLabel.Text = "n1 + n2 = ";
            // 
            // Resultado
            // 
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(206, 136);
            this.Resultado.MaxLength = 2;
            this.Resultado.Name = "Resultado";
            this.Resultado.ShortcutsEnabled = false;
            this.Resultado.Size = new System.Drawing.Size(53, 49);
            this.Resultado.TabIndex = 1;
            this.Resultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Resultado_KeyPress);
            // 
            // Tiempo
            // 
            this.Tiempo.AutoSize = true;
            this.Tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiempo.ForeColor = System.Drawing.Color.Red;
            this.Tiempo.Location = new System.Drawing.Point(52, 9);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(188, 108);
            this.Tiempo.TabIndex = 2;
            this.Tiempo.Text = "30\"";
            // 
            // IconoMasContador
            // 
            this.IconoMasContador.AutoSize = true;
            this.IconoMasContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconoMasContador.ForeColor = System.Drawing.Color.Lime;
            this.IconoMasContador.Location = new System.Drawing.Point(201, 198);
            this.IconoMasContador.Name = "IconoMasContador";
            this.IconoMasContador.Size = new System.Drawing.Size(28, 29);
            this.IconoMasContador.TabIndex = 3;
            this.IconoMasContador.Text = "+";
            // 
            // ContadorRespuestas
            // 
            this.ContadorRespuestas.AutoSize = true;
            this.ContadorRespuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorRespuestas.ForeColor = System.Drawing.Color.Lime;
            this.ContadorRespuestas.Location = new System.Drawing.Point(232, 198);
            this.ContadorRespuestas.Name = "ContadorRespuestas";
            this.ContadorRespuestas.Size = new System.Drawing.Size(27, 29);
            this.ContadorRespuestas.TabIndex = 4;
            this.ContadorRespuestas.Text = "0";
            // 
            // msjDerrota
            // 
            this.msjDerrota.AutoSize = true;
            this.msjDerrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msjDerrota.ForeColor = System.Drawing.Color.Red;
            this.msjDerrota.Location = new System.Drawing.Point(28, 21);
            this.msjDerrota.Name = "msjDerrota";
            this.msjDerrota.Size = new System.Drawing.Size(240, 31);
            this.msjDerrota.TabIndex = 5;
            this.msjDerrota.Text = "Te equivocaste!!!";
            this.msjDerrota.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMenu.Location = new System.Drawing.Point(87, 216);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(98, 36);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // MensajeFelicitaciones
            // 
            this.MensajeFelicitaciones.AutoSize = true;
            this.MensajeFelicitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensajeFelicitaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MensajeFelicitaciones.Location = new System.Drawing.Point(12, 36);
            this.MensajeFelicitaciones.Name = "MensajeFelicitaciones";
            this.MensajeFelicitaciones.Size = new System.Drawing.Size(274, 65);
            this.MensajeFelicitaciones.TabIndex = 7;
            this.MensajeFelicitaciones.Text = "Felicidades <Jugador>!! Duraste 30 segundos. \r\n\r\nContestaste XX Respuesta(s) corr" +
    "ectamente.\r\n\r\nRevisa los records para ver si apareces!!";
            this.MensajeFelicitaciones.Visible = false;
            // 
            // OperacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.MensajeFelicitaciones);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.msjDerrota);
            this.Controls.Add(this.ContadorRespuestas);
            this.Controls.Add(this.IconoMasContador);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.OperacionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OperacionForm";
            this.Text = "Jugando - Math Challenge by Yony!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OperacionLabel;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label Tiempo;
        private System.Windows.Forms.Label IconoMasContador;
        private System.Windows.Forms.Label ContadorRespuestas;
        private System.Windows.Forms.Label msjDerrota;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label MensajeFelicitaciones;
    }
}