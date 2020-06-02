using System;
using System.Collections.Generic;
using LV_3;

namespace LV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset csvFile = new Dataset("TestFile.txt");
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);
            Console.WriteLine("Avg redaka: ");
            for (int i = 0; i < 3; i++)
                Console.WriteLine(adapter.CalculateAveragePerRow(csvFile)[i]);
            Console.WriteLine("Avg stupaca: ");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(adapter.CalculateAveragePerColumn(csvFile)[i]);

            List<IRentable> rentList = new List<IRentable>();
            Video video = new Video("Video");
            Book book = new Book("Knjiga");
            rentList.Add(video);
            rentList.Add(book);

            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(rentList);
            printer.PrintTotalPrice(rentList);

            HotItem hitVid = new HotItem(new Video("Hit video"));
            DiscountedItem discountBook = new DiscountedItem(new Book("Jeftina knjiga"));
            rentList.Add(hitVid);
            rentList.Add(discountBook);
            printer.DisplayItems(rentList);
            printer.PrintTotalPrice(rentList);

            EmailValidator emailValidator = new EmailValidator(7);
            PasswordValidator passwordValidator = new PasswordValidator(6);

            string password1 = new string("JakoGlupo123");
            string password2 = new string("TupavoDoBola");
            string email1 = new string("dobaremaildobardobar@sprdnja.loser");
            string email2 = new string("los@mail@.tap");

            Console.WriteLine("JakoGlupo123: " + passwordValidator.IsValidPassword(password1));
            Console.WriteLine("TupavoDoBola: " + passwordValidator.IsValidPassword(password2));
            Console.WriteLine("dobaremaildobardobar@sprdnja.loser: " + emailValidator.IsValidAddress(email1));
            Console.WriteLine("los@mail@.tap: " + emailValidator.IsValidAddress(email2));

        }
    }
}
