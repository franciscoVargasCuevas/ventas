using PACO.Models.BL;
using PACO.Models.ViewModels;
using System;
using System.Web.Mvc;


namespace PACO.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            ClienteBL data = new ClienteBL();
                return View(data.getClient());
        }

        public ActionResult Nuevo() {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(ClienteViewModel model)
        {
            if (ModelState.IsValid) {
                ClienteBL setNew = new ClienteBL();
                setNew.setNewClient(model);
                return Redirect("Index");
            }
            return View(model);
          
        }//Nuevo

        public ActionResult Editar(int id)
        {
            ClienteBL putNew = new ClienteBL();
            return View(putNew.putClient(id));
        }

        [HttpPost]
        public ActionResult Editar(ClienteViewModel model)
        {
            if (ModelState.IsValid)
            {
                ClienteBL setNew = new ClienteBL();
                if (setNew.putClient(model)) {
                    return Redirect("~/Cliente/Index");
                }    
            }
            return View(model);

        }//Nuevo

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            ClienteBL putNew = new ClienteBL();
            putNew.delClient(id);
            return Redirect("~/Cliente/Index");
        }

    }
}