using System;
using System.Collections.Generic;

namespace ThreadAsyncDirectoryFile.Models
{
    public class User
    {
        /*User class
- Id
- Statuses - status obyektlərini özündə saxlayan bir list olacaq.
- Username
- ShareStatus() - parametr olaraq bir status obyekti qəbul edib statuses listinə əlavə edəcək.

- GetStatusById() - parametr olaraq nullable int tipindən bir id qəbul edəcək
        həmin id-li statusu tapıb geriyə qaytaracaq.
- GetAllStatuses() - geriyə user-in bütün statuslarını qaytaracaq.
- FilterStatusByDate() - parametr olaraq bir nullable id
        və DateTime tipindən bir tarix qəbul edəcək
        göndərilən id-li user-in həmin tarixdən sonra paylaşılan bütün statuslarını geriyə qaytaracaq,
        göndərilən tarixdən sonra heç bir status paylaşılmayıbsa NotFoundException baş verəcək.*/

        private static int _id;
        public int id { get; }
        public string UserName { get; set; }

        public User(string username)
        {
            _id = id;
            _id++;
            UserName = username;
        }

        List<Status> statuses = new List<Status>();

        public void ShareStatus(Status status)
        {
            statuses.Add(status);
            Console.WriteLine($"ID:{status.Id}");
        }

        public void GetStatusById(int? id)
        {
            foreach (Status status in statuses)
            {
                if (status.Id == id)
                {
                    status
                }

            }
        }

        public void GetAllStatuses()
        {
            Console.WriteLine();
        }

        public void FilterStatusByDate(int? id)
        {

        }

    }
}
