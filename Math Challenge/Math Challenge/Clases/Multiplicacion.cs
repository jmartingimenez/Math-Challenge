using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge.Clases {
    class Multiplicacion : Calculo {
        public override void Calcular()
        {
            Random random = new Random();
            Valor1 = random.Next(2, 49);

            if (Valor1 >= 34)
                Valor2 = 2;
            else if (Valor1 <= 3)
                Valor2 = random.Next(4, 33);
            else Valor2 = random.Next(3, 100/Valor1); 
            Resultado = Valor1 * Valor2;
        }

        public override string MostrarCuenta()
        {
            return Valor1 + " x " + Valor2 + ": ";
        }
    }
}