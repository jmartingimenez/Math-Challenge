using Math_Challenge.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Math_Challenge.Clases {
    [Serializable]
    public class Record {
        public string Autor {get;set;}
        public int Respuestas { get; set; }
        public ModoDeJuego Modo { get; set; }

        public Record() {}

        public Record(string Autor, int Respuestas, ModoDeJuego Modo)
        {
            this.Autor = Autor;
            this.Respuestas = Respuestas;
            this.Modo = Modo;
        }

        public override string ToString()
        {
            return this.Modo + ": " + this.Autor + ", " +
                this.Respuestas + " respuestas.";  
        }
    }
}