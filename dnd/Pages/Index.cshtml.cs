using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dnd.Data.Models;
using dnd.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dnd.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHttpContextAccessor _http;
        private ISession _session => _http.HttpContext.Session;

        public IndexModel(IHttpContextAccessor http)
        {
            _http = http;
        }

        public void OnGet()
        {
            var user = new User
            {
                Id = 1,
                Name = "Gil",
                Password = "gillovespoo"
            };
            _session.SetObject(SessionKeys.User, user);
        }
    }
}