using ConferenceDTO;

namespace BackEnd.Data
{
    public class SessionAttendee
    {
        public int SessionId { get; set; }
        public Session Session { get; set; } = null;
        public int AttendeId { get; set; }
        public Attendee Attendee { get; set; } = null;
    }
}
