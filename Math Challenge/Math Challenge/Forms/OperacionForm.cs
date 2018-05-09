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
                ArchivoMathChallenge.GuardarRecord(new Record(Jugador.Nombre, _respuestasCorrectas, (ModoDeJuego)Enum.Parse(typeof(ModoDeJuego), modoJugado)));

                _timer.Stop();
                Ocultar_Controles();
                MensajeFelicitaciones_Label(modoJugado);              
            }
        }

        //Método que detecta cuando se presiona alguna tecla
        private void Resultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si se presiona ESCAPE se abandona
            if (e.KeyChar == (char)27) this.Close();
            
            //Cuando se presiona SPACE se borra lo último
            if (e.KeyChar == ' ')
            {
                SendKeys.Send("{BACKSPACE}");
            }

            /*Si se presiona ENTER se controla la operación y 
             se ofrece una nueva*/
            if (e.KeyChar == (char)13 && this.Resultado.Text.Count() > 0)
                Controlar_Resultado();
            
            //Este if controla que solo se ingresen números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void MostrarOperacionActual()
        {
            this.OperacionLabel.Text = _calculo.MostrarCuenta();
        }

        private void Controlar_Resultado()
        {
            int input = Int32.Parse(this.Resultado.Text);

            //Si la cuenta esta mal, el jugador pierde            
            if (_calculo.Resultado != input)
            {
                Ocultar_Controles();
                DerrotarJugador(input);
            }

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

        /*Este método detiene el timer y agrega el mensaje de 
         * derrota y un botón para volver*/
        private void DerrotarJugador(int input)
        {
            //Se detiene el timer
            _timer.Stop();

            //Se hace visible el label con el mensaje 
            this.msjDerrota.Text = "Te equivocaste!!\n" +
                _calculo.MostrarCuenta() + _calculo.Resultado +
                "\nIngresaste " + input +
                "\nRespuestas: " + _respuestasCorrectas;
            this.msjDerrota.Show();
            this.btnMenu.Show();
            this.btnMenu.Focus();
        }

        private void Ocultar_Controles()
        {
            this.Tiempo.Enabled = false;
            this.OperacionLabel.Enabled = false;
            this.Resultado.Enabled = false;
            this.IconoMasContador.Enabled = false;
            this.ContadorRespuestas.Enabled = false;

            this.Tiempo.Hide();
            this.OperacionLabel.Hide();
            this.Resultado.Hide();
            this.IconoMasContador.Hide();
            this.ContadorRespuestas.Hide();
        }

        //Se cierra este form para ver el menú de nuevo
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MensajeFelicitaciones_Label(string modoJugado)
        {
            MensajeFelicitaciones.Text = "Felicidades " + Jugador.Nombre + 
                "!! Duraste 30 segundos.\n" + 
                "Contestaste " + _respuestasCorrectas + " Respuesta(s) correctamente.\n" + 
                "Revisa los records para ver si apareces!!" + 
                "\n\nModo jugado: " + modoJugado;
            this.MensajeFelicitaciones.Show();
            this.btnMenu.Show();
            this.btnMenu.Focus();
        }
    }
}