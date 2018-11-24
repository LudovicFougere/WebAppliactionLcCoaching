using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using WebApplicationLcCoaching.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationLcCoaching.Controllers
{
    public class UsersController : Controller
    {
        UsersDataAccessLayer objUsers = new UsersDataAccessLayer();

        private IHostingEnvironment _hostingEnvironment;

        public UsersController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [Route("api/User/Index")]
        public IEnumerable<Users> Index()
        {
            return objUsers.GetAllUsers();
        }

        [HttpPost]
        [Route("api/User/Create")]
        public int Create(Users user)
        {
            return objUsers.AddUser(user);
        }

        [HttpGet]
        [Route("api/User/Details/{id}")]
        public Users Details(int id)
        {
            return objUsers.GetUserData(id);
        }

        [HttpPut]
        [Route("api/User/Edit")]
        public int Edit(Users user)
        {
            return objUsers.UpdateUser(user);
        }

        [HttpDelete]
        [Route("api/User/Delete/{id}")]
        public int Delete(int id)
        {
            return objUsers.DeleteUser(id);
        }

    }
}
