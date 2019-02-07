using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoProgrammers.Data.Core.Transactions;
using ProjetoProgrammers.Domain.Entities;
using ProjetoProgrammers.Domain.Repositories;
using ProjetoProgrammers.Web.Models;

namespace ProjetoProgrammers.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IUow _uow;
        public UserController(IUserRepository userRepository, IUow uow)
        {
            this._userRepository = userRepository;
            this._uow = uow;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
          

            
            List<User> users =  _userRepository.GetUsers();
   
            return View(users);
        }

        [HttpGet]
        [Route("GetCreateUser")]
        public IActionResult GetCreateUser()
        {
            return View("GetCreateUser");
        }

        [HttpPost]
        [Route("PostCreateUser")]
        public IActionResult PostCreateUser([FromForm] User user)
        {
            if (ModelState.IsValid)
            {
                _userRepository.Save(user);
                _uow.Commit();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("GetEditUser/{id}")]
        public IActionResult GetEditUser(int id)
        {
            User user = _userRepository.GetUser(id);

            return View("Update", user);
        }


        [HttpPost]
        [Route("PostEditUser")]
        public IActionResult PostEditUser([FromForm] User user)
        {
          

            if (ModelState.IsValid)
            {
                _userRepository.Update(user);
                _uow.Commit();
            }

            return RedirectToAction("Index");

   
        }

        [HttpGet]
        [Route("DeleteUser/{id}")]
        public IActionResult DeleteUser(int id)
        {
            _userRepository.Delete(id);
            _uow.Commit();
            return RedirectToAction("Index");
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
