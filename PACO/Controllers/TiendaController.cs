using PACO.Models;
using PACO.Models.BL;
using PACO.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PACO.Controllers
{
    public class TiendaController : Controller
    {
        TiendaBL data = new TiendaBL();
        // GET: Tienda
        public ActionResult Index()
        {
            return View(data.getTienda());
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(TiendaViewModel model)
        {
            if (ModelState.IsValid)
            {
                data.setNewTienda(model);
                return Redirect("Index");
            }
            return View(model);

        }//Nuevo
        
        public ActionResult Editar(int id)
        {
            
            return View(data.putTienda(id));
        }

        [HttpPost]
        public ActionResult Editar(TiendaViewModel model)
        {
            if (ModelState.IsValid)
            {
               
                if (data.putTienda(model))
                {
                    return Redirect("~/Tienda/Index");
                }
            }
            return View(model);

        }//Nuevo

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            data.delTienda(id);
            return Redirect("~/Tienda/Index");
        }



    }
}