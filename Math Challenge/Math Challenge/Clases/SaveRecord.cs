using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge.Clases {
    public enum Modo {
        Suma, Resta, Mixto
    }

    public class SaveRecord {
        public Record Record { get; set; }

        private bool NuevoRecord = false;
        private string APPDATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string carpetaDeRecords;
        private string pathArchivo;
        private Modo Modo;

        public SaveRecord(Record Record)
        {
            this.Record = Record;

            //Se aisla el modo elegido para definir el nombre de archivo
            Modo = (Modo)System.Enum.Parse(typeof(Modo), Record.Modo);

            //Se crea la carpeta, si no existe..
            carpetaDeRecords = Path.Combine(APPDATA, "Math Challenge\\Records");
            Directory.CreateDirectory(carpetaDeRecords);

            //Se crea el archivo, si no existe..
            CrearArchivo();

            //Si el archivo se acaba de crear, se analiza el record
            if (NuevoRecord) AnalizarRecord();


            //tw.WriteLine("Nombre: " + Autor + ", Respuestas: " + Respuestas + ", Modo: " + Modo);
        }

        private void CrearArchivo()
        {
            pathArchivo = carpetaDeRecords + "\\rec_" + Modo.ToString() + ".txt";
            if (!File.Exists(pathArchivo))
            {
                TextWriter tw = new StreamWriter(pathArchivo);
                tw.Close();

                //Si no había archivo, lo que llege sera record
                NuevoRecord = true;
            }
        }

        private void AnalizarRecord()
        {

        }
    }
}
