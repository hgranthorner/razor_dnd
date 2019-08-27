using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            _session.SetString(SessionKeys.UserName, "Gil");
        }
    }
}