using SmartHomeSystem_Abstarction_.Interfaces;
using SmartHomeSystem_Abstarction_.Models.Common;

namespace SmartHomeSystem_Abstarction_.Models
{
    public class SmartLight : SmartDevice , IDevice
    {
        public int Brightness { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("Light turn on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light turn off.");
        }

        public override void PerformAction()
        {
            Console.WriteLine($"Brightness: {Brightness}");
        }

        public override void ShowStatus()
        {
            base.ShowStatus();
        }
    }
}
