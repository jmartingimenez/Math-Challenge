using Math_Challenge.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge.Clases {
    [Serializable]
    public class Record {
        public string Autor {get;set;}
        public int Respuestas { get; set; }
        public ModoDeJuego Modo { get; set; }

        public Record() {}

        public Record(string autor, int respuestas, ModoDeJuego modo)
        {
            Autor = autor;
            Respuestas = respuestas;
            Modo = modo;
        }

        public override string ToString()
        {
            return Modo + ": " + Autor + " (+" +
                Respuestas + ").";  
        }
    }
}