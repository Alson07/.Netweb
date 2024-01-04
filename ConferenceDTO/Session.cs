using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceDTO
{
    public class Session
    {
        
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [StringLength(4000)]
        public virtual string? Abstract { get; set; }
        public virtual DateTimeOffset? StartTime { get; set; }
        public virtual DateTimeOffset? EndTime { get; set; }

        public TimeSpan Duration => 
            EndTime?.Subtract(StartTime?? EndTime?? DateTimeOffset.MinValue)??
            TimeSpan.Zero;
        
        public int? TrackId { get; set; }
    }
}
