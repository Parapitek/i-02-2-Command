using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_02_2_Command
{
    class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
        }

        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
        }

        public override string ToString() {
            string result = "\n-------------ПУЛЬТ УПРАВЛЕНИЯ-------------\n";
            for (int i = 0; i < onCommands.Length; i++)
            {
                result += "[КНОПКА " + i + "] " + onCommands[i].GetType().Name;
                result += "\t" + offCommands[i].GetType().Name + "\n";
            }

            return result;
        }
    }
}
