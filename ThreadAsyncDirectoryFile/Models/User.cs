using System;
using System.Collections.Generic;
using ThreadAsyncDirectoryFile.Exception1;

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
        List<Status> statuses;

        public User(string username)
        {
            _id = id;
            _id++;
            UserName = username;
            statuses = new List<Status>();
        }

        public void ShareStatus(Status status)
        {
            statuses.Add(status);
        }

        public Status GetStatusById(int? id)
        {
            foreach (Status status in statuses)
            {
                if (status.Id == id)
                {
                    status.GetStatusInfo();    
                }
                else if (id == null)
                {
                    throw new NullReferenceException("id is empty");
                }
            }
            return null;
        }

        public void GetAllStatuses()
        {
            foreach (var item in statuses)
            {
                Console.WriteLine($"ID: {item.Id} \n" +
                $"Title: {item.Title} \n" +
                $"Content: {item.Content} \n" +
                $"SharedDate: {item.SharedTime}");
            } 
        }
        public void FilterStatusByDate(int? id, DateTime time)
        {
            if (id == id)
            {
                foreach (Status item in statuses)
                {
                    if (time >= item.SharedTime)
                    {
                        Console.WriteLine(item);
                    }
                    else
                    {
                        throw new NotFoundException("no data after the shared date");
                    }
                }
            }
        }
    }
}
