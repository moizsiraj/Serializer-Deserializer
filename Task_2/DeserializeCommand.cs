using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 {
    internal class DeserializeCommand : ICommand {

        private readonly IDeserializer Deserializer;

        public DeserializeCommand(IDeserializer deserializer) {
            this.Deserializer = deserializer;
        }

        public object Execute() {
            return Deserializer.Deserialize();
        }

    }
}
