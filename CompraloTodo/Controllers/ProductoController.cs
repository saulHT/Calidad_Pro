using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CompraloTodo.Db;
using CompraloTodo.Extensions;
using CompraloTodo.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompraloTodo.Controllers
{
    public class ProductoController : Controller
    {
        private CompraloTodoContex db;
        private IWebHostEnvironment env;

        public ProductoController(CompraloTodoContex db,IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }
        public IActionResult Index()
        {
           
            var sesion = HttpContext.Session.Get<Usuario>("sesionUser");
            ViewBag.usuario = sesion.nombre;
            ViewBag.id = sesion.id;

            var Listproductos = db.productos.Where(o=>o.idUsuario==sesion.id).ToList();
            return View(Listproductos);
        }
        [HttpGet]
        public IActionResult Crear()
        {
            ViewBag.categoria = db.categorias.ToList();
            return View(new Producto());
        }
        [HttpPost]
        public IActionResult Crear(Producto product,IFormFile imagen)
        {
            //    if (product.nombre == "" || product.nombre == null)
            //        ModelState.AddModelError("nombre","campo obligatorio");
            //    if (product.precio == 0 || string.IsNullOrEmpty(product.precio.ToString()))
            //        ModelState.AddModelError("precio", "campo obligatorio");
            //    if (product.imagen==null)
            //        ModelState.AddModelError("imagen", "campo obligatorio");
            //    if (product.descripcion == "" || product.descripcion == null)
            //        ModelState.AddModelError("descripcion", "campo obligatorio");

            var sesion = HttpContext.Session.Get<Usuario>("sesionUser");
            if (ModelState.IsValid)
            {
                if(imagen != null)
                {
                    var filePath = Path.Combine(env.WebRootPath,"imagen",imagen.FileName);

                    using (var stream=new FileStream(filePath,FileMode.Create))
                    {
                        imagen.CopyTo(stream);
                    }
                    product.imagen = imagen.FileName;
                }
                product.idUsuario = sesion.id;

                db.productos.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        [HttpGet]
       public IActionResult Editar(int id)
        {
            var producto = db.productos.Include(c=>c.Categoria).Where(o => o.id == id).FirstOrDefault();
            
            ViewBag.categoria = db.categorias.ToList();
            return View(producto);
        }

        [HttpPost]
        public IActionResult Editar(Producto pro, IFormFile imagen)
        {
            if (ModelState.IsValid)
            {
                if (imagen != null)
                {
                    var filePath = Path.Combine(env.WebRootPath, "imagen", imagen.FileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        imagen.CopyTo(stream);
                    }
                    pro.imagen = imagen.FileName;
                }
                db.productos.Update(pro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pro);
            
        }

        [HttpGet]
        public RedirectToActionResult Eliminar(int id)
        {
            var produc = db.productos.Where(c => c.id == id).Include(o=>o.Categoria).First();

            
            db.productos.Remove(produc);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult BuscarProducto()
        {
            return View();
        }

        public IActionResult ListarProductos()
        {
            //var sesion = HttpContext.Session.Get<Usuario>("sesionUser");

            var listas = db.productos.Include(o=>o.Usuario).ToList();

            return View(listas);
        }

        public IActionResult Detalle(int? id)
        {
            var product = db.productos.Include(u=>u.Usuario).FirstOrDefault(o => o.id == id);

            return View(product);
        }

        [HttpGet]
        public IActionResult CrearComentario( int idUsuario, int idProducto)
        {
            var usuario = db.usuarios.Where(o => o.id == idUsuario).FirstOrDefault();
            var produc = db.productos.Where(o=>o.id==idProducto).Include(c=>c.Categoria).FirstOrDefault();

            ViewBag.usuario = usuario;
            ViewBag.producto = produc;
            return View(new Comentarios());
        }
        [HttpPost]
        public IActionResult CrearComentario(Comentarios comentario)
        {

            if (ModelState.IsValid)
            {
                comentario.fecha = DateTime.Now;
                db.Comentarios.Add(comentario);
                db.SaveChanges();
                return RedirectToAction("CrearComentario");
               
            }
            return View(comentario);

        }
    }
}