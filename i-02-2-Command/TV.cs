using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_02_2_Command
{
    class TV
    {
        string place;

        public TV(string place)
        {
            this.place = place;
        }

        public void on()
        {
            Console.WriteLine("TV is on");
        }

        public void off()
        {
            Console.WriteLine("TV is off");
        }

        public void setInputChannel()
        {
            Console.WriteLine("TV channel is set for DVD");
        }
    }
}
