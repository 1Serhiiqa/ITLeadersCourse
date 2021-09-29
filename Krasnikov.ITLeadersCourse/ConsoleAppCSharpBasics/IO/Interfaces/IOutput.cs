using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpBasics.IO.Interfaces
{
    public interface IOutput
    {
        void Write(object output = null); //only output

        void WriteLine(object output = null); //output + enter
    }
}
