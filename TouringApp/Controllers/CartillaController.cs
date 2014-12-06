using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TouringApp.Models.TO;
using TouringApp.Models.DAO;

namespace TouringApp.Controllers
{
    public class CartillaController : Controller
    {
        //
        // GET: /Cartilla/
        public ActionResult Index()
        {
            Cartilla objCartilla = CartillaDAO.Instance.CartillaObtener(Convert.ToInt32(Session["LogeadoUsuarioId"]));
            return View(objCartilla);
        }
	}
}