using System;

namespace i_02_2_Command
{
    internal class Light
    {
        private string place;

        public Light(string place)
        {
            this.place = place;
        }

        public void on()
        {
            Console.WriteLine("Свет в " + place + " включен");
        }

        public void off()
        {
            Console.WriteLine("Свет в " + place + " выключен");
        }
    }
}