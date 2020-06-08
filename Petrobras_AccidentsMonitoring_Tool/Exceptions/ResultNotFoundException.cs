using System;

namespace Petrobras_AccidentsMonitoring_Tool.Exceptions
{
    class ResultNotFoundException : Exception
    {
        public ResultNotFoundException(string message) : base(message)
        {

        }
    }
}
