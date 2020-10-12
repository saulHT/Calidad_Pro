using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompraloTodo.Db;
using CompraloTodo.Extensions;
using CompraloTodo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompraloTodo.Controllers
{
    public class UsuarioController : Controller
    {
        public CompraloTodoContex db;
        public UsuarioController(CompraloTodoContex db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
           
            return View();
        }
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(Usuario usuario)
        {
            if (db.usuarios.Any(o => o.email == usuario.email))
                ModelState.AddModelError("email","el correo ya existe");
            if (usuario.nombre == null || usuario.nombre == "")
                ModelState.AddModelError("nombre","campo obligatorio");
            if (usuario.apellido == null || usuario.apellido == "")
                ModelState.AddModelError("apellido", "campo obligatorio");
            if (usuario.email == null || usuario.email == "")
                ModelState.AddModelError("email", "campo obligatorio");
            if (usuario.password == null || usuario.password == "")
                ModelState.AddModelError("password", "campo obligatorio");

            if (ModelState.IsValid)
            {
                usuario.rol = "usuario";
                db.usuarios.Add(usuario);
                db.SaveChanges();
                
                return RedirectToAction("Login","Auth");
            }

            return View();
        }
    }
}