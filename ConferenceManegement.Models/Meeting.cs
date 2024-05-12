
namespace ConferenceManegement.Models
{
    public class Meeting
    {
        public string MeetingId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int UserId { get; set; } 
        public User User { get; set; } 
    }

}
