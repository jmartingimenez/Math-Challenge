﻿using System;
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
            Valor1 = random.Next(5, 49);
            Valor2 = random.Next(5, 49);
            Resultado = Valor1 + Valor2;
        }

        public override string MostrarCuenta()
        {
            return Valor1 + " + " + Valor2 + ": ";
        }
    }
}