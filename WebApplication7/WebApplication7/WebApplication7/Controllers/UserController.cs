using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication7.DataAccess;
using WebApplication7.Models;
using WebApplication7.ViewModels;

namespace WebApplication7.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public async Task<ActionResult> Index()
        {
            List<User> users = new List<User>();
            using (var context = new JobsContext())
            {
                users = await context.Users.ToListAsync();
            }

            List<UserViewModel> viewModel = new List<UserViewModel>();

            foreach (var user in users)
            {
                viewModel.Add(
                    new UserViewModel
                    {
                        UserName = user.UserName,
                        CreationDate = user.CreationDate    //Не отправляем лишние данные 
                    }); //Отправляем теперь вместо user userViewModel
            }

            return View(viewModel);
        }
    }
}