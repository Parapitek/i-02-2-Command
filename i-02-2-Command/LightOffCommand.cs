using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_02_2_Command
{
    class LightOffCommand : Command
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.off();
        }
    }
}
