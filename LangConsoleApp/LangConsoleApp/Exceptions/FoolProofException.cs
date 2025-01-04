using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp.Exceptions
{
    internal class FoolProofException : Exception
    {
        public FoolProofException() : base()
        {

        }

        public FoolProofException(string message) : base($"FoolProofException: {message}")
        {
        }
    }
}
