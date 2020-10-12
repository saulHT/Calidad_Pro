using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CompraloTodo.Db;
using CompraloTodo.Extensions;
using CompraloTodo.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompraloTodo.Controllers
{
    public class AuthController : Controller
    {
        private CompraloTodoContex db;

        public AuthController(CompraloTodoContex db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Usuario user)
        {
            var userV=db.usuarios.FirstOrDefault(o=>o.email==user.email && o.password==user.password);
            validarLogin(user);
            if (userV !=null)
            {
               
                if (ModelState.IsValid)
                {
                    HttpContext.Session.Set("sesionUser", userV);

                    if (userV !=null)
                    {
                        var claims = new List<Claim>()
                        {
                            new Claim(ClaimTypes.Name,userV.email),
                        };

                        var userIdentity = new ClaimsIdentity(claims,"Login");
                        var principal = new ClaimsPrincipal(userIdentity);

                        HttpContext.SignInAsync(principal);

                        return RedirectToAction("Index","Producto");
                    }
                }
               
            }
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login","Auth");
        }

        public void validarLogin(Usuario usuario)
        {
            if (usuario.email==null || usuario.email == "")
            {
                ModelState.AddModelError("email","email obligatorio");
            }

            if (usuario.password==null || usuario.password=="")
            {
                ModelState.AddModelError("password","campo obligatorio");
            }
        }
    }
}