using System;
using System.Collections.Generic;
using System.Text;

namespace Elvanto.Net.Core
{
    public class ElvantoNotFoundException : Exception
    {
        public ElvantoNotFoundException(string message) : base(message)
        {
        }
    }
}
