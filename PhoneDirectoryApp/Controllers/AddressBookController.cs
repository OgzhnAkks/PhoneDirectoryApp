using Microsoft.AspNetCore.Mvc;

namespace PhoneDirectoryApp.Controllers
{
    public class AddressBookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
