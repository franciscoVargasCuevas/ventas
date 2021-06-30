using PACO.Models.BL;
using PACO.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace PACO.Controllers
{
    public class ComprarArticuloController : Controller
    {
        ArticuloBL data = new ArticuloBL();
        // GET: Articulo
        public ActionResult Index()
        {
            return View(data.getArticulo());
        }

        public ActionResult SET(int id)
        {
            Session["id_articulo"] = id;

            return View(data.putArticulo(id));
        }

        public ActionResult COMPRAR(ArticuloViewModel model)
        {
         
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Deseas comprar el artículo";
                string caption = "Comprar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    
                }
            

            return View();
        }

    }
}