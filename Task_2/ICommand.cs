﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 {
    internal interface ICommand {

        public object Execute();

        public void Undo();
    }
}
