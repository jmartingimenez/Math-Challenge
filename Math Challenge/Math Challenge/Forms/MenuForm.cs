using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Math_Challenge.Forms;
using Math_Challenge.Clases;

namespace Math_Challenge {
    public partial class Menu : Form {
        public Menu()
        {
            InitializeComponent();
            Jugador.Nombre = ArchivoMathChallenge.CargarNombreDeJugador();
            PlayerNameTextBox.Text = Jugador.Nombre;
        }

        private void AnyButtonClickOnMenu(Form form)
        {
            //Oculto la ventana del menú
            Hide();

            /*Determino que la nueva ventana empezara en el 
             mismo lugar donde estaba la ventana principal y 
             la muestro*/
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.ShowDialog();

            /*Cuando llega aca es porque se cerro la nueva 
             ventana. Seteo la posición de la ventana de menú 
             en el mismo lugar en el que estaba la ventana recien 
             cerrada y luego la vuelvo a mostrar. (Lo de la 
             localización es para evitar que yo mueva la ventana y 
             cuando la cierre, la ventana original aparezca en el 
             lugar anterior en vez de donde la movi)*/
            this.Location = form.Location;
            Show();

            //Esto esta de mas, quitarlo cuando termine las pruebas
            form = null;    
        }

        private void Menu_Load(object sender, EventArgs e){}

        private void Instrucciones_Click(object sender, EventArgs e)
        {
            AnyButtonClickOnMenu(new Instrucciones());
        }

        private void Sumar_Click(object sender, EventArgs e)
        {
            AnyButtonClickOnMenu(new OperacionForm(new Suma()));
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            AnyButtonClickOnMenu(new OperacionForm(new Resta()));
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            AnyButtonClickOnMenu(new OperacionForm(new Multiplicacion()));
        }

        private void Mixto_Click(object sender, EventArgs e)
        {
            AnyButtonClickOnMenu(new OperacionForm(new Mixto()));
        }

        private void Records_Click(object sender, EventArgs e)
        {
            AnyButtonClickOnMenu(new RecordForm());
        }

        private void LinkRepositorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jmartingimenez/Math-Challenge");
        }

        private void PlayerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PlayerNameTextBox.Text.Length == 0)
                Jugador.Nombre = "Anónimo";
            else Jugador.Nombre = PlayerNameTextBox.Text;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ArchivoMathChallenge.GuardarNombreDeJugador();
        }
    }
}