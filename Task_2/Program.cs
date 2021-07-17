using System;

namespace Task_2 {
    internal class Program {
        private static void Main(string[] args) {

            Employee empOne = new("Moiz", 23, "Software Dev");
            SerializerFactory serializeFactory = new();
            SerializeCommand serializeCommand = serializeFactory.getSerializer("JSON", typeof(Employee), empOne);
            serializeCommand.Execute();
            
            /*Console.WriteLine("Deserialization Start");
            XMLDeserializer xmlDeserialiser = new(typeof(Employee), XMLFilePath);
            DeserializeCommand deserializeCommand = new(xmlDeserialiser);
            Employee empTwo = (Employee)deserializeCommand.Execute();
            Console.WriteLine(empTwo.Name);

            Console.WriteLine("JSON");
            Console.WriteLine("Serialization Start");
            Employee empThree = new("Haris", 22, "Web Dev");
            JSONSerializer jsonSerializer = new(empThree, JSONFilePath);
            serializeCommand = new(jsonSerializer);
            serializeCommand.Execute();

            Console.WriteLine("Deserialization Start");
            JSONDeserializer jsonDeserializer = new(typeof(Employee), JSONFilePath);
            deserializeCommand = new(jsonDeserializer);
            Employee empFour = (Employee)deserializeCommand.Execute();
            Console.WriteLine(empFour.Name);*/

        }
    }
}
