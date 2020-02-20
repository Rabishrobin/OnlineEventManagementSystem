using System.Web.Mvc;
using OnlineEventManagementSystem.DAL;
using OnlineEventManagementSystem.Entity;

namespace EventManagement.MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserRepository users = new UserRepository();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignUp(UserManager user)
        {
            users.InsertUser(user);
            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }
    }
}