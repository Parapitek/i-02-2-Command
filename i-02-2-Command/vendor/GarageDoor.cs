using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_02_2_Command
{
    public class GarageDoor
    {
        string location;

        public GarageDoor(string location)
        {
            this.location = location;
        }


        public void up()
        {
            Console.WriteLine("Дверь гаража открывается");
        }

        public void down()
        {
            Console.WriteLine("Дверь гаража закрывается");
        }

        public void stop()
        {
            Console.WriteLine("Движение двери гаража останавливается");
        }

        public void lightOn()
        {
            Console.WriteLine("Освещение гаражной двери включено");
        }

        public void lightOff()
        {
            Console.WriteLine("Освещение гаражной двери выключено");
        }
    }
}
