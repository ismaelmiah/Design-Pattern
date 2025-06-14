using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControl
    {
        private ICommand[] onCommands;
        private ICommand[] offCommands;
        private Stack<ICommand> commandHistory;
        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];
            commandHistory = new Stack<ICommand>();
            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            commandHistory.Push(onCommands[slot]);
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            commandHistory.Push(offCommands[slot]);
        }

        public void UndoButtonWasPushed()
        {
            if (commandHistory.Count > 0)
            {
                ICommand lastCommand = commandHistory.Pop();
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("No commands to undo");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n----- Remote Control -----");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.AppendLine($"[slot {i}] {onCommands[i].GetType().Name}    {offCommands[i].GetType().Name}");
            }
            return sb.ToString();
        }
    }
}
