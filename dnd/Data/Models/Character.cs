using System.ComponentModel.DataAnnotations;

namespace dnd.Data.Models
{
    public class Character
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Race { get; set; }

        [Required] 
        public int Dex { get; set; } = 0;
        [Required]
        public int UserId { get; set; }
        [Required]
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public User User { get; set; }
    }
}