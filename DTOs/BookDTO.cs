using System.ComponentModel.DataAnnotations;

namespace Midterm.DTOs
{
    public class BookDTO
    {
        [Required]
        [MinLength(4)]
        [MaxLength(32)]
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime PublishedDate { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(24)]
        public string? Author { get; set; }
    }
}
