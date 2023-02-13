using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_02_2_Command
{
    class LightOnCommand : Command
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.on();
        }
    }
}
