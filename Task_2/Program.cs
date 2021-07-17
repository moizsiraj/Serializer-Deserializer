using System;

namespace Task_2 {
    internal class Program {
        private static void Main(string[] args) {

            Employee empOne = new("Moiz", 23, "Software Dev");
            SerializerFactory serializeFactory = new();
            DeserializerFactory deserializerFactory = new();
            SerializeCommand serializeCommand = serializeFactory.getSerializer("JSON", typeof(Employee), empOne);
            serializeCommand.Execute();
            DeserializeCommand deserializeCommand = deserializerFactory.getDeserializer("JSON", typeof(Employee));
            Employee empTwo = (Employee)deserializeCommand.Execute();
            Console.WriteLine(empTwo.Name);

        }
    }
}
