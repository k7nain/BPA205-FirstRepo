using UserEventTime.Extensions;
using UserEventTime.Records;
using UserEventTime.Structs;

namespace UserEventTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventTime eventTime = new EventTime(2026, 4, 3, 21);
  
            EventTime eventTime1 = new EventTime(2026, 4, 5, 14);

            EventTime eventTime2 = new EventTime(2026, 12, 7, 15);

            Event event1 = new Event("Roya Ayxan Konsert", eventTime, DateTime.Now );
            Event event2 = new Event("Aygun Kazimova Konsert", eventTime1, DateTime.Now);
            Event event3 = new Event("Johny Konsert", eventTime2, DateTime.Now);

            if (eventTime.ToDateTime() > DateTime.UtcNow)
            {
                Console.WriteLine($"{event1.Title} qarsidaki gunlerdedi.");
                TimeSpan diff = eventTime.ToDateTime() - DateTime.UtcNow;
                Console.WriteLine($"{diff.Days} gun vaxt qalib. {eventTime.ToDateTime()}");
            }
            else
            {
                Console.WriteLine($"{event1.Title} artiq kecmisdedi.");
            }

            if (eventTime1.ToDateTime() > DateTime.UtcNow)
            {
                Console.WriteLine($"{event2.Title} qarsidaki gunlerdedi.");
                TimeSpan diff = eventTime1.ToDateTime() - DateTime.UtcNow;
                Console.WriteLine($"{diff.Days} gun vaxt qalib. {eventTime1.ToDateTime()}");
            }
            else
            {
                Console.WriteLine($"{event2.Title} artiq kecmisdedi.");
            }

            if (eventTime2.ToDateTime() > DateTime.UtcNow)
            {
                Console.WriteLine($"{event3.Title} qarsidaki gunlerdedi.");
                TimeSpan diff = eventTime2.ToDateTime() - DateTime.UtcNow;
                Console.WriteLine($"{diff.Days} gun vaxt qalib. {eventTime2.ToDateTime()}");
            }
            else
            {
                Console.WriteLine($"{event3.Title} artiq kecmisdedi.");
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine($"Hefte sonuna dusur mu?");

            Console.WriteLine($"{event1.Title}: {eventTime.ToDateTime().IsWeekend()}");
            Console.WriteLine($"{event2.Title}: {eventTime1.ToDateTime().IsWeekend()}");
            Console.WriteLine($"{event3.Title}: {eventTime2.ToDateTime().IsWeekend()}");




        }
    }
}
