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
                SerializeCommand serializeCommand = serializeFactory.GetSerializer(fileFormat, typeof(Employee), empOne);
                serializeCommand.Execute();
                DeserializeCommand deserializeCommand = deserializerFactory.GetDeserializer(fileFormat, typeof(Employee));
                Employee empTwo = (Employee)deserializeCommand.Execute();
                Console.WriteLine(empTwo.Name);
            }
            catch (Exception exception){
                Console.WriteLine(exception.Message);
            }
            

        }
    }
}
