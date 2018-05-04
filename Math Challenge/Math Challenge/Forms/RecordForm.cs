using Math_Challenge.Clases;
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
            ArchivoRecord a = new ArchivoRecord();
            InfoRecordSuma.Text = a.Record.Autor + ", " + 
                a.Record.Respuestas + " respuestas.";
        }
    }
}
