﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 { 

    class SerializerFactory {

        private string _JSONFilePath = "D:/Coding/Assignments/Assignment_1/Task_2/Task_2/Outputs/OutputJSON.json";
        private string _XMLFilePath = "D:/Coding/Assignments/Assignment_1/Task_2/Task_2/Outputs/OutputXML.xml";

        private Type _Type;
        private object _ObjectData;

        public SerializerFactory() {}

        public ISerializer GetSerializer(string input, Type type, object objectData) {

            _Type = type;
            _ObjectData = objectData;

            return input switch {
                "XML" => XMLSerialize(_Type, _ObjectData),
                "JSON" => JSONSerialize(_ObjectData),
                _ => throw new InvalidFileFormatException(),
            };
        }


        private ISerializer XMLSerialize(Type type, object objectData) {

            XMLSerializer xmlSerializer = new(type, objectData, _XMLFilePath);

            return xmlSerializer;
        }

        private ISerializer JSONSerialize(object objectData) {

            JSONSerializer jsonSerializer = new(objectData, _JSONFilePath);

            return jsonSerializer;
        }
    }
}
