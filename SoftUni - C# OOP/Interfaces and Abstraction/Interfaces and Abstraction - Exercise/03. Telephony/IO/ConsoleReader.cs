using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Telephony.IO
{
    using Interfaces;
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            string text = Console.ReadLine();
            return text;
        }
    }
}
