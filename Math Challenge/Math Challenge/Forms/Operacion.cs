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
                string modoJugado = Calculo.GetType().Name.ToString();
                Record record = new Record("Jugador", respuestasCorrectas, modoJugado);
                ArchivoRecord save = new ArchivoRecord(record);

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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            int input = Int32.Parse(this.Resultado.Text);

            //Si la cuenta esta mal, el jugador pierde            
            if (Calculo.resultado != input) derrotarJugador(input);

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

        /*Este método quita todo de la pantalla, detiene el timer 
         y agrega el mensaje de derrota y un botón para volver*/
        private void derrotarJugador(int input)
        {
            //Se detiene el timer
            Timer.Stop();

            //Se oculta todo de la pantalla
            this.Tiempo.Hide();
            this.OperacionLabel.Hide();
            this.Resultado.Hide();
            this.IconoMasContador.Hide();
            this.ContadorRespuestas.Hide();

            //Se hace visible el label con el mensaje 
            this.msjDerrota.Text = "Te equivocaste!!\n" +
                Calculo.MostrarCuenta() + Calculo.resultado +
                "\nIngresaste " + input +
                "\nRespuestas: " + respuestasCorrectas;
            this.msjDerrota.Show();
            this.btnMenu.Show();
        }

        //Se cierra esta form para ver el menú de nuevo
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}