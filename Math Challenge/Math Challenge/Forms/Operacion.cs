using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Math_Challenge.Clases;

namespace Math_Challenge.Forms {
    public partial class Operacion : Form {
        private Calculo Calculo;
        private int tiempoLimite = 30;
        private int respuestasCorrectas = 0;
        private Timer Timer;

        public Operacion(Calculo Calculo)
        {
            InitializeComponent();
            this.Calculo = Calculo;
            mostrarOperacionActual();

            Timer = new Timer();
            Timer.Interval = 1000; //Cada un segundo va al tick
            Timer.Enabled = true;
            Timer.Start();
            Timer.Tick += Timer_Tick;        
        }

        //Esto se ejecuta cada segundo del timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempoLimite--;
            Tiempo.Text = tiempoLimite.ToString() + "''";
            if (tiempoLimite == 0)
            {
                //Esto aca no va
                string modoJugado = Calculo.GetType().Name.ToString();
                new Record("Jugador", respuestasCorrectas, modoJugado);

                Timer.Stop();
                this.Close();
            }
        }

        //Método que detecta cuando se presiona alguna tecla
        private void Resultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Si se presiona ENTER se controla la operación y 
             se ofrece una nueva*/
            if (e.KeyChar == (char)13 && this.Resultado.Text.Count() > 0)
                Controlar_Resultado();
            
            //Este if controla que solo se ingresen números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void mostrarOperacionActual()
        {
            this.OperacionLabel.Text = Calculo.MostrarCuenta();
        }

        private void Controlar_Resultado()
        {
            //Si la cuenta esta mal, se cierra la ventana
            int input = Int32.Parse(this.Resultado.Text);
            if (Calculo.resultado != input)
            {
                //MessageBox.Show("Perdiste!!");
                this.Close();
            }

            //Sumamos uno al contador de respuestas correctas
            respuestasCorrectas++;
            ContadorRespuestas.Text = respuestasCorrectas.ToString();
            
            //Vaciamos el input del resultado
            this.Resultado.Text = "";

            //Generamos una nueva operación
            Calculo.Calcular();

            //Mostramos la nueva operación en pantalla
            mostrarOperacionActual();
        }
    }
}