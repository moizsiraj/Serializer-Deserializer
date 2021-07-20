using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 { 

    class DeserializerFactory {

        public DeserializerFactory() { }

        public static IDeserializer GetDeserializer(FileFormats input, Type type, string filePath) {

            return input switch {
                FileFormats.XML => XMLDeserialize(type, filePath),
                FileFormats.JSON => JSONDeserialize(type, filePath),
                _ => throw new InvalidFileFormatException(),
            };
        }


        private static IDeserializer XMLDeserialize(Type type, string filePath) {

            XMLDeserializer xmlDeserialiser = new(type, filePath);

            return xmlDeserialiser;
        }

        private static IDeserializer JSONDeserialize(Type type, string filePath) {

            JSONDeserializer jsonDeserializer = new(type, filePath);

            return jsonDeserializer;
        }
    }
}
