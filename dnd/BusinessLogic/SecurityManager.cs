using System.Linq;
using dnd.Data;
using dnd.Data.Models;
using dnd.Pages;
using dnd.Utils;
using Microsoft.AspNetCore.Http;

namespace dnd.BusinessLogic
{
    public interface ISecurityManager
    {
        User Login(string userName, string password);
        bool IsLoggedIn();
        Result Logout();
    }

    public class SecurityManager : ISecurityManager
    {
        private readonly IHttpContextAccessor _http;
        private readonly DnDContext _context;
        private ISession _session => _http.HttpContext.Session;

        public SecurityManager(IHttpContextAccessor http, DnDContext context)
        {
            _http = http;
            _context = context;
        }

        public User Login(string userName, string password)
        {
            var users = _context.Users.Where(u => u.Name == userName && u.Password == password);
            
            if (!users.Any()) return null;
            
            var user = users.First();
            _session.SetObject(SessionKeys.User, user);

            return user;
        }

        public bool IsLoggedIn()
        {
            var user = _session.GetObject<User>(SessionKeys.User);
            return user != null;
        }

        public Result Logout()
        {
            if (!IsLoggedIn())
                return Result.Failure;
            
            _session.SetObject(SessionKeys.User, null);

            return Result.Failure;
        }
    }
}