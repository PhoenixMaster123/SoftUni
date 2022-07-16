using System;

namespace _03._Telephony
{
    using IO;
    using Core;
    using IO.Interfaces;
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader,writer);
            engine.Run();
        }
    }
}
