using System;

namespace Task_2 {
    internal class Program {
        private static void Main(string[] args) {
            
            Employee empOne = new("Moiz", 23, "Software Dev");
            
            SerializerFactory serializeFactory = new();
            DeserializerFactory deserializerFactory = new();
            
            Console.WriteLine("Input desired file format (XML/JSON)");
            string fileFormat = Console.ReadLine();

            SerializeCommand serializeCommand = serializeFactory.GetSerializer(fileFormat, typeof(Employee), empOne);
            
            if (serializeCommand == null) {
                Console.WriteLine("Invalid file format");
            }
            else {
                serializeCommand.Execute();
            }
            
            DeserializeCommand deserializeCommand = deserializerFactory.GetDeserializer(fileFormat, typeof(Employee));

            if (deserializeCommand == null) {
                Console.WriteLine("Invalid file format");
            }
            else {
                Employee empTwo = (Employee)deserializeCommand.Execute();
                Console.WriteLine(empTwo.Name);
            }

        }
    }
}
