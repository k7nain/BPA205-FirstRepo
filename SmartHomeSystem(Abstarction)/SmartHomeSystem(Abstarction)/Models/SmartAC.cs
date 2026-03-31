using SmartHomeSystem_Abstarction_.Interfaces;
using SmartHomeSystem_Abstarction_.Models.Common;

namespace SmartHomeSystem_Abstarction_.Models
{
    public class SmartAC : SmartDevice, IDevice
    {
        public int Temperature { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("The Air Conditioner turn on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The Air Conditioner turn off.");
        }

        public override void PerformAction()
        {
            Console.WriteLine($"Temperature: {Temperature}");
        }

        public override void ShowStatus()
        {
            base.ShowStatus();
        }
    }
}
