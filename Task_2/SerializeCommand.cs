using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 {
    internal class SerializeCommand : ISerializeCommand {
        private readonly ISerializer Serializer;

        public SerializeCommand(ISerializer serializer) {
            this.Serializer = serializer;
        }

        public void Execute() {
            Serializer.Serialize();
        }

    }
}
