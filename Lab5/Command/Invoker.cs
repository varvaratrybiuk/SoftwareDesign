using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Invoker
    {
        public List<ICommand> Commands { private get; set; }

        public Invoker(List<ICommand> commands)
        {
            Commands = commands;
        }
        public void ExecAllCommand()
        {
            Commands.ForEach(command => command.Execute());
        }

        public void UndoAllCommand()
        {
            Commands.ForEach(command => command.Undo());
        }
    }
}
