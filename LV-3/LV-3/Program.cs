using System;

namespace LV_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dataset newDS = new Dataset("Zadatak1.txt");
            Console.WriteLine(newDS.WriteOutput());

            ConsoleNotification Info = new ConsoleNotification("gsd", "Naslov", "INFO", DateTime.Now, Category.INFO, ConsoleColor.Green);
            ConsoleNotification Alert = new ConsoleNotification("sadf", "Naslov", "ALERT", DateTime.Now, Category.ALERT, ConsoleColor.Yellow);
            ConsoleNotification Error = new ConsoleNotification("dag", "Naslov", "ERROR", DateTime.Now, Category.ERROR, ConsoleColor.Red);

            NotificationManager notificationceManager = new NotificationManager();

            notificationceManager.Display(Info);
            notificationceManager.Display(Alert);
            notificationceManager.Display(Error);

            NotificationBuilder notificationbuilder = new NotificationBuilder();
            Direktor direktor = new Direktor();
            direktor.Construct(notificationbuilder, "Ime");
            ConsoleNotification n = notificationbuilder.Build();
            notificationceManager.Display(n);
        }
    }
}
