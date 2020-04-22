using System;
using System.Collections.Generic;
using System.Text;

namespace Petrobras_AccidentMonitoring_Tool_Console.Exceptions
{
    class AccidentClassException : Exception
    {        
        public AccidentClassException(string message) : base(message)
        {
            
        }
    }
}
