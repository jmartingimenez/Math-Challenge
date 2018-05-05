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
        private static readonly string _dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string _carpetaDeRecords = Path.Combine(_dir, "Math Challenge\\Records");
        private static string _pathArchivo;

        /*Si no puede cargarlo (Ej, no existe el archivo) da nulo*/
        public static Record Cargar(ModoDeJuego modo)
        {
            try
            {
                Record record = new Record();
                _pathArchivo = _carpetaDeRecords + "\\rec_" + modo.ToString() + ".xml";
                XmlSerializer formatter = new XmlSerializer(record.GetType());
                FileStream file = new FileStream(_pathArchivo, FileMode.Open);
                byte[] buffer = new byte[file.Length];
                file.Read(buffer, 0, (int)file.Length);
                MemoryStream ms = new MemoryStream(buffer);
                file.Close();
                record = (Record)formatter.Deserialize(ms);
                return record;
            }
            catch
            {
                return null;
            }
        }

        private static bool RecordNuevo(Record record)
        {
            Record recordViejo = Cargar(record.Modo);

            if (recordViejo == null) return true;

            if (record.Respuestas > recordViejo.Respuestas)
                return true;
            return false;
        }

        public static void Guardar(Record record)
        {
            Directory.CreateDirectory(_carpetaDeRecords);
            if (RecordNuevo(record))
            {
                _pathArchivo = _carpetaDeRecords + "\\rec_" + record.Modo + ".xml";                
                FileStream outFile = File.Create(_pathArchivo);
                XmlSerializer formatter = new XmlSerializer(record.GetType());
                formatter.Serialize(outFile, record);
                outFile.Close();
            }
        }
    }
}