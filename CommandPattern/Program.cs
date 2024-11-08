﻿// See https://aka.ms/new-console-template for more information
using CommandPattern;
using CommandPattern.Commands;
using CommandPattern.Devices;

Console.WriteLine("Hello, World!");

RemoteControl remoteControl = new RemoteControl();

Light livingRoomLight = new Light("Living room");
Light kitchenLight = new Light("Kitchen");
CeilingFan ceilingFanBedroom = new CeilingFan("Living room");
Garage garageDoor = new Garage();
Stereo stereo =new Stereo();

LightsOnCommand livingroomLightOn = new LightsOnCommand(livingRoomLight);
LightsOffCommand livingroomLightOff = new LightsOffCommand(livingRoomLight);
LightsDimCommand livingroomLightDim = new LightsDimCommand(livingRoomLight);

CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFanBedroom);
CeilingFanOFFCommand ceilingFanOFFCommand = new CeilingFanOFFCommand(ceilingFanBedroom);
CeilingFanMediumCommand ceilingFanMediumCommand = new CeilingFanMediumCommand(ceilingFanBedroom);
CeilingFanLowCommand ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFanBedroom);

//LightsOnCommand kitchenLightOn = new LightsOnCommand(kitchenLight);
//LightsOffCommand kitchenLightOff = new LightsOffCommand(kitchenLight);

//CeilingFanOnCommand ceilingFanRoomOn = new CeilingFanOnCommand(ceilingFanBedroom);
//CeilingFanOFFCommand ceilingFanRoomOff = new CeilingFanOFFCommand(ceilingFanBedroom);

//GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
//GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

StereoOnwithCDCommand stereoOnCD = new StereoOnwithCDCommand(stereo);
StereoOffwithCDCommand stereoOffCD = new StereoOffwithCDCommand(stereo);
ICommand[] partyOn = new ICommand[] { livingroomLightDim, stereoOnCD, ceilingFanHighCommand };
ICommand[] partyOFF = new ICommand[] { livingroomLightOff, stereoOffCD, ceilingFanOFFCommand };

MacroCommand partyOnMacro = new MacroCommand(partyOn);
MacroCommand partyyOffMacro = new MacroCommand(partyOFF);

remoteControl.setCommand(0, livingroomLightOn, livingroomLightOff);
//remoteControl.setCommand(1, ceilingFanHighCommand, ceilingFanOFFCommand);
//remoteControl.setCommand(2, ceilingFanMediumCommand, ceilingFanOFFCommand);
//remoteControl.setCommand(3, ceilingFanLowCommand, ceilingFanOFFCommand);
remoteControl.setCommand(1, partyOnMacro, partyyOffMacro);

//remoteControl.setCommand(1, kitchenLightOn, kitchenLightOff);
//remoteControl.setCommand(2, ceilingFanRoomOn, ceilingFanRoomOff);
//remoteControl.setCommand(3, garageDoorUp, garageDoorDown);
//remoteControl.setCommand(4, stereoOnCD, stereoOffCD);


Console.WriteLine(remoteControl);
remoteControl.onButtonWasPushed(0);
remoteControl.offButtonWasPushed(0);
remoteControl.onButtonWasPushed(1);
//remoteControl.onButtonWasPushed(2);
//remoteControl.onButtonWasPushed(3);
remoteControl.undoButtonWasPushed();
remoteControl.undoButtonWasPushed();
//remoteControl.undoButtonWasPushed();
//remoteControl.undoButtonWasPushed();
//remoteControl.undoButtonWasPushed();

//remoteControl.onButtonWasPushed(1);
//remoteControl.offButtonWasPushed(1);

//remoteControl.onButtonWasPushed(2);
//remoteControl.offButtonWasPushed(2);

//remoteControl.onButtonWasPushed(3);
//remoteControl.offButtonWasPushed(3);

//remoteControl.onButtonWasPushed(4);
//remoteControl.offButtonWasPushed(4);





