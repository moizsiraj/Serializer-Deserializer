using System;

namespace Task_2 {
    internal class Program {
        private static void Main(string[] args) {
            
            Employee empOne = new("Moiz", 23, "Software Dev");
            
            Console.WriteLine("Input desired file format (XML/JSON)");
            string fileFormat = Console.ReadLine();

            Console.WriteLine("Input desired file path");
            string filePath = Console.ReadLine();

            try {
                ISerializer serializer = SerializerFactory.GetSerializer(fileFormat, typeof(Employee), empOne, filePath);
                SerializeCommand serializeCommand = new(serializer);
                serializeCommand.Execute();
                IDeserializer deserializer = DeserializerFactory.GetDeserializer(fileFormat, typeof(Employee), filePath);
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
