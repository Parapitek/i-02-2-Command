using System;

namespace i_02_2_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light("Гостинная");
            Light kitchenLight = new Light("Кухня");
            Stereo stereo = new Stereo("Гостинная");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);


            remoteControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.setCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.setCommand(2, stereoOnWithCD, stereoOff);

            Console.WriteLine(remoteControl);

            remoteControl.onButtonWasPushed(0);
            remoteControl.offButtonWasPushed(0);
            remoteControl.onButtonWasPushed(1);
            remoteControl.offButtonWasPushed(1);
            remoteControl.onButtonWasPushed(2);
            remoteControl.offButtonWasPushed(2);
        }
    }
}
