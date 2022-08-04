using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core.Commands
{
    using Contracts;
    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            Environment.Exit(0);
            return null;
        }
    }
}
