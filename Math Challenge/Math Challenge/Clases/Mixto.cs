using Math_Challenge.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge.Clases {
    public class Mixto : Calculo {
        public Calculo CalculoSeleccionado {get;set; }

        public override void Calcular()
        {
            CalculoSeleccionado = CrearCalculo(ElegirModoAlAzar());
            Valor1 = CalculoSeleccionado.Valor1;
            Valor2 = CalculoSeleccionado.Valor2;
            Resultado = CalculoSeleccionado.Resultado;            
        }

        //Esto retorna un item del enum al azar (Excepto el mixto)
        private ModoDeJuego ElegirModoAlAzar()
        {
            Random random = new Random();
            List<ModoDeJuego> modos = Enum.GetValues(typeof(ModoDeJuego))
                .Cast<ModoDeJuego>().ToList();
            modos.Remove(ModoDeJuego.Mixto);
            ModoDeJuego modoElegido = modos[random.Next(modos.Count)];
            return modoElegido;
        }

        //Esto crearia el objeto basado en un enum
        private Calculo CrearCalculo(ModoDeJuego modoElegido)
        {
            return (Calculo)Activator.CreateInstance(Type.GetType("Math_Challenge.Clases." + modoElegido.ToString()));
        }

        public override string MostrarCuenta()
        {
            return CalculoSeleccionado.MostrarCuenta();
        }
    }
}