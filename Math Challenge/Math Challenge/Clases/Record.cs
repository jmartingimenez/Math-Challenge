using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge.Clases {
    public class Record {
        public string Autor {get;set;}
        public int Respuestas { get; set; }
        public string Modo { get; set; }

        public Record(string Autor, int Respuestas, string Modo)
        {
            this.Autor = Autor;
            this.Respuestas = Respuestas;
            this.Modo = Modo;

            //Se crea la carpeta, si no existe...
            string APPDATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string carpetaDeRecords = Path.Combine(APPDATA, "Math Challenge\\Records");
            Directory.CreateDirectory(carpetaDeRecords);

            //Se genera el archivo si no existe (Esto aca no va)
            /*string pathArchivo = carpetaDeRecords + "\\rec.txt";
            if (!File.Exists(pathArchivo))
            {
                //File.Create(pathArchivo);
                TextWriter tw = new StreamWriter(pathArchivo);
                tw.WriteLine("Nombre: " + Autor + ", Respuestas: " + Respuestas + ", Modo: " + Modo);
                tw.Close();
            }*/
        }
    }
}
