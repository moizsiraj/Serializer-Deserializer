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

        public IDeserializer GetDeserializer(string input, Type type) {

            _Type = type;

            return input switch {
                "XML" => XMLDeserialize(_Type),
                "JSON" => JSONDeserialize(_Type),
                _ => throw new InvalidFileFormatException(),
            };
        }


        private IDeserializer XMLDeserialize(Type type) {

            XMLDeserializer xmlDeserialiser = new(type, _XMLFilePath);

            return xmlDeserialiser;
        }

        private IDeserializer JSONDeserialize(Type type) {

            JSONDeserializer jsonDeserializer = new(type, _JSONFilePath);

            return jsonDeserializer;
        }
    }
}
