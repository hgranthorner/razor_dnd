using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dnd.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}