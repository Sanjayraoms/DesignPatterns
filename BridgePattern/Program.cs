// See https://aka.ms/new-console-template for more information
using BridgePattern.Device;
using BridgePattern.Remote;

Console.WriteLine("Hello, World!");
TestDevice(new TV());
TestDevice(new Radio());
Console.ReadLine();
static void TestDevice(IDevice device)
{
    Console.WriteLine("Test with basic Remote");
    Remote remote = new Remote(device);
    remote.togglePower();
    remote.volumeUp();
    device.printStatus();

    Console.WriteLine("Test with advanced Remote");
    AdvancedRemote advancedRemote = new AdvancedRemote(device);
    remote.togglePower();
    advancedRemote.channelDown();
    advancedRemote.Mute();
    device.printStatus();
}
