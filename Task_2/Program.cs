using System;

namespace Task_2 {
    internal class Program {
        private static void Main(string[] args) {
            Employee empOne = new("Moiz", 23, "Software Dev");
            Console.WriteLine("Serialization Start");
            XMLSerializer xmlSerializer = new(typeof(Employee), empOne, "./Outputs.xml");
            SerializeCommand serializeCommand = new(xmlSerializer);
            serializeCommand.Execute();
            Console.WriteLine("Deserialization Start");
            XMLDeserializer xmlDeserialiser = new(typeof(Employee), "./Outputs.xml");
            DeserializeCommand deserializeCommand = new(xmlDeserialiser);
            Employee empTwo = (Employee)deserializeCommand.Execute();
            Console.WriteLine(empTwo.Designation);
        }
    }
}
