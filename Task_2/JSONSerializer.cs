using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Task_2 {
    internal class JSONSerializer : ISerializer {

        private object _ObjectData;

        private string _FilePath;

        private JsonSerializer _JSONSerializer;

        public JSONSerializer(object objectData, string filePath) {
            _ObjectData = objectData;
            _FilePath = filePath;
            _JSONSerializer = new JsonSerializer();
        }

        void ISerializer.Serialize() {
            if (File.Exists(_FilePath)) {
                File.Delete(_FilePath);
            }
            StreamWriter streamWriter = new(_FilePath);
            JsonWriter jsonWriter = new JsonTextWriter(streamWriter);
            _JSONSerializer.Serialize(jsonWriter, _ObjectData);
            jsonWriter.Close();
            streamWriter.Close();
        }
    }
}
