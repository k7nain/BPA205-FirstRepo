namespace SmartHomeSystem_Abstarction_.Models.Common
{
    public abstract class SmartDevice
    {
        public string DeviceName { get; set; }

        public abstract void PerformAction();
        public virtual void ShowStatus()
        {
            Console.WriteLine("Device works.");
        }
    }
}
