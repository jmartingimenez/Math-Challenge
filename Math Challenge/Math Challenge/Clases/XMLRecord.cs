using Math_Challenge.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Math_Challenge.Clases {
    public static class XMLRecord {
        private static readonly string APPDATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string carpetaDeRecords = Path.Combine(APPDATA, "Math Challenge\\Records");
        private static string pathArchivo;

        public static void Guardar(Record record)
        {
            pathArchivo = carpetaDeRecords + "\\rec_" + record.Modo + ".xml";
            Directory.CreateDirectory(carpetaDeRecords);
            FileStream outFile = File.Create(pathArchivo);
            XmlSerializer formatter = new XmlSerializer(record.GetType());
            formatter.Serialize(outFile, record);
            outFile.Close();
        }

        public static Record Cargar(ModoDeJuego modo)
        {
            Record record = new Record();
            pathArchivo = carpetaDeRecords + "\\rec_" + modo.ToString() + ".xml";
            XmlSerializer formatter = new XmlSerializer(record.GetType());
            FileStream File = new FileStream(pathArchivo, FileMode.Open);
            byte[] buffer = new byte[File.Length];
            File.Read(buffer, 0, (int)File.Length);
            MemoryStream ms = new MemoryStream(buffer);
            File.Close();
            record = (Record)formatter.Deserialize(ms);
            return record;
        }
    }
}
