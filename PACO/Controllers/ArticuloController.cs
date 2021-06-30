using PACO.Models.BL;
using PACO.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PACO.Controllers
{
    public class ArticuloController : Controller
    {
        ArticuloBL data = new ArticuloBL();
        // GET: Articulo
        public ActionResult Index()
        {
            return View(data.getArticulo());
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(ArticuloViewModel model)
        {
            if (ModelState.IsValid)
            {
                data.setNewArticulo(model);
                return Redirect("Index");
            }
            return View(model);

        }//Nuevo


        public ActionResult Editar(int id)
        {
            return View(data.putArticulo(id));
        }

        [HttpPost]
        public ActionResult Editar(ArticuloViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (data.putArticulo(model))
                {
                    return Redirect("~/Articulo/Index");
                }
            }
            return View(model);

        }//Nuevo

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            data.delArticulo(id);
            return Redirect("~/Articulo/Index");
        }

    }
}