using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6Library
{
    class ProcessorException : Exception
    {
        public ProcessorException(string message) : base(message) { }
    }

    class InvalidFreqException : ProcessorException
    {
        public InvalidFreqException() : base("Processor with this frequency does not exist") { }
    }
}
