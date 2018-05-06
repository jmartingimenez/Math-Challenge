using Math_Challenge.Clases;
using Math_Challenge.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Challenge.Forms {
    public partial class RecordForm : Form {
        public RecordForm()
        {
            InitializeComponent();

            Record record = new Record();

            /*Tengo un enum con todos los modos de juego. Recorro 
             para obtener el nombre de cada uno e intentar cargar 
             el archivo correspondiente. Si el archivo no se 
             encuentra muestro que no hay records*/
            foreach (ModoDeJuego modo in Enum.GetValues(typeof(ModoDeJuego)))
            {
                try
                {
                    record = XMLRecord.Cargar(modo);
                    InfoRecordSuma.Text += "\n" + record.ToString() + "\n";
                }
                catch
                {
                    InfoRecordSuma.Text += "\n" + modo.ToString() + ": Sin records.\n";
                }
            }
        }

        private void Boton_Volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}