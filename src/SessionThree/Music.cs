namespace ConsoleApp1.SessionThree
{
    public class Music
    {
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Artist { get; set; }

        // default constructor
        public Music()
        {
            Console.WriteLine("Inside 'Music' default constructor");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Music information");
            Console.WriteLine($"Title: {Title?.Trim() ?? "N/A"} | Type: {Title?.GetType().Name ?? "Unknown"}\n" +
                              $"Genre: {Genre?.Trim() ?? "N/A"} | Type: {Genre?.GetType().Name ?? "Unknown"}\n" +
                              $"Artist: {Artist?.Trim() ?? "N/A"} | Type: {Artist?.GetType().Name ?? "Unknown"}\n" + "}"
            );
        }
        
        
        public static void RunMusic()
        {
            Music nepali = new Music();
            Music english = new Music();
        
            nepali.Artist = "Durgesh Thapa";
            nepali.Genre = "Rock n Roll";
            nepali.Title = "Dusman hereko herei";
        
            nepali.ShowInfo();
            Console.WriteLine();
            english.ShowInfo();
        }
    }

    namespace InnerSpace
    {
        public class Movie {}
        public class School {}
    }
}