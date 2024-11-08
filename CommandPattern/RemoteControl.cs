﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        Stack<ICommand> undoCommand;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = new Stack<ICommand>();
        }

        public void setCommand(int slot, ICommand? onCommand, ICommand? offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
            undoCommand.Push(onCommands[slot]);
        }

        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
            undoCommand.Push(offCommands[slot]);
        }

        public void undoButtonWasPushed() 
        {
            var prevCommand = undoCommand.Pop();
            prevCommand.undo(); 
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n==========Remote Control============\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.Append($"[slot {i}] {onCommands[i].GetType().Name}    {offCommands[i].GetType().Name} \n");
            }
            return stringBuilder.ToString();
        }

    }
}
