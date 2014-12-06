using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TouringApp.Models.DAO;
using TouringApp.Models.TO;

namespace TouringApp.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Usuario user)
        {
            if (ModelState.IsValid)
            {
                Usuario objUsuario = UsuarioDAO.Instance.UsuarioAutenticar(user.DNI, user.Contraseña);

                if (objUsuario != null)
                {
                    Session["LogeadoUsuarioId"] = objUsuario.UsuarioID.ToString();
                    Session["LogeadoUsuarioDni"] = objUsuario.DNI.ToString();
                    Session["LogeadoUsuarioNombre"] = objUsuario.Nombre.ToString();
                    Session["LogeadoUsuarioApellido"] = objUsuario.Apellido.ToString();
                    Session["LogeadoUsuarioCorreo"] = objUsuario.Correo.ToString();
                    Session["LogeadoUsuarioTelefono"] = objUsuario.Telefono.ToString();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Message = "Datos indicados son incorrectos.";
                }
                
            }
            return View(user);
        }
	}
}