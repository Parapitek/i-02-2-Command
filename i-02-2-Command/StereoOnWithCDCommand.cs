using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_02_2_Command
{
    class StereoOnWithCDCommand : Command
    {
        private Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.on();
            stereo.setCd();
            stereo.setVolume(11);
        }
    }
}
