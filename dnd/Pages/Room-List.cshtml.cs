using System;
using System.Collections.Generic;
using System.Linq;
using dnd.Data;
using dnd.Data.Models;
using dnd.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dnd.Pages
{
    [Authorize]
    public class RoomListModel : PageModel
    {
        private readonly DnDContext _context;
        private readonly IHttpContextAccessor _http;
        private ISession _session => _http.HttpContext.Session;
        public readonly IEnumerable<Room> Rooms;

        public RoomListModel(DnDContext context, IHttpContextAccessor http)
        {
            _context = context;
            _http = http;
            Rooms = _context.Rooms.Select(x => x).ToList();
        }

        public void OnGet()
        {
            Console.WriteLine(_session.GetString(SessionKeys.UserName) != null
                ? "User exists"
                : "User does not exist.");
        }
    }
}