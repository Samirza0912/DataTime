using System;
namespace ThreadAsyncDirectoryFile.Models
{
    public class Status
    {
        /*Status class
- Id  
- Title
- Content
- SharedDate - DateTime tipindən bir property,
        statusdan yeni bir obyekt yaranan zaman yarandığı tarix set olunacaq.
- GetStatusInfo() - geriyə "Title: test title - Content: test content - shared 5 seconds ago"
        (burda qeyd olunan "shared 5 seconds ago" hissəsi dinamik olmalıdı
        status neçə saniyə əvvəl paylaşılıbsa o yazılmalıdı) bu tipdə bir məlumat qaytaracaq.*/
        private static int _ID;
        public int Id { get; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedTime { get; set; }

        public Status(string title, string content)
        {
            _ID++;
            _ID = Id;
            Title = title;
            Content = content;
            SharedTime = DateTime.Now;
        }

        public void GetStatusInfo()
        {
            var interval = DateTime.Now.Subtract(SharedTime).Milliseconds;
            Console.WriteLine($"ID: {Id} \n" +
                $"Title: {Title} \n" +
                $"Content: {Content} \n" +
                $"SharedDate: {SharedTime}");
        }

    }
}
