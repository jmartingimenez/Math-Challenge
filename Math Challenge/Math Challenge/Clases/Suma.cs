using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*La operación se hace entre dos valores entre el rango 5,49.
 Esto es para que el resultado nunca sea de uno o tres digitos*/
namespace Math_Challenge.Clases {
    class Suma : Calculo {
        public override void Calcular()
        {
            Random random = new Random();
            valor1 = random.Next(5, 49);
            valor2 = random.Next(5, 49);
            resultado = valor1 + valor2;
        }

        public override string MostrarCuenta()
        {
            return valor1 + " + " + valor2 + ": ";
        }
    }
}
