using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 {
    internal class SerializeCommand : ICommand {
        private readonly ISerializer Serializer;

        public SerializeCommand(ISerializer serializer) {
            this.Serializer = serializer;
        }

        public object Execute() {
            Serializer.Serialize();
            return null; //ask what is better practice here.
        }

        public void Undo() {
            throw new NotImplementedException();
        }
    }
}
