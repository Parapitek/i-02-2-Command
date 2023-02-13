using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_02_2_Command
{
    class Stereo
    {
        private string place;

        public Stereo(string place)
        {
            this.place = place;
        }

        public void on()
        {
            Console.WriteLine("Стереосистема в " + place + " включена");
        }

        public void off()
        {
            Console.WriteLine("Стереосистема в " + place + " выключена");
        }

        public void setCd()
        {
            Console.WriteLine("Стереосистема в " + place + " переключилась на CD");
        }

        public void setDvd()
        {
            Console.WriteLine("Стереосистема в " + place + " переключилась на DVD");
        }

        public void setRadio()
        {
            Console.WriteLine("Стереосистема в " + place + " переключилась на радио");
        }

        public void setVolume(int vol)
        {
            Console.WriteLine("Стереосистема в " + place + " громкость установлена в " + vol); ;
        }
    }
}
