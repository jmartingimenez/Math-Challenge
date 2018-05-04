using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge.Clases {
    public enum Modo {
        Suma, Resta, SumaResta
    }

    public class ArchivoRecord {
        public Record Record { get; set; }

        private bool NuevoRecord = false;
        private string APPDATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string carpetaDeRecords;
        private string pathArchivo;
        private Modo Modo;

        public ArchivoRecord(Record Record)
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
        }

        private void CrearArchivo()
        {
            pathArchivo = carpetaDeRecords + "\\rec_" + Modo.ToString() + ".dat";
            if (!File.Exists(pathArchivo))
            {
                //Si no había archivo, lo que llege sera record
                NuevoRecord = true;

                //Pasar objeto y path para guardar
                guardar();                
            }
        }

        private void AnalizarRecord()
        {

        }

        private void guardar()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream file = File.OpenWrite(pathArchivo))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bf.Serialize(ms, Record);
                }
            }
        }
    }
}
