using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*La operación se hace entre un número entre 50 y 99 siendo 
 el primer valor, y un número entre 10 y el primer valor - 10.
 Esto es para evitar que puedan haber resultados negativos o que 
 tengan un solo digito*/
namespace Math_Challenge.Clases {
    class Resta : Calculo {
        public override void Calcular()
        {
            Random random = new Random();
            Valor1 = random.Next(50, 99);
            Valor2 = random.Next(10, Valor1 - 10);
            Resultado = Valor1 - Valor2;
        }

        public override string MostrarCuenta()
        {
            return Valor1 + " - " + Valor2 + ": ";
        }
    }
}