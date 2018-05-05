using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Challenge {
    public partial class Instrucciones : Form {
        public Instrucciones()
        {
            InitializeComponent();
        }

        private void Instrucciones_Load(object sender, EventArgs e){}

        private void Volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}