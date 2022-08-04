using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CommandPattern.Core
{
    using Contracts;
    using System.Linq;
    using System.Reflection;
    

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] command = args.Split(' ');
            string name = command[0];
            string[] argument =command.Skip(1).ToArray();

            Assembly assembly  = Assembly.GetCallingAssembly();
            Type commandType = assembly.GetTypes().FirstOrDefault(t => t.Name == $"{name}Command"); // && t.GetInterfaces().Any(t => t == typeof(ICommand)));

            if(commandType == null)
            {
                throw new InvalidOperationException($"Provided type {name}Command does not exist");
            }
            object commandInstance = Activator.CreateInstance(commandType);
            MethodInfo execudeMethod = commandType.GetMethods().First(command => command.Name == "Execute");
            string result = (string)execudeMethod.Invoke(commandInstance,new object[] {argument}); // Invoke -> execute method to some object
            
            return result;
            
        }
    }
}
