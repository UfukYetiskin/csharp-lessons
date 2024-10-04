namespace WebApiService.Models{
    public class Post{
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public DateTime DateTime {get; set;}
    }
}