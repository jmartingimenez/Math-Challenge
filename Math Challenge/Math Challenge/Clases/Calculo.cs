using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge.Clases {
    public abstract class Calculo {
        public int Valor1 { set; get; }
        public int Valor2 { set; get; }
        public int Resultado { set; get; }

        public Calculo()
        {            
            Calcular();
        }

        public abstract void Calcular();
        public abstract string MostrarCuenta();
    }
}