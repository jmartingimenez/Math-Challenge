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
        public string Modo { get; set; }

        [NonSerialized] private string APPDATA;
        [NonSerialized] private string carpetaDeRecords;
        [NonSerialized] private string pathArchivo;

        public Record() {
            //Ruta para %APPDATA%
            APPDATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            //Se crea la carpeta, si no existe..
            carpetaDeRecords = Path.Combine(APPDATA, "Math Challenge\\Records");
            Directory.CreateDirectory(carpetaDeRecords);

            Cargar();
        }

        public Record(string Autor, int Respuestas, string Modo)
        {
            this.Autor = Autor;
            this.Respuestas = Respuestas;
            this.Modo = Modo;

            //Ruta para %APPDATA%
            APPDATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            //Se crea la carpeta, si no existe..
            carpetaDeRecords = Path.Combine(APPDATA, "Math Challenge\\Records");
            Directory.CreateDirectory(carpetaDeRecords);

            Guardar();
        }

        public Record Cargar()
        {
            pathArchivo = carpetaDeRecords + "\\rec_Test.xml";
            XmlSerializer formatter = new XmlSerializer(this.GetType());
            FileStream File = new FileStream(pathArchivo, FileMode.Open);
            byte[] buffer = new byte[File.Length];
            File.Read(buffer, 0, (int)File.Length);
            MemoryStream ms = new MemoryStream(buffer);
            File.Close();
            return (Record)formatter.Deserialize(ms);
        }

        public void Guardar()
        {
            pathArchivo = carpetaDeRecords + "\\rec_Test.xml";
            FileStream outFile = File.Create(pathArchivo);
            XmlSerializer formatter = new XmlSerializer(this.GetType());
            formatter.Serialize(outFile, this);
            outFile.Close();
        }

        public override string ToString()
        {
            string mensaje =  this.Modo + ": " + this.Autor + ", " + 
                this.Respuestas + " respuestas.";
            return mensaje;
        }
    }
}