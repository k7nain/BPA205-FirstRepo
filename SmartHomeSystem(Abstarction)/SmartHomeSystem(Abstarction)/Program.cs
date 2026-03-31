using SmartHomeSystem_Abstarction_.Interfaces;
using SmartHomeSystem_Abstarction_.Models;

namespace SmartHomeSystem_Abstarction_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartLight light = new SmartLight { DeviceName = "Light", Brightness = 75 };
            SmartAC aC = new SmartAC { DeviceName = "Conditioner", Temperature = 21 };
            SmartDoor door = new SmartDoor { DeviceName = "Door", isLocked = true };
            List <IDevice> Devices = new List<IDevice> 
            {
                light,
                aC,
                door
            };

            foreach (var device in Devices)
            {
                device.TurnOn();
                Console.WriteLine("------------------------------");
                device.TurnOff();
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine("------------------------------");
            light.PerformAction();
            aC.PerformAction();
            door.PerformAction();

            Console.WriteLine("------------------------------");
            light.ShowStatus();
            aC.ShowStatus();
            door.ShowStatus();


        }
    }
}
