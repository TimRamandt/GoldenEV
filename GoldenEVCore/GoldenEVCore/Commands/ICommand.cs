using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenEVCore.Commands
{
    public interface ICommand
    {
        void Execute();
        void Help();
    }
}
