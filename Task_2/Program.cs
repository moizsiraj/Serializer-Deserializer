using System;

namespace Task_2 {
    internal class Program {
        private static void Main(string[] args) {
            
            Employee empOne = new("Moiz", 23, "Software Dev");
            
            SerializerFactory serializeFactory = new();
            DeserializerFactory deserializerFactory = new();
            
            Console.WriteLine("Input desired file format (XML/JSON)");
            string fileFormat = Console.ReadLine();
            try {
                ISerializer serializer = serializeFactory.GetSerializer(fileFormat, typeof(Employee), empOne);
                SerializeCommand serializeCommand = new(serializer);
                serializeCommand.Execute();
                IDeserializer deserializer = deserializerFactory.GetDeserializer(fileFormat, typeof(Employee));
                DeserializeCommand deserializeCommand = new(deserializer);
                Employee empTwo = (Employee)deserializeCommand.Execute();
                Console.WriteLine(empTwo.Name);
            }
            catch (Exception exception){
                Console.WriteLine(exception.Message);
            }
            

        }
    }
}
