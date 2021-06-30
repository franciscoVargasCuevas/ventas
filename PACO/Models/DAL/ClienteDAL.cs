using PACO.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PACO.Models;
using System.Web.UI.WebControls;

namespace PACO.Models.DAL
{
    public class ClienteDAL
    {

        public List<ClienteViewModel> getClient() {
            List<ClienteViewModel> lst = null;
            using (VENTAEntities db = new VENTAEntities())
            {
                lst = (from d in db.CLIENTES
                       select new ClienteViewModel
                       {
                           id = d.ID_CLIENTE,
                           nombre = d.NOMBRE,
                           apellidos = d.APELLIDOS,
                           direccion = d.DIRECCION
                       }).ToList();

            }
            return lst;
        }

        public void setNewClient(ClienteViewModel model)
        {
            using (VENTAEntities db = new VENTAEntities())
            {
                var oTabla = new CLIENTES();
                oTabla.ID_CLIENTE = model.id;
                oTabla.NOMBRE = model.nombre;
                oTabla.APELLIDOS = model.apellidos;
                oTabla.DIRECCION = model.direccion;

                db.CLIENTES.Add(oTabla);
                db.SaveChanges();
            }
        }

        public ClienteViewModel putClient(int id)
        {
            ClienteViewModel model = new ClienteViewModel();
            using (VENTAEntities db = new VENTAEntities())
            {
                var oTabla = db.CLIENTES.Find(id);
                model.nombre = oTabla.NOMBRE;
                model.apellidos = oTabla.APELLIDOS;
                model.direccion = oTabla.DIRECCION;
                model.id = oTabla.ID_CLIENTE;
            }
            return model;
        }

        public bool putClient(ClienteViewModel model)
        {
            using (VENTAEntities db = new VENTAEntities())
            {
                var oTabla = db.CLIENTES.Find(model.id);
                oTabla.NOMBRE = model.nombre;
                oTabla.APELLIDOS = model.apellidos;
                oTabla.DIRECCION = model.direccion;

                db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return true;
        }

        public void delClient(int id)
        {
            using (VENTAEntities db = new VENTAEntities())
            {
                var oTabla = db.CLIENTES.Find(id);
                db.CLIENTES.Remove(oTabla);
                db.SaveChanges();
            }
        }

    }
}