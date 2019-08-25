using System;
using System.Linq;
using dnd.BusinessLogic;
using dnd.Data;
using dnd.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace dnd.Pages
{
    public class Rooms : PageModel
    {
        private readonly DnDContext _context;
        public Room Room;
        public bool InCombat;
        
        public Rooms(DnDContext context)
        {
            _context = context;
        }

        public void OnGet(string id)
        {
            Room = _context.Rooms
                .Include(r => r.Characters)
                .ThenInclude(c => c.User)
                .First(room => room.Id == Convert.ToInt32(id));
        }

        public int RollInitiative(Character character)
        {
            return DiceRoller.RollD20(character.Dex);
        }

        public void ToggleCombat()
        {
            InCombat = !InCombat;
        }
    }
}