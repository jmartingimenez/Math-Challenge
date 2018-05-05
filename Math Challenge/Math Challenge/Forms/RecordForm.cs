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
            //InfoRecordSuma.Text = "No hay Records";

            Record record = new Record();
            InfoRecordSuma.Text = record.ToString();
        }
    }
}
