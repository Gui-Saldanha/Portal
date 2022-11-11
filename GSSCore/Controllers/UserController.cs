using GSSCore.Data;
using Microsoft.AspNetCore.Mvc;
using Model.ViewModel;

namespace GSSCore.Controllers
{
    public class UserController : Controller
    {
        APIRepository aPIRepository = new APIRepository();
        HttpResponseMessage httpResponseMessage;

        public IActionResult Login(UserVM userVM)
        {
            return View(userVM);  
        }

        public async Task<IActionResult> SignIn(UserVM userVM)
        {
            return View("Index", userVM);
        }

        public async Task<IActionResult> SignUp(UserVM userVM)
        {
            httpResponseMessage = await aPIRepository.PostResponseAsync("api/User/", userVM, HttpContext);

            return View("Index", userVM);
        }
    }
}