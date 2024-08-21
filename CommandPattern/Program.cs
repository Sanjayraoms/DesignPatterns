// See https://aka.ms/new-console-template for more information
using CommandPattern;
using CommandPattern.Commands;
using CommandPattern.Devices;

Console.WriteLine("Hello, World!");

RemoteControl remoteControl = new RemoteControl();

Light livingRoomLight = new Light("Living room");
Light kitchenLight = new Light("Kitchen");
CeilingFan ceilingFanBedroom = new CeilingFan("Bedroom");
Garage garageDoor = new Garage();
Stereo stereo =new Stereo();

LightsOnCommand livingroomLightOn = new LightsOnCommand(livingRoomLight);
LightsOffCommand livingroomLightOff = new LightsOffCommand(livingRoomLight);

LightsOnCommand kitchenLightOn = new LightsOnCommand(kitchenLight);
LightsOffCommand kitchenLightOff = new LightsOffCommand(kitchenLight);

CeilingFanOnCommand ceilingFanRoomOn = new CeilingFanOnCommand(ceilingFanBedroom);
CeilingFanOFFCommand ceilingFanRoomOff = new CeilingFanOFFCommand(ceilingFanBedroom);

GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

StereoOnwithCDCommand stereoOnCD = new StereoOnwithCDCommand(stereo);
StereoOffwithCDCommand stereoOffCD = new StereoOffwithCDCommand(stereo);

remoteControl.setCommand(0, livingroomLightOn, livingroomLightOff);
remoteControl.setCommand(1, kitchenLightOn, kitchenLightOff);
remoteControl.setCommand(2, ceilingFanRoomOn, ceilingFanRoomOff);
remoteControl.setCommand(3, garageDoorUp, garageDoorDown);
remoteControl.setCommand(4, stereoOnCD, stereoOffCD);

Console.WriteLine(remoteControl);

remoteControl.onButtonWasPushed(0);
remoteControl.offButtonWasPushed(0);

remoteControl.onButtonWasPushed(1);
remoteControl.offButtonWasPushed(1);

remoteControl.onButtonWasPushed(2);
remoteControl.offButtonWasPushed(2);

remoteControl.onButtonWasPushed(3);
remoteControl.offButtonWasPushed(3);

remoteControl.onButtonWasPushed(4);
remoteControl.offButtonWasPushed(4);





