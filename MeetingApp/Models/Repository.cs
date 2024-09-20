namespace MeetingApp.Models{
    public static class Repository{
        // Statik listeyi başlatıyoruz
        private static List<Meeting> _meetings = new List<Meeting>
        {
            // Manuel olarak bazı verileri listeye ekleyelim
            new Meeting {Id = 1, Name = "John Doe", Email = "john@example.com", Phone = "123-456-7890", WillAttend = true },
            new Meeting {Id = 2, Name = "Jane Smith", Email = "jane@example.com", Phone = "987-654-3210", WillAttend = false }
        };


        public static List<Meeting> Meetings {
            get{
                return _meetings;
            }
        }
        public static void CreateUser(Meeting meeting){
            meeting.Id = Meetings.Count + 1;
            _meetings.Add(meeting);
        }

        public static Meeting? GetById(int id){
            return _meetings.FirstOrDefault(meet => meet.Id == id);
        }
        

    }
}