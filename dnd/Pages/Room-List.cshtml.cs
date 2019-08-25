using System.Collections.Generic;
using System.Linq;
using dnd.Data;
using dnd.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dnd.Pages
{
    public class RoomListModel : PageModel
    {
        private readonly DnDContext _context;
        public readonly IEnumerable<Room> Rooms;

        public RoomListModel(DnDContext context)
        {
            _context = context;
            Rooms = _context.Rooms.Select(x => x).ToList();
        }

        public void OnGet()
        {
        }
    }
}