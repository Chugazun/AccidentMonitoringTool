using System;

namespace Petrobras_AccidentsMonitoring_Tool.Exceptions
{
    class InvalidDateException : Exception
    {
        public InvalidDateException(string message) : base(message)
        {

        }
    }
}
