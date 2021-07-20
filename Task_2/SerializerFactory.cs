using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 { 

    class SerializerFactory {

        public SerializerFactory() {}

        public static ISerializer GetSerializer(FileFormats input, Type type, object objectData, string filePath) {

            return input switch {
                FileFormats.XML => XMLSerialize(type, objectData, filePath),
                FileFormats.JSON => JSONSerialize(objectData, filePath),
                _ => throw new InvalidFileFormatException(),
            };
        }


        private static ISerializer XMLSerialize(Type type, object objectData, string filePath) {

            XMLSerializer xmlSerializer = new(type, objectData, filePath);

            return xmlSerializer;
        }

        private static ISerializer JSONSerialize(object objectData, string filePath) {

            JSONSerializer jsonSerializer = new(objectData, filePath);

            return jsonSerializer;
        }
    }
}
