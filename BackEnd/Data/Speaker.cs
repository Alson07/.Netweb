using System.ComponentModel.DataAnnotations;

namespace BackEnd.Data
{
    public class Speaker : ConferenceDTO.Speaker
    {
        public virtual ICollection<SessionSpeaker> SessionSpeakers { get; set; } = new List<SessionSpeaker>();

        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string? Name { get; set; }
        [StringLength(4000)]
        public string? Bio { get; set; }
       [StringLength(1000)]
        public string? Website { get; set; }
    }
}
