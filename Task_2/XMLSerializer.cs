using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task_2 {
  
    internal class XMLSerializer : ISerializer {

        private Type _ObjectType;

        private object _ObjectData;

        private string _FilePath;

        private XmlSerializer _XmlSerializer;

        public XMLSerializer(Type objectType, object objectData, string filePath) {
            _ObjectType = objectType;
            _ObjectData = objectData;
            _FilePath = filePath;
            _XmlSerializer = new XmlSerializer(_ObjectType);
        }


        void ISerializer.Serialize() {
            if (File.Exists(_FilePath)) {
                File.Delete(_FilePath);
            }

            TextWriter textWriter = new StreamWriter(_FilePath);
            _XmlSerializer.Serialize(textWriter, _ObjectData);
            textWriter.Close();

        }
    }
}
