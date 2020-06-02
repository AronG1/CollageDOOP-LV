using System;
using LV_3;

namespace LV_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "TestFile.txt";

            Dataset dataset = new Dataset(filepath);


            ReminderNote note1 = new ReminderNote("Def message, LighTheme", new LightTheme());
            ReminderNote note2 = new ReminderNote("Moja poruka tebi, PersonalTheme", new PersonalTheme());
            note1.Show();
            Console.WriteLine("\n");
            note2.Show();

        }
    }
}
