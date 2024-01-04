using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceDTO
{
    public class Attendee
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(200)]
        public string LastName { get; set; }
        [Required]
        [StringLength(256)]
        public string UserName { get ; set; }
        [Required]
        [StringLength(256)]
        public string EmailAddress { get; set; }

    }
}
