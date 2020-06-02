using System;

namespace LV_6
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");

            Note note = new Note("Naslov", "tijeloooo - savrsene figure");

            note.Show();

            Notebook notebook = new Notebook();

            notebook.AddNote(note);

            Iterator iterator = new Iterator(notebook);
            iterator.First().Show();
            while (iterator.Next() != null)
            {
                iterator.Current.Show();
            }


            notebook.Clear();

            Memento.CareTaker careTaker = new Memento.CareTaker();
            ToDoItem todoist1 = new ToDoItem("naslov1", "text1", DateTime.Now);
            ToDoItem todoist2 = new ToDoItem("naslov2", "text2", DateTime.Now);
            ToDoItem todoist3 = new ToDoItem("naslov3", "text3", DateTime.Now);
            ToDoItem todoist4 = new ToDoItem("naslov4", "text4", DateTime.Now);


            ToDoItem getStateTdi = new ToDoItem("", "", DateTime.Now);

            Console.WriteLine(getStateTdi.ToString());

            WeatherStation.HomeThermostat termostat1 = new WeatherStation.HomeThermostat();
            WeatherStation.HomeThermostat termostat2 = new WeatherStation.HomeThermostat();

            WeatherStation station = new WeatherStation(25);

            station.AddObserver(termostat1);
            station.AddObserver(termostat2);

            station.SetTemperature(31);

        }
    }
}
