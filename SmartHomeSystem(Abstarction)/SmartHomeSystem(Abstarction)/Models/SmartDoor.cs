using SmartHomeSystem_Abstarction_.Interfaces;
using SmartHomeSystem_Abstarction_.Models.Common;

namespace SmartHomeSystem_Abstarction_.Models
{
    public class SmartDoor : SmartDevice, IDevice
    {
        public bool isLocked { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("SmartDoor locked.");
        }

        public void TurnOff()
        {
            Console.WriteLine("SmartDoor open.");
        }

        public override void PerformAction()
        {
            Console.WriteLine($"IsLocked: {isLocked}");
        }

        public override void ShowStatus()
        {
            base.ShowStatus();
        }
    }
}
