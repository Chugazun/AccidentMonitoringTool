using System;
using System.Collections.Generic;
using System.Text;

namespace Petrobras_AccidentsMonitoring_Tool.Exceptions
{
    class AccidentClassException : Exception
    {        
        public AccidentClassException(string message) : base(message)
        {
            
        }
    }
}
