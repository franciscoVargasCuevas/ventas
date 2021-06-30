using PACO.Models.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace PACO.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            ClienteBL data = new ClienteBL();
            return View(data.getClient());
        }

        public ActionResult Ingresar()
        {
            var ses = Session["cliente"];
            MessageBox.Show((string)ses, "Cliente");
            return View();
        }

    }
}