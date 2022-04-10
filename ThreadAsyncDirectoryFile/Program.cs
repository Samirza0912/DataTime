using System;
using ThreadAsyncDirectoryFile.Models;

namespace ThreadAsyncDirectoryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the username");
            string user = Console.ReadLine();

            User users = new User(user);
            int input;
            do
            {
                Check();
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("enter the title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("enter the content: ");
                        string content = Console.ReadLine();
                        Status statuses = new Status(title, content);
                        users.ShareStatus(statuses);
                        break;

                    case 2:
                        users.GetAllStatuses();
                        break;

                    case 3:
                        Console.WriteLine("enter the ID: ");
                        int id = int.Parse(Console.ReadLine());
                        users.GetStatusById(id);
                        break;

                    case 4:
                        Console.WriteLine("enter the ID: ");
                        int filter = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter Date Time: ");
                        string time = Console.ReadLine();
                        users.FilterStatusByDate(filter, DateTime.Parse(time));
                        break;

                    case 0:
                        break;

                }


            } while (input!=0);

        }
        public static void Check()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Share Status \n" +
                "2.Get All Statuses \n" +
                "3.Get Status by Id \n" +
                "4.Filter Status by ID \n" +
                "0.end program");
            Console.WriteLine("input your choice: ");
        }
    }
  


}
    

