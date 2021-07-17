using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 { 

    class DeserializerFactory {

        private string _JSONFilePath = "D:/Coding/Assignments/Assignment_1/Task_2/Task_2/Outputs/OutputJSON.json";
        private string _XMLFilePath = "D:/Coding/Assignments/Assignment_1/Task_2/Task_2/Outputs/OutputXML.xml";

        private Type _Type;

        public DeserializerFactory() { }

        public DeserializeCommand getDeserializer(string input, Type type) {

            _Type = type;

            switch (input) {

                case "XML":
                    return XMLDeserialize(_Type);
                case "JSON":
                    return JSONDeserialize(_Type);
                default:
                    return null;
            }
           
        }


        private DeserializeCommand XMLDeserialize(Type type) {

            XMLDeserializer xmlDeserialiser = new(type, _XMLFilePath);
            DeserializeCommand deserializeCommand = new(xmlDeserialiser);

            return deserializeCommand;
        }

        private DeserializeCommand JSONDeserialize(Type type) {

            JSONDeserializer jsonDeserializer = new(type, _JSONFilePath);
            DeserializeCommand deserializeCommand = new(jsonDeserializer);

            return deserializeCommand;
        }
    }
}
