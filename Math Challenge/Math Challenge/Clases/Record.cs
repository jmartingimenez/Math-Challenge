using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge.Clases {
    [Serializable]
    public class Record {
        public string Autor {get;set;}
        public int Respuestas { get; set; }
        public string Modo { get; set; }

        public Record(string Autor, int Respuestas, string Modo)
        {
            this.Autor = Autor;
            this.Respuestas = Respuestas;
            this.Modo = Modo;
        }
    }
}