using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AdminToUserMailAPI.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Subject { get; set; }

        [Required]
        public string Body { get; set; }

        public ICollection<Recipient> Recipients { get; set; }
    }
}
