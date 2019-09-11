using System;
using System.Collections.Generic;

namespace PatternsOfDesign.Behavior_patterns.Command.Commands
{
    class CommandHistory
    {
        public int GetIndexCommand(Command command)
        {
            if (_commands.Contains(command))
            {
                return _commands.FindIndex(x => x == command);
            }
            else return 0;
        }

        public int Count => _commands.Count;
        private List<Command> _commands;

        public CommandHistory()
        {
            _commands = new List<Command>();
        }

        public void Push(Command command)
        {
            _commands.Add(command);
        }

        public Command Pop(int indexCommand)
        {
            if (_commands.Count < indexCommand)
            {
                throw new ArgumentOutOfRangeException(nameof(indexCommand));
            }

            return _commands[indexCommand];
        }
    }
}
