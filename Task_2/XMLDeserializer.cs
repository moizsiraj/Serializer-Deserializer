using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task_2 {
    internal class XMLDeserializer : IDeserializer {

        private Type _ObjectType;

        private string _FilePath;

        private XmlSerializer _XmlDeserializer;


        public XMLDeserializer(Type objectType, string filePath) {
            _ObjectType = objectType;
            _FilePath = filePath;
            _XmlDeserializer = new XmlSerializer(_ObjectType);
        }


        public object Deserialize() {

            object deserializedObject = null;

            if (File.Exists(_FilePath)) {
                TextReader textReader = new StreamReader(_FilePath);
                deserializedObject = _XmlDeserializer.Deserialize(textReader);
                textReader.Close();
            }
            
            return deserializedObject;
        }
    }
}
