using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Task_2 {
    internal class JSONDeserializer : IDeserializer {

        private Type _ObjectType;

        private string _FilePath;

        private JsonSerializer _JsonDeserializer;

        public JSONDeserializer(Type type, string filePath) {
            _ObjectType = type;
            _FilePath = filePath;
            _JsonDeserializer = new JsonSerializer();
        }

        public object Deserialize() {
            JObject deserializedObject = null;

            if (File.Exists(_FilePath)) {
                StreamReader streamReader = new StreamReader(_FilePath);
                JsonReader jsonReader = new JsonTextReader(streamReader);
                deserializedObject = _JsonDeserializer.Deserialize(jsonReader) as JObject;
                jsonReader.Close();
                streamReader.Close();
            }

            return deserializedObject.ToObject(_ObjectType);
        }
    }
}
