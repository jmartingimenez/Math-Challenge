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
using Math_Challenge.Enums;

namespace Math_Challenge.Forms {
    public partial class OperacionForm : Form {
        private Calculo _calculo;
        private int _tiempoLimite = 30;
        private int _respuestasCorrectas = 0;
        private Timer _timer;

        public OperacionForm(Calculo calculo)
        {
            InitializeComponent();
            _calculo = calculo;
            MostrarOperacionActual();

            _timer = new Timer();
            _timer.Interval = 1000; //Cada un segundo va al tick
            _timer.Enabled = true;
            _timer.Start();
            _timer.Tick += Timer_Tick;        
        }

        //Esto se ejecuta cada segundo del timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            _tiempoLimite--;
            Tiempo.Text = _tiempoLimite.ToString() + "''";
            if (_tiempoLimite == 0)
            {
                string modoJugado = _calculo.GetType().Name.ToString();
                XMLRecord.Guardar(new Record("Jugador", _respuestasCorrectas, (ModoDeJuego)Enum.Parse(typeof(ModoDeJuego), modoJugado)));

                _timer.Stop();
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

        private void MostrarOperacionActual()
        {
            this.OperacionLabel.Text = _calculo.MostrarCuenta();
        }

        private void Controlar_Resultado()
        {
            int input = Int32.Parse(this.Resultado.Text);

            //Si la cuenta esta mal, el jugador pierde            
            if (_calculo.Resultado != input) DerrotarJugador(input);

            //Sumamos uno al contador de respuestas correctas
            _respuestasCorrectas++;
            ContadorRespuestas.Text = _respuestasCorrectas.ToString();
            
            //Vaciamos el input del resultado
            this.Resultado.Text = "";

            //Generamos una nueva operación
            _calculo.Calcular();

            //Mostramos la nueva operación en pantalla
            MostrarOperacionActual();
        }

        /*Este método quita todo de la pantalla, detiene el timer 
         y agrega el mensaje de derrota y un botón para volver*/
        private void DerrotarJugador(int input)
        {
            //Se detiene el timer
            _timer.Stop();

            //Se oculta todo de la pantalla
            this.Tiempo.Hide();
            this.OperacionLabel.Hide();
            this.Resultado.Hide();
            this.IconoMasContador.Hide();
            this.ContadorRespuestas.Hide();

            //Se hace visible el label con el mensaje 
            this.msjDerrota.Text = "Te equivocaste!!\n" +
                _calculo.MostrarCuenta() + _calculo.Resultado +
                "\nIngresaste " + input +
                "\nRespuestas: " + _respuestasCorrectas;
            this.msjDerrota.Show();
            this.btnMenu.Show();
        }

        //Se cierra esta form para ver el menú de nuevo
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}