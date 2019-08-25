using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dnd.Data.Models
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required] 
        public bool InCombat { get; set; } = false;
        public ICollection<Character> Characters { get; set; }
    }
}