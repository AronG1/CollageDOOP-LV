using System;
using System.Collections.Generic;
using System.Text;

namespace LV_4
{
    interface IRegistrationValidator
    {
        bool IsUserEntryValid(UserEntry entry);
    }

    class UserEntry
    {
        public String Email { get; set; }
        public String Password { get; set; }
        private UserEntry() { }
        public static UserEntry ReadUserFromConsole()
        {
            UserEntry entry = new UserEntry();
            Console.WriteLine("Enter email: ");
            entry.Email = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            entry.Password = Console.ReadLine();
            return entry;
        }

    }
}
