using System.ComponentModel.DataAnnotations;

namespace TestDBconection.Models
{
    public class BooksModel
    {
        
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public DateTime? date { get; set; }

    }
}
