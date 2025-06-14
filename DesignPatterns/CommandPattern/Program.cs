using CommandPattern.CeilingFan;
using CommandPattern.GarageDoor;
using CommandPattern.Light;
using CommandPattern.Stereo;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            CommandPattern.Light.Light livingRoomLight = new("Living Room");
            CommandPattern.Light.Light kitchenLight = new("Kitchen");
            CommandPattern.CeilingFan.CeilingFan ceilingFan = new("Living Room");
            CommandPattern.GarageDoor.GarageDoor garageDoor = new();
            CommandPattern.Stereo.Stereo stereo = new("Living Room");
            LightOnCommand livingRoomLightOn = new(livingRoomLight);
            LightOffCommand livingRoomLightOff = new(livingRoomLight);
            LightOnCommand kitchenLightOn = new(kitchenLight);
            LightOffCommand kitchenLightOff = new(kitchenLight);
            CeilingFanHighCommand ceilingFanHigh = new(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new(ceilingFan);
            CeilingFanLowCommand ceilingFanLow = new(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new(ceilingFan);
            GarageDoorUpCommand garageDoorUp = new(garageDoor);
            GarageDoorDownCommand garageDoorDown = new(garageDoor);
            StereoOnWithCDCommand stereoOnWithCD = new(stereo);
            StereoOffCommand stereoOff = new(stereo);
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(3, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(4, ceilingFanLow, ceilingFanOff);
            remoteControl.SetCommand(5, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(6, stereoOnWithCD, stereoOff);
            Console.WriteLine(remoteControl);
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine();
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine();
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine();
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine();
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine();
            remoteControl.OnButtonWasPushed(5);
            remoteControl.OffButtonWasPushed(5);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine();
            remoteControl.OnButtonWasPushed(6);
            remoteControl.OffButtonWasPushed(6);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine();
        }
    }
}
