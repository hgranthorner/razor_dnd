using System;
using System.Collections.Generic;
using System.Linq;
using dnd.BusinessLogic;
using dnd.Data;
using dnd.Data.Models;
using dnd.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dnd.Pages
{
    public class RoomListModel : PageModel
    {
        private readonly DnDContext _context;
        private readonly IHttpContextAccessor _http;
        private ISession _session => _http.HttpContext.Session;
        private readonly ISecurityManager _security;
        public readonly IEnumerable<Room> Rooms;

        public RoomListModel(DnDContext context, IHttpContextAccessor http, ISecurityManager security)
        {
            _context = context;
            _http = http;
            _security = security;
            Rooms = _context.Rooms.Select(x => x).ToList();
        }

        public IActionResult OnGet()
        {
            return !_security.IsLoggedIn() ? Redirect("/login") : null;
        }
    }
}