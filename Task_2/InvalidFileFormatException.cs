using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 {
    class InvalidFileFormatException : Exception {

        public InvalidFileFormatException() : base("Invalid File Format") {

        }
    }
}
