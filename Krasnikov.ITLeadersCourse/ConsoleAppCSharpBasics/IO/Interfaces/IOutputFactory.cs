﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpBasics.IO.Interfaces
{
    public abstract class IOutputFactory
    {
        public abstract IOutput GetOutputInstance(Type outputType);
            }
}
