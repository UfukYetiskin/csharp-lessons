namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course() {
                    Id = 1, 
                    Title = "Aspnet kursu", 
                    Image = "first-image.jpg", 
                    Description = "Açıklamamaaa",
                    Tags = new string[] {"aspnet", "web", "js"},
                    isActive = true,
                    isHome = true
                },
                new Course() {
                    Id = 2, 
                    Title = "Kurse kursu2", 
                    Image = "first-image.jpg", 
                    Description = "Açıklamamaaa",
                    Tags = new string[] {"phyton", "backend"},
                    isActive = true,
                    isHome = true
                },
                new Course() {
                    Id = 3, 
                    Title = "JS kursu3", 
                    Image = "first-image.jpg", 
                    Description = "Açıklamamaaa",
                    Tags = new string[] {"php", "web", "js"},
                    isActive = false,
                    isHome = true
                },
                new Course() {
                    Id = 4, 
                    Title = "Angular kursu4", 
                    Image = "first-image.jpg", 
                    Description ="Açıklamamaaa",
                    Tags = new string[] {"go", "backend"},
                    isActive = true,
                    isHome = false
                }
            };
        }

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }
        public static Course? GetById(int? id){
            return _courses.FirstOrDefault(c => c.Id == id );
        }
    }
}