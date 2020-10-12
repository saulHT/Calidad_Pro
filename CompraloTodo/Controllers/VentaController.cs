using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompraloTodo.Db;
using CompraloTodo.Extensions;
using CompraloTodo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore;

namespace CompraloTodo.Controllers
{
    public class VentaController : Controller
    {
        private CompraloTodoContex db;
        public VentaController(CompraloTodoContex db)
        {
            this.db = db;
        }
        public IActionResult ComprasDEmo(int? idusuario, int? idProducto)
        {
            if (idusuario==null || idProducto==null)
            {
                return View();
            }
            var venta = db.productos.Include(o => o.Usuario).FirstOrDefault();
            
            
            return View();
        }


        [HttpGet]
        public IActionResult Compras(int? idusuario)
        {
            var sesion = HttpContext.Session.Get<Usuario>("sesionUser");

            if (idusuario !=null)
            {
                var listaVentas = db.ventas.Where(v => v.idUsuario == sesion.id).Include(o => o.Usuario).ToList();
                ViewBag.listaDetalle = db.detalleVentas.Include(o => o.Venta).Include(o => o.Producto).ToList();
                ViewBag.listaUsuario = db.usuarios.ToList();
                ViewBag.nombre = sesion.nombre;
                int usuarioId = sesion.id;
                
                return View(listaVentas);
            }
              return RedirectToAction("Detalle","Producto");
        }

        [HttpGet]
        public IActionResult DetalleCompras(int? idVenta)
        {

            return View();
        }

        [HttpGet]
        public IActionResult Carrito(int? idUsuario)
        {

            return View();
        }

        [HttpPost]
        public bool ExisteProductoYusuarioCarrito(int? idUsuario, int? idProducto)
        {

            return false;
        }

        [HttpPost]
        public bool GuardarProductoACarrito(int IdUsuario, int IdProducto, int Cantidad)
        {

            return true;
        }

        [HttpPost]
        public bool ActualizarCantidadProductoCarrito(int? IdUsuario, int? IdProducto, int NuevaCantidad)
        {
           

            return false;

        }

        [HttpGet]
        public IActionResult EliminarProductoDeCarrito(int? IdProducto, int? IdUsuario)
        {
            

            return RedirectToAction("Index", "Error");
        }
    }
}