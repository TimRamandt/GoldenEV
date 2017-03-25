using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    class VersionCommand : Command
    {
        public VersionCommand(List<string> inputs) : base(inputs) {
            base.checkIsHelpRequested(Inputs);
        }

        public override void Execute()
        {
            string version = ((AssemblyFileVersionAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(),
            typeof(AssemblyFileVersionAttribute), false)).Version;
            Console.WriteLine("[{0}] Current version: {1}", DateTime.Now.ToShortTimeString(), version);
        }

        public override void Help()
        {
            Console.WriteLine("Displays the current version of the application.");
        }

    }
}
