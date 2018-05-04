using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge.Clases {
    public class SumaResta : Calculo {
        public Calculo CalculoSeleccionado {get;set; }

        public SumaResta()
        {
            Calcular();
        }

        public override void Calcular()
        {
            Random random = new Random();
            if (random.Next(2) == 0) CalculoSeleccionado = new Suma();
            else CalculoSeleccionado = new Resta();

            CalculoSeleccionado.Calcular();

            /*Pongo esto para evitar un NullPointer, ver luego.
             (Se lo llama en 'Operacion.cs')*/
            resultado = CalculoSeleccionado.resultado;            
        }

        public override string MostrarCuenta()
        {
            return CalculoSeleccionado.MostrarCuenta();
        }
    }
}
