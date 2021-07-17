using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace Task_2 {
    [Serializable()]
    public class Employee : ISerializable {

        public Employee() { }
        public Employee(string name, int age, string designation) {

            Name = name;
            Age = age;
            Designation = designation;
            

        }

        private string Name { get; set; }

        public int Age { get; set; }

        public string Designation { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            info.AddValue("Name", Name);
            info.AddValue("Age", Age);
            info.AddValue("Designation", Designation);
        }

        public Employee(SerializationInfo info, StreamingContext context) {
            Name = (string)info.GetValue("Name", typeof(string));
            Age = (int)info.GetValue("Age", typeof(int));
            Designation = (string)info.GetValue("Designation", typeof(string));

        }
    }
}
