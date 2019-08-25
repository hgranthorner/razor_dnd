using System;
using System.Linq;
using System.Threading.Tasks;
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
        
        public Rooms(DnDContext context)
        {
            _context = context;
        }
        public async Task OnPostToggle(int id, bool inCombat)
        {
            var newCombatStatus = !inCombat;
            (await _context.Rooms.FindAsync(id)).InCombat = newCombatStatus;
            var characters = _context.Characters.Where(c => c.RoomId == id);
            if (!newCombatStatus)
                await characters.ForEachAsync(c =>
                {
                    c.Initiative = 0;
                    c.TurnNumber = 0;
                });
            else
                await characters.ForEachAsync(c => c.Initiative = DiceRoller.RollD20(c.Dex));
            await _context.SaveChangesAsync();
        }

        public async Task OnPostTurnTaken(int roomId, int characterId)
        {
            (await _context.Characters.FindAsync(characterId)).TurnNumber++;
            await _context.SaveChangesAsync();
        }
        
        public Room GetRoom(string id)
        {
            return _context.Rooms
                .Include(r => r.Characters)
                .ThenInclude(c => c.User)
                .First(room => room.Id == Convert.ToInt32(id));
        }
    }
}