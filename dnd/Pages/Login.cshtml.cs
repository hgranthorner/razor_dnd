using System.Linq;
using dnd.BusinessLogic;
using dnd.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace dnd.Pages
{
    public class Login : PageModel
    {
        private readonly ISecurityManager _security;

        public Login(ISecurityManager security)
        {
            _security = security;
        }

        public ActionResult OnPostLogin(string name, string password)
        {
            var user = _security.Login(name, password);
            
            return user != null ? Redirect("/Room-List") : null;
        }
    }
}